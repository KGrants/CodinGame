#include <iostream>

using namespace std;

int main()
{
    int n;
    cin >> n; cin.ignore();
    int sum = 0;
    int product = 1;

    for (int i = 1; i <= n; i++)
    {
        sum += i;
        product *= i;

    }
        cout<<product<<endl;
        cout<<sum<<endl;
}