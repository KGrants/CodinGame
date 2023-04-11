#include <stdio.h>
#include <string.h>

int main()
{
    float X;
    scanf("%f", &X);

    if (X==0.0) {printf("0\n"); return 0;}
    if (X<250.0) {printf("%d\n", 5000+(int)(X*20.0+0.1)); return 0;}
    if (X<1250.0) {printf("%d\n", 10000+(int)((X-250)*10.0+0.1)); return 0;}
    if (X<5250.0) {printf("%d\n", 20000+(int)((X-1250)*5.0+0.1)); return 0;}
    
    printf("%d\n", 40000+(int)((X-5250)*10.0/3.0+0.1));

    return 0;
}