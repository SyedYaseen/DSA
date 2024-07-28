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

### Making Library

```
cmake_minimum_required(VERSION 3.10)
project(makingLibrary)
```

### static creates a static .lib file

```
add_library(${PROJECT_NAME} STATIC adder.cpp)
```

### Specify where to place the library file

```
set_target_properties(${PROJECT_NAME} PROPERTIES
ARCHIVE_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/lib)
```

### Using/ Linking Library

```
cmake_minimum_required(VERSION 3.13)
project(usingLibsTest)
```

```
include_directories("${CMAKE_SOURCE_DIR}/../makingLibrary")
```

1. Adds the specified directory to the list of paths that the compiler will search for header files.
2. ${CMAKE_SOURCE_DIR} = top-level source directory.
3. If this line is omitted, the compiler won't know where to find adder.h.
   <br>

```
link_directories("${CMAKE_SOURCE_DIR}/../makingLibrary/build/lib")
```

1. Adds the specified directory to the list of paths that the linker will search for libraries.
2. This path should contain the static library makingLibrary.lib or libmakingLibrary.a.
3. Causes linker error stating that linker cannot find the library makingLibrary.
   <br>

```
add_executable(${PROJECT_NAME} main.cpp)
```

1. Defines an executable target named usingLibsTest (the value of ${PROJECT_NAME}) with the source file main.cpp.
2. executable wont be create if its not there

```
target_link_libraries(${PROJECT_NAME} PRIVATE makingLibrary)
```

1. Links the makingLibrary static library to the usingLibsTest executable.
2. The PRIVATE keyword indicates that makingLibrary is used only for the build of this executable and not for any dependent targets.
3. If not present, the usingLibsTest executable won't be linked against the makingLibrary static library.

## Summary

- Include Directories: Ensure the compiler can find the headers.
- Link Directories: Ensure the linker can find the libraries.
- Add Executable: Defines the executable target to be built.
- Link Libraries: Links the required static library to the executable.
