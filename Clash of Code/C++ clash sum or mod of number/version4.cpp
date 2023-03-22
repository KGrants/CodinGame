#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/

int main()
{
    int a;
    cin >> a; cin.ignore();
    if(a < 10)
        cout << a % 2;
    else
        {
            while(a > 9)
            {
                int aux = a;
                a = 0;
                while(aux)
                {
                    a += aux % 10;
                    aux /= 10;
                }
                
            }
            cout << a;
        }
}