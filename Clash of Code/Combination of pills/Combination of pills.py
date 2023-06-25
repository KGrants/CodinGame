import sys
import math

d, a, b = [int(i) for i in input().split()]

qa=d//a
qb= 1 if qa*a+b<=d else 0

q = [qa*a+b*qb]
while qa*a+qb*b!=d and qa>0:
    qa -= 1
    qb = (d-qa*a)//b
    q += [qa*a+qb*b]

print(max(q))

