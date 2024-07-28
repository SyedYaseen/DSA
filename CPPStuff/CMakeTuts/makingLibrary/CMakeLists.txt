cmake_minimum_required(VERSION 3.10.1)
project(makingLibrary) 
add_library(${PROJECT_NAME} STATIC adder.cpp)

# Specify where to place the library file (optional)
set_target_properties(${PROJECT_NAME} PROPERTIES 
    ARCHIVE_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/lib)

