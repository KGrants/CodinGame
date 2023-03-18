#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
    int n;
    cin >> n; cin.ignore();

    int res = 0;
    int cpy = n;
    int p = 2;

    while (p <= cpy)
    {
        while (cpy % p == 0)
        {
            cpy = cpy/p;
            res += n/p;
        }
        p += 1;
    }

    cout << res << endl;
}