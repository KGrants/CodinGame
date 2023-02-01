import sys
import math

def calc_vol(size):
    return (4*math.pi*((size/2)**3))/3

def equal(v1, v2):
    return v1 - 0.001 <= v2 <= v1 + 0.001

orb_size_min, orb_size_max = [int(i) for i in input().split()]
g1, g2 = [int(i) for i in input().split()]
vol_sum = calc_vol(g1) + calc_vol(g2)

p1 = g1
p2 = g2
pdiff = calc_vol(g1) - calc_vol(g2)

for i in range(orb_size_min, orb_size_max + 1):
    v1 = calc_vol(i)

    for u in range(i, orb_size_max + 1):
        v2 = calc_vol(u)
        if equal(v1 + v2, vol_sum):
            if p1 == g1 or calc_vol(u) - calc_vol(i) > pdiff:
                p1 = i
                p2 = u
                pdiff = calc_vol(u) - calc_vol(i)
            break
        if v1 + v2 > vol_sum:
            break

if p1 == g1:
    print('VALID')
else:
    print(p1,p2)
