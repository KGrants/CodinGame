import sys
import math

s = input()

for x in range(0, len(s), 2):
    print(int(s[x])*s[x+1], end='')
