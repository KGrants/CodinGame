import sys
import math

_sum = int(input())
difference = int(input())
c = max(abs(_sum),abs(difference))

for i in range(-c,c):
    for j in range(-c,c):
        if i+j == _sum and i-j == difference:
            print(i if i<j else j)
            print(i if i>=j else j)

