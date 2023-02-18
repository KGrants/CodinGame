#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <list>

using namespace std;

int main()
{
    list<int> lst;
    int answer = 9999;
    int n;
    cin >> n; cin.ignore();
    for (int i = 0; i < n; i++) 
    {
        int pi;
        cin >> pi; cin.ignore();
        lst.push_back(pi);
    }

    lst.sort();

    list<int>::iterator it = lst.begin();

    for (int i = 0; i < n; i++)
    {
        int a1 = *it;
        advance(it,1);
        int a2 = *it;
        if (abs(a1-a2)<answer)
        {
            answer = abs(a1-a2);
        }
    }

cout << answer << endl;
}