import sys
import math

n = int(input())
for i in range(n):
    p, q = input().split()
    p = p.lower()
    q = q.lower()
    if len(p)==len(q) and sorted(p)==sorted(q):
        print("true")
    else:
        print("false")