import os
import requests
from bs4 import BeautifulSoup
import zipfile
import shutil

# Base URL for CSES problems (replace if different)
BASE_URL = 'https://cses.fi/problemset/task/'

# Directory where everything will be stored
BASE_DIR = './'
TEST_DIR = BASE_DIR + './tests/'

# Problem numbers and problem names (you can expand this list)
problems = {
}
headings = []

def problem_list():
    prbList = open('./others/list.html','r')
    soup = BeautifulSoup(prbList, 'html.parser')
    
    for i in soup.find_all('h2'):
        headings.append(i.getText().replace(" ", ""))
    
    index = -1
    
    
    for i in soup.find_all('ul', 'task-list'):
        probs = i.find_all('a', href=True)
        index+=1
        headingName = headings[index]
        problems[headingName] = {}
        for j in  probs:
            problems[headings[index]][j.get('href').rsplit("/", 1)[-1]] = j.getText().replace(" ", "")
        

def download_problem(problem_heading, problem_number, problem_name):
    
    # Fetch problem page
    # url = f'{BASE_URL}{problem_number}'
    # response = requests.get(url)
    # if response.status_code != 200:
    #     print(f"Failed to fetch problem {problem_number}")
    #     return

    # # Parse the page to extract the description
    # soup = BeautifulSoup(response.content, 'html.parser')

    # Create a .cpp file with the description inside
    cpp_filename = os.path.join(BASE_DIR, problem_heading, f"{problem_name}{problem_number}.cpp")
    with open(cpp_filename, 'w') as cpp_file:

        cpp_file.write("""
#include <bits/stdc++.h>
using namespace std;
void setIO(string name)
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);
    freopen((name + ".in").c_str(), "r", stdin);
    freopen((name + ".out").c_str(), "w", stdout);
}

int main()
{
    setIO("./tests/1");
}
                       """)

    # Create tests directory
    tests_dir = os.path.join(TEST_DIR,problem_heading, f"{problem_name}{problem_number}")
    os.makedirs(tests_dir, exist_ok=True)

def main():
    # Create base directory if it doesn't exist
    
    problem_list()
    # print(problems)
    os.makedirs(BASE_DIR, exist_ok=True)
    os.makedirs(TEST_DIR, exist_ok=True)

    # Iterate over all problems and download them
    for problem_heading, innerObj in problems.items():
        subfolder = os.path.join(BASE_DIR,problem_heading)
        testfolder = os.path.join(TEST_DIR,problem_heading)
        os.makedirs(subfolder, exist_ok=True)
        os.makedirs(testfolder, exist_ok=True)

        for problem_number, problem_name in innerObj.items():
            download_problem(problem_heading, problem_number, problem_name)

if __name__ == '__main__':
    main()
