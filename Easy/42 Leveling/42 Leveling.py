import sys
from decimal import Decimal, getcontext

getcontext().prec = 6
level = Decimal(0)

N = int(input())
for i in range(N):
    #precise way
    score = float(input())
    level += Decimal(0.0075) * Decimal(score)

#truncate
num, dec = str(level).split('.')
level_str = num+'.'+str(dec).zfill(2)[:2]
print(level_str)