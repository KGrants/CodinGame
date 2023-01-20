import sys
import math

n = int(input())
k=1
for i in range(n):
    i, o = [int(j) for j in input().split()]
    k += i
    k -= o 

print(k)