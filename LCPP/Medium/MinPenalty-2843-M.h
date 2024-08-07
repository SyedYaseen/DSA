#pragma once
#include<iostream>
using namespace std;

//int a = s.bestClosingTime("YYNY");
//int a = s.bestClosingTime("NYNNNYYN"); // ans 0
class Solution {
public:
    int bestClosingTime(string customers) {
        // vector<int> sum = {};
        int current = 0;
        int highest = 0;
        int res = 0;

        for (int i = 0; i < customers.size(); i++) {

            if (customers[i] == 'Y') current++;
            else current--;

            if (current > highest) highest = current;

            // sum[i]=current;
        }

        if (highest == 0) return 0;
        current = 0;
        

        for (int i = 0; i < customers.size(); i++) {

            if (customers[i] == 'Y') current++;
            else current--;

            if (current == highest) res = i + 1;
            break;

            // sum[i]=current;
        }

        return res;

        // Find highest at the lowest index
        // current=0;
        // int lowestIndex=-1;
        // for (int i = 0; i< sum.size(); i++) {
        //     if (sum[i] > current) {
        //         current=sum[i];
        //         lowestIndex=i;
        //     }

        // }

        // return lowestIndex + 1;
        
    }
};