import sys
import math

n = int(input())
l=[int(i) for i in input().split()]
r=0
p=0
t=max(l)
for i in l:
    if p+i <= t:
        p+=i
    else :
        r+=1
        p=i
    if p==t:
        r+=1
        p=0
if p>0 :
    r+=1

print(r*t)