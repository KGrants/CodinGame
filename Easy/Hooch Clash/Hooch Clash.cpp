#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

using namespace std;

double calc(int a)
{
    return 4*(atan(1)*4*(pow(((double)a/2),3)))/3;
}

bool compare(double v1, double v2)
{
    if (v1 - 0.001 <= v2 && v2 <= v1 + 0.001)
        return true;
    else
        return false;       
}

int main()
{
    int orb_size_min;
    int orb_size_max;
    cin >> orb_size_min >> orb_size_max; cin.ignore();
    int g1;
    int g2;
    cin >> g1 >> g2; cin.ignore();
    double gsum = calc(g1) + calc(g2);

    int p1 = g1;
    int p2 = g2;
    double pdiff = calc(g1) - calc(g2);

    for (int i = orb_size_min; i <= orb_size_max; i++)
    {
        double v1 = calc(i);
        for (int u = i; u <= orb_size_max; u++)
        {
            double v2 = calc(u);
            if (compare(v1 + v2, gsum))
            {
                if (p1 == g1 || calc(u) - calc(i) > pdiff)
                {
                    p1 = i;
                    p2 = u;
                    pdiff = calc(u) - calc(i);
                }
                break;
            }
            if (v1 + v2 > gsum)
                break;
        }
    }

    if (p1 == g1)
        cout << "VALID" << endl;
    else
        cout <<p1 << " " << p2 << endl;
}