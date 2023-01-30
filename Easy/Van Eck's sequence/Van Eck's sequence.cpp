#include <iostream>
#include <algorithm>
#pragma GCC optimize("-O3")

using namespace std;

int main()
{
    int next_num;
    cin >> next_num; cin.ignore();
    int N;
    cin >> N; cin.ignore();
    int distance;

    unordered_map<int,int> a;

    for (int i = 0; i<N-1; i++)
    {
        if (a.count(next_num))
            distance = i- a[next_num];
        else 
            distance = 0;

        a[next_num] = i;
        next_num = distance;
    }
    cout<<next_num;
}