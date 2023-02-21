import sys
import math

a = int(input())
b = int(input())
c = int(input())
d = int(input())
saved = 0

for i in range(c):
    saved += d
    d += 1
    
v = a-saved-b
if v <= 0:
    print(0)
else:
    print(v)