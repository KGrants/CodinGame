import sys
import math

n = int(input())
print(math.factorial(n) + sum(i for i in range(n+1)))