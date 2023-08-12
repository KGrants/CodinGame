#include <bits/stdc++.h>
using namespace std;

int main() {
    int a,b,c; cin >> a >> b >> c;
    int income = a*6*5*4;
    if (income >=b+c) {
        cout << "true";
    } else {
        cout << "false";
    }
}
