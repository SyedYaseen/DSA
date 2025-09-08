import os
import requests
from bs4 import BeautifulSoup

BASE_URL = "https://cses.fi"
PROBLEM_URL = BASE_URL + "/problemset/task/"
TEST_URL = BASE_URL + "/problemset/tests/"

# Where everything is stored
RUST_PROJECT = "/home/uggi/projects/DSA/CSES-rust"
TEST_DIR = "/home/uggi/projects/DSA/CSES/tests"

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
    let path = "{test_path}";
    let file = File::open(path).expect("Failed to open input file");
    let mut reader = BufReader::new(file);

    let mut line = String::new();
    reader.read_line(&mut line).unwrap();
    let n: i64 = line.trim().parse().unwrap();

    println!("n = {{}}", n);
}}
""")
        print(f"✅ Created Rust file: {rust_filename}")
    else:
        print(f"⚠️ Rust file already exists: {rust_filename}")

    return rust_filename


def main():
    problem_list()
    for problem_heading, innerObj in problems.items():
        for problem_number, problem_name in innerObj.items():
            create_rust(problem_heading, problem_number, problem_name)


if __name__ == "__main__":
    main()
