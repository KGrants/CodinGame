#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <math.h>

using namespace std;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/

int main()
{
    int n;
    cin >> n; cin.ignore();
    for (int i = 0; i < n; i++) {
        long int a;
        long int b;
        cin >> a >> b; cin.ignore();
        long int f,s;
        f = pow(a,2) + pow(b,2);
        s = pow(a+b,2);
        if(f>s)
            cout << ">";
        else if(f==s)
            cout << "=";
        else
            cout << "<";
        cout<<endl;
    }
}