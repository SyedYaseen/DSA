cmake_minimum_required(VERSION 3.13)
project(usingLibsTest)

# Specify the path to the adder header

include_directories("${CMAKE_SOURCE_DIR}/../makingLibrary")
link_directories("${CMAKE_SOURCE_DIR}/../makingLibrary/build/lib")
add_executable(${PROJECT_NAME} main.cpp)
 
add_subdirectory(external/glfw)
target_include_directories(${PROJECT_NAME} 
    PUBLIC external/glfw/include)

target_link_directories(${PROJECT_NAME} 
    PRIVATE external/glfw/src) # path from build folder



target_link_libraries(${PROJECT_NAME} 
    PRIVATE makingLibrary glfw)