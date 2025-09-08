import os
import requests
from bs4 import BeautifulSoup
import zipfile
import io

BASE_URL = "https://cses.fi"
PROBLEM_URL = BASE_URL + "/problemset/task/"
TEST_URL = BASE_URL + "/problemset/tests/"

# Where everything is stored
BASE_DIR = "./rust"
TEST_DIR = os.path.join(BASE_DIR, "tests")

# --- COOKIE SETUP ---
SESSION = requests.Session()
SESSION.cookies.set(
    "PHPSESSID",
    "beeb81e65931af01a006d09da19e1ef2fbae89bc",   # 👈 paste your cookie here
    domain="cses.fi"
)

problems = {}
headings = []

def problem_list():
    with open("./list.html", "r") as prbList:
        soup = BeautifulSoup(prbList, "html.parser")

        for i in soup.find_all("h2"):
            headings.append(i.getText().replace(" ", ""))

        index = -1
        for i in soup.find_all("ul", "task-list"):
            probs = i.find_all("a", href=True)
            index += 1
            headingName = headings[index]
            problems[headingName] = {}
            for j in probs:
                problems[headingName][j.get("href").rsplit("/", 1)[-1]] = j.getText().replace(" ", "")


def create_cpp(problem_heading, problem_number, problem_name):
    subfolder = os.path.join(BASE_DIR, problem_heading)
    os.makedirs(subfolder, exist_ok=True)

    cpp_filename = os.path.join(subfolder, f"{problem_name}{problem_number}.cpp")
    if not os.path.exists(cpp_filename):
        with open(cpp_filename, "w") as cpp_file:
            cpp_file.write(f"""#include <bits/stdc++.h>
using namespace std;

int main() {{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    // CSES Problem: {problem_name} ({problem_number})
    // Reads from stdin, writes to stdout
    // Sample usage for debugging against test files:
    // freopen("input.in", "r", stdin);
    // freopen("output.out", "w", stdout);

    int n;
    cin >> n;
    cout << n << "\\n";

    return 0;
}}
""")
    return cpp_filename


def create_rust(problem_heading, problem_number, problem_name):
    """Create a Rust file in src/bin so it can be run individually with cargo run --bin"""
    bin_dir = os.path.join(RUST_PROJECT, "src", "bin")
    os.makedirs(bin_dir, exist_ok=True)

    rust_filename = os.path.join(bin_dir, f"{problem_name}{problem_number}.rs")

    # Path to test folder
    test_folder = os.path.join(TEST_DIR, problem_heading, f"{problem_name}{problem_number}")
    os.makedirs(test_folder, exist_ok=True)

    # Pick a test file if available
    test_files = [f for f in os.listdir(test_folder) if f.endswith(".in")]
    test_path = os.path.join(test_folder, test_files[0]) if test_files else "input.in"

    if not os.path.exists(rust_filename):
        with open(rust_filename, "w") as rust_file:
            rust_file.write(f"""use std::fs::File;
use std::io::{{self, BufRead, BufReader}};

fn main() {{
    // CSES Problem: {problem_name} ({problem_number})
    // Reads from test file or stdin

    let path = "{test_path}";
    let file = File::open(path).expect("Failed to open input file");
    let mut reader = BufReader::new(file);

    let mut line = String::new();
    reader.read_line(&mut line).unwrap();
    let n: i64 = line.trim().parse().unwrap();

    println!("n = {{}}", n);
}}
""")
    return rust_filename

def download_tests(problem_number, tests_dir):
    os.makedirs(tests_dir, exist_ok=True)

    url = f"{TEST_URL}{problem_number}/"
    resp = SESSION.get(url)
    if resp.status_code != 200:
        print(f"❌ Failed to open tests page for {problem_number}")
        return False

    soup = BeautifulSoup(resp.content, "html.parser")
    csrf_token = soup.find("input", {"name": "csrf_token"})
    if not csrf_token:
        print(f"⚠️ No csrf token for {problem_number}")
        return False

    token_value = csrf_token["value"]

    # Submit POST to download zip
    post_data = {"csrf_token": token_value, "download": "true"}
    zip_resp = SESSION.post(url, data=post_data)
    if zip_resp.status_code != 200:
        print(f"❌ Failed to download tests for {problem_number}")
        return False

    try:
        with zipfile.ZipFile(io.BytesIO(zip_resp.content)) as z:
            z.extractall(tests_dir)
        print(f"✅ Tests downloaded for {problem_number}")
        return True
    except zipfile.BadZipFile:
        print(f"⚠️ Not a zip file for {problem_number}")
        return False


def main():
    os.makedirs(BASE_DIR, exist_ok=True)
    os.makedirs(TEST_DIR, exist_ok=True)

    problem_list()

    for problem_heading, innerObj in problems.items():
        testfolder = os.path.join(TEST_DIR, problem_heading)
        os.makedirs(testfolder, exist_ok=True)

        for problem_number, problem_name in innerObj.items():
            cpp_file = create_cpp(problem_heading, problem_number, problem_name)

            tests_dir = os.path.join(testfolder, f"{problem_name}{problem_number}")
            download_tests(problem_number, tests_dir)


if __name__ == "__main__":
    main()
