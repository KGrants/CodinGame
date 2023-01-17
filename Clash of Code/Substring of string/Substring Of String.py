import sys
import math

n = int(input())
text = input()
i = 0
for c in range(len(text) - n + 1 ):
    i = c
    for c2 in range(n):
        print(text[i],end = "")
        i+=1
    print()