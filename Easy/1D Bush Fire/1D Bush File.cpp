#include <iostream>

using namespace std;

int main()
{
    int n;
    cin >> n; cin.ignore();
    for (int i = 0; i < n; i++) {
        int answer = 0;
        string line;
        getline(cin, line);
        for (int u = 0; u < line.length(); u++)
        {
            if (line[u] == 'f')
            {
                answer+=1;
                u+=2;
            }
        }
        cout<<answer<<endl;
    }
}