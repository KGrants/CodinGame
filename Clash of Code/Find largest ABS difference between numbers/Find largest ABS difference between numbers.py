import sys
import math

n = int(input())
arr = list(map(int, input().split()))

max_diff = 0
for i in range(1, n):
    diff = abs(arr[i] - arr[i-1])
    max_diff = max(max_diff, diff)

print(max_diff)