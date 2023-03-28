#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <stdbool.h>

int main()
{
    char X[101];
    scanf("%s", X);

    int count[26] = {0};

    for (int i = 0; X[i] != '\0'; i++) {
        int index = X[i] - 'a';
        count[index]++;
        for (int j = 0; j < count[index]; j++) {
            printf("%c", X[i]);
        }
    }
    printf("\n");

    return 0;
}