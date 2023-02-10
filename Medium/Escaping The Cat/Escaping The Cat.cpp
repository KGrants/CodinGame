#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <math.h>

using namespace std;

int main()
{
    int catSpeed;
    cin >> catSpeed; cin.ignore();
    double mouse_speed = 10.0;
    double radius = 500.0;
    double circumference = 2.0 * radius * M_PI;
    double cat_speed = catSpeed / circumference;
    circumference = mouse_speed / cat_speed;
    double radius_mouse = circumference / 2.0 / M_PI;
    double ratio = (radius_mouse - 5.0) / radius;
    bool escaping = false;
    double dist_to_escape = 0.0;

    while (1) {
        int mouse_x;
        int mouse_y;
        int cat_x;
        int cat_y;
        cin >> mouse_x >> mouse_y >> cat_x >> cat_y; cin.ignore();
        double point_x = floor((-cat_x * ratio));
        double point_y = floor((-cat_y * ratio));

        if (escaping)
            cout << (int)ceil(mouse_x * 2.0) << " " << (int)ceil(mouse_y * 2.0) << " Escape the cat" << endl;
        else
            cout << point_x << " " << point_y << " Wait for the moment" << endl;

        dist_to_escape = sqrt(pow((point_x - mouse_x),2) + pow((point_y - mouse_y),2));
        
        if (ratio < 0.5)
        {
            if (dist_to_escape < 10.0)
                escaping = true;
        }
        else
        {
            if (dist_to_escape < 80.0)
                escaping = true;
        }
    }
}