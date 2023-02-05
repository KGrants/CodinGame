#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

class Appliance
{   
    public:
        int power;
        bool turned_on_ind;
        Appliance()
        {

        }
        Appliance(int pow, bool turned_on)
        {
            this->power = pow;
            this->turned_on_ind = turned_on;
        }
};

int main()
{
    int n;
    int m;
    int c;
    int power = 0;
    int max_power = 0;
    cin >> n >> m >> c; cin.ignore();
    
    Appliance* arr = new Appliance[n];
    for (int i = 0; i < n; i++) {
        int nx;
        cin >> nx; cin.ignore();
        arr[i] = Appliance(nx,false);
    }

    for (int i = 0; i < m; i++) {
        int mx;
        cin >> mx; cin.ignore();
        mx = mx-1;
        Appliance x = arr[mx];
        power += x.turned_on_ind == false ? x.power : -x.power;
        arr[mx].turned_on_ind = x.turned_on_ind == false ? true : false;
        max_power = power > max_power ? power : max_power;
        if (max_power > c)
        {
            cout << "Fuse was blown." << endl;
            exit(0);
        }
    }


    cout << "Fuse was not blown." << endl;
    cout << "Maximal consumed current was " << max_power << " A." << endl;
}