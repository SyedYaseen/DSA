#include "../../imports.h"

class Solution
{

private:
    int f[26] = {0};

    bool checkEq(int i, int size, string s2)
    {
        int f2[26] = {0};
        for (int j = i; j < i + size; j++)
        {
            f2[s2[j] - 'a']++;
        }

        for (int i = 0; i < 26; i++)
        {
            if (f[i] != f2[i])
                return false;
        }
        return true;
    }

public:
    bool checkInclusion(string s1, string s2)
    {
        if (s2.size() < s1.size())
            return false;

        for (int i = 0; i < s1.size(); i++)
        {
            f[s1[i] - 'a']++;
        }

        int index = 0;
        while (index + s1.size() < s2.size())
        {
            if (checkEq(index, s1.size(), s2))
                return true;
            index++;
        }
        return false;
    }
    // Shit performance
    bool checkInclusion2(string s1, string s2)
    {

        if (s2.size() < s1.size())
            return false;

        if (s2.size() == 1 && s1.size() == 1)
        {
            return s1[0] == s2[0] ? true : false;
        }

        unordered_map<char, int> m;
        for (int i = 0; i < s1.size(); i++)
        {
            m[s1[i]]++;
        }

        unordered_map<char, int> m_copy = m;

        int i = 0;
        int j = 0;
        bool modified = false;

        while (j < s2.size())
        {
            if (j - i == s1.size() && m_copy.empty())
            {
                // Check all elements
                return true;
            }
            else if (!m_copy.contains(s2[j]))
            {
                i += 1;
                j = i;
                if (modified)
                {
                    m_copy = m;
                    modified = false;
                }
            }

            else if (m_copy.contains(s2[j]))
            {

                modified = true;
                m_copy[s2[j]]--;
                if (m_copy[s2[j]] == 0)
                {
                    m_copy.erase(s2[j]);
                }
                j++;
            }
        }

        if (m_copy.empty())
            return true;

        return false;
    }
};

int main()
{
    Solution s;

    // string s1 = "ab";
    // string s2 = "eidbaooo";
    string s1 = "adc";
    string s2 = "dcda";
    s.checkInclusion(s1, s2);
}