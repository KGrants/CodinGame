import sys
import math

n=int(input())
x=int(input())
c=0
for i in range(1,n+1):
    if i > x:break
    for j in range(1,n+1):
        if j > x: break
        if i*j == x:c+=1

print(c)