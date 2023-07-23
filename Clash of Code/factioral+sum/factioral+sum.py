import sys
import math

n = int(input())
f = 1
s=  0
for i in range(1,n+1):
    f = f * i
for i in range(1,n+1):
    s = s + i

print(f+s)
