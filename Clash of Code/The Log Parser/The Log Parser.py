import sys
import math

k = ("FATAL","ERROR","WARNING","INFO","DEBUG")
l = int(input())
n = int(input())
for i in range(n):
    line = input()
    for i in range(l+1):
        if "> "+k[i] in line:
            print(line)