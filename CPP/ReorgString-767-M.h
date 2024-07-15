#pragma once
using namespace std;
#include <map>
#include <queue>

//https://leetcode.com/problems/reorganize-string/solutions/3949690/c-easy-priority-queue-solution-with-good-code-quality-and-comments-beats-100-users/
// https://www.youtube.com/watch?v=2g_b1aYTHeg&ab_channel=NeetCode

// Create a max heap
// Add top's value to res
// Pop from max heap
// Set that to the blocked value
// In next iteration, use the top most value
// If there is a valid blocked value present then push that to the heap to use it
// set the current value that was added to result to blocked value

class Solution {
public:
    string reorganizeString(string s) {

        // Create a freq array
        // Go from back until all values are empty
        map<char, int> dict;
        for (auto i = s.begin(); i != s.end(); i++) {
            dict[*i] += 1;           
        }

        priority_queue<pair<int, char>> pq;

        for (auto& it : dict) {
            pq.push(make_pair(it.second, it.first));
        }
        
        string res = "";

        pair<char, int> block = { -1, '&' };
        while (!pq.empty()) {
            pair<int, char> top = pq.top();
            res += top.second;
            top.first--;
            pq.pop();

            if (block.first > 0) pq.push(block);
            block = top;        
        }
        
        if (res.size() == s.size()) return res; // There is still one value blocked, but heap is empty
        return "";
    }
};