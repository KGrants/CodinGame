import sys
import math

n,*l=map(int,open(0))

l=[i for i in l if (i**.5).is_integer()]
if l:
    print(int(min(l)**.5))
else:
    print(0)