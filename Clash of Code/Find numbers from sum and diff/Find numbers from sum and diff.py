import sys
import math

s = int(input())
d = int(input())

y=int((s-d)/2)
x=s-y

print(min(x,y))
print(max(x,y))