#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <stdbool.h>

int main()
{
    int N;
    scanf("%d", &N); fgetc(stdin);
    for (int i = 0; i < N; i++) 
    {
        int a = 0;
        char line[256];
        scanf("%[^\n]", line); fgetc(stdin);
        for (int j = 0; j < strlen(line); j++)
        {
            if (line[j]=='f')
            {
                a = a+1;
                j = j+2;
            }
        }
        printf("%d\n",a);
    }
    return 0;
}