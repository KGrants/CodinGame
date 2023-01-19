import sys
import math

s = input().lower()
n = int(input())
for i in range(n):
    c = input()
    if c in s:
        print(str(math.ceil(s.count(c)*100/len(s)))+"%")
    else:print("0%")
