import sys
import math

n = int(input())
m = 0
a = 0
for i in input().split():
    tower = int(i)
    if tower > m:
        m = tower
        a += 1
print(a)