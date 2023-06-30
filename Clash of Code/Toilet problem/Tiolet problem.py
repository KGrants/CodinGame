import sys
import math

maxtime, speed = [int(i) for i in input().split()]
ntoilet = int(input())
a = 0
b = 9999
for i in range(ntoilet):
    _id, distance, occupationtime = [int(j) for j in input().split()]
    asd = distance/speed
    sdf = 0
    if asd > occupationtime:
        sdf = asd
    else:
        sdf = occupationtime
    if sdf < b:
        b = sdf
        a = _id

if b > maxtime:
    print("Ohh sh*t!")
else:
    print(a)
