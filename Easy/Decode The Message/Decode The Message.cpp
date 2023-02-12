#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
    long long p;
    cin >> p; cin.ignore();
    string c;
    getline(cin, c);
    string answer = "";

    while (p>= 0) 
        { 
            answer += c[ p % c.length() ]; 
            p = p / c.length() - 1; 
        } 
    cout << answer << endl;
}