#include <iostream>
#include <string>
#include <vector>
#include <bits/stdc++.h>

using namespace std;

int main()
{
    int n;
    cin >> n; cin.ignore();
    double ans = 0;
    for (int i = 0; i < n; i++) {
        string s;
        int a;
        int b;
        cin >> s >> a >> b; cin.ignore();
        if (s == "R") ans += a * b;
        else ans += 3.141592653 * a * a;
    }
    cout << setprecision(2) << fixed << ans << endl;
}