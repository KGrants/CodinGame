import sys
import math

n = int(input())
a = 1
b = 0
for i in range(1,n+1):
    b+=a
    a+=2

print(math.ceil(b/10))
