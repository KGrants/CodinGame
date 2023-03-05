import sys
import math

n = int(input())
c = 999
a=0
for i in range(n):
    lane = input().split('|')
    l = [x for x in lane if x != '']
    if len(l)<c:
        c = len(l)
        a = i

print(a+1)