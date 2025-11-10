#include <bits/stdc++.h>
using namespace std;

int fib(int num, unordered_map<int, int> &mem)
{
    if (num == 0)
        return 0;

    if (num == 1)
        return 1;

    if (mem[num])
        return mem[num];

    mem[num] = fib(num - 1, mem) + fib(num - 2, mem);
    return mem[num];
}

int main()
{
    // unordered_map<int, int> mem;
    // cout << fib(3, mem);
    int num = 3;
    if (num <= 1)
        return num;

    int dp[2]{0, 1};
    int i = 2;
    while (i <= num)
    {
        int temp = dp[1];
        dp[1] = dp[0] + dp[1];
        dp[0] = temp;
        i++;
    }
    cout << dp[1];

    return 0;
}
