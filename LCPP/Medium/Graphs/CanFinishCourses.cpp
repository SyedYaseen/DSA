#include "../../imports.h"

class Solution {
public:
    bool canFinish(int numCourses, vector<vector<int>>& prerequisites) {
        if (prerequisites.empty()) return true;

        // if (numCourses > prerequisites.size() / 2) return true;
        unordered_map<int,vector<int>> m;

        for (auto i: prerequisites) {
            if (m.contains(i[1])) {
                auto isPresent = find(
                    m[i[1]].begin(), 
                    m[i[1]].end(), 
                    i[0]
                    );
                if (isPresent != m[i[1]].end()) { return false; }
                
            }
            m[i[1]].push_back(i[0]);
            numCourses--;
        }

        if (numCourses-1 == 0) return true;
        else return false; 
    }
};

int main() {
    Solution s;


    vector<vector<int>> a = {{0,10},{3,18},{5,5},{6,11},{11,14},{13,1},{15,1},{17,4}};
    s.canFinish(20, a);

    a = {{1,0}};
    s.canFinish(3, a);


    return 0;
}
