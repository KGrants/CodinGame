import sys
import math

d = int(input())
if d%2 == 1 :
    print(int(round((d-32) * (5/9))))
else:
    print(int(round((9*d/5) + 32)))
