import sys
import math

n = int(input())
sum =0 
for i in range(2,n+1):
    if i%2 == 0:
        sum+=i
print(sum)
