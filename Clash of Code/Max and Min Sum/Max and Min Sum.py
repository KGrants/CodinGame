import sys
import math

n = int(input())
arr = [int(x) for x in input().split()]

print(sum(arr)-max(arr),sum(arr)-min(arr))
