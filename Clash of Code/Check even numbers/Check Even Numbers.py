import sys
import math

count = int(input())
for i in input().split():
    n = int(i)
    if n%2!=0:
        print("[x]",n)
    else:
        print("[ ]",n)