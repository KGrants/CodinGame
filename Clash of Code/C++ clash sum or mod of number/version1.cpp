#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
    int n;
    int a=0;
    int b = 0;
    cin >> n; cin.ignore();
    if(n<10)
    {
        cout<<n%2;
    }
    else{
    while (n != 0) {
            a = a + (n % 10);
            n = n / 10;
        }
    while (a != 0){
        b = b + (a % 10);
        a = a / 10;
    }
    cout<<b;
    }
}