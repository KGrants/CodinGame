import sys
import math

n = int(input())
for i in range(n):
    a, b = [int(j) for j in input().split()]

    if a**2+b**2>(a+b)**2:
        print(">")
    elif a**2+b**2==(a+b)**2:
        print("=")
    else:
        print("<")