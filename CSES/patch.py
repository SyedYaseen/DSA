import os
import re

# Base directories
BASE_CPP_DIR = "/home/uggi/projects/DSA/CSES"  # your cpp files
BASE_TEST_DIR = os.path.join(BASE_CPP_DIR, "tests")  # tests folder

def patch_cpp(file_path):
    filename = os.path.basename(file_path)
    match = re.match(r"(.+?)(\d+)\.cpp", filename)
    if not match:
        print(f"Skipping {file_path}, filename doesn't match")
        return

    problem_name, problem_id = match.groups()
    problem_heading = os.path.basename(os.path.dirname(file_path))

    # Find first test file in the test folder
    test_folder = os.path.join(BASE_TEST_DIR, problem_heading, f"{problem_name}{problem_id}")
    if not os.path.exists(test_folder):
        print(f"No test folder for {file_path}")
        return

    test_files = sorted([f for f in os.listdir(test_folder) if f.endswith(".in")])
    if not test_files:
        print(f"No .in files in {test_folder}")
        return

    first_test_file = os.path.join(test_folder, test_files[0])

    # Read current cpp
    with open(file_path, "r") as f:
        code = f.read()

    # 1️⃣ Add #include "./helper.h" if not already present
    if '#include "./helper.h"' not in code:
        # Insert after the last #include
        includes = list(re.finditer(r'#include\s*[<"].+[>"]', code))
        if includes:
            last_include = includes[-1]
            pos = last_include.end()
            code = code[:pos] + '\n#include "./helper.h"' + code[pos:]
        else:
            code = '#include "./helper.h"\n' + code

    # 2️⃣ Replace any setIO(...) with correct path
    code = re.sub(
        r'setIO\s*\(\s*.*?\s*\)\s*;',
        f'setIO("{first_test_file}") ;',
        code
    )

    with open(file_path, "w") as f:
        f.write(code)

    print(f"Patched {file_path} -> reads {first_test_file} and added helper.h include")


def main():
    for root, _, files in os.walk(BASE_CPP_DIR):
        for file in files:
            if file.endswith(".cpp"):
                patch_cpp(os.path.join(root, file))


if __name__ == "__main__":
    main()
