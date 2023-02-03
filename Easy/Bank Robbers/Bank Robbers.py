import sys
import math

r = int(input())
v = int(input())
sec = [0 for x in range(r)]

for i in range(v):
    c, n = [int(j) for j in input().split()]
    sec[0] += (int((math.pow(10, n) * math.pow(5, c - n))))
    sec.sort()

print(max(sec))