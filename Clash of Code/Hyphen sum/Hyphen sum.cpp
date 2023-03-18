#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <cstring>

using namespace std;


int main()
{
    string l;
    getline(cin, l);

    int length = l.length();
    char* char_array = new char[length + 1];
    strcpy(char_array, l.c_str());
 
    int answer = 0;
    for (int i = 0; i < length; i++)
    {
        if (char_array[i] == '+')
        {
            answer+=4;
        }
        if (char_array[i] == '-')
        {
            answer+=1;
        }
        if (char_array[i] == '*')
        {
            answer+=5;
        }
        if (char_array[i] == '/')
        {
            answer+=2;
        }
    }

    cout << answer/4 << endl;
}