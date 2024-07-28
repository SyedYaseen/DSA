1. CMake -> Makes makefile
2. makefile -> Runs a bunch commands like where the main.cpp's out file must be

## Commands

Uses default VS compiler
cmake ..
cmake --build .

Uses MinGW - Havent configured it properly yet
cmake -S CMakeLists.txtLoc -B BuildFolder
cmake -G "MinGW Makefiles" . -B ./build
cmake -G "MinGW Makefiles" ..

## Make a library

1. Write the code
2. Configure build system to make it a library
3. "Creating a namespace" helps avoid ambiguous function calls
   - We might get errors saying that the function call is ambiguous
4. ".a" extensions are static libraries on windows. ".so" is shared objects (.dll on windows?)
