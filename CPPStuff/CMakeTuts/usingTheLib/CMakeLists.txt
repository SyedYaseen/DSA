cmake_minimum_required(VERSION 3.13)
project(usingLibsTest)

# Specify the path to the adder header

include_directories("${CMAKE_SOURCE_DIR}/../makingLibrary")
link_directories("${CMAKE_SOURCE_DIR}/../makingLibrary/build/lib")
add_executable(${PROJECT_NAME} main.cpp)

target_link_libraries(${PROJECT_NAME} PRIVATE makingLibrary)