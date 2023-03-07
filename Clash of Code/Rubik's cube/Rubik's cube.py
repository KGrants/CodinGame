import sys
import math

U = F = L = R = B = D = 0

for i in range(11):
    pattern = input()
    for i in pattern:
        if i == 'U':
            U+=1
        elif i == 'F':
            F += 1
        elif i == 'L':
            L += 1
        elif i == 'R':
            R += 1
        elif i == 'B':
            B += 1
        elif i == 'D':
            D += 1

if D!=9 or F!=9 or L!=9 or R!=9 or B!=9 or D!=9:
    print("UNSOLVABLE")
else:
    print("SOLVABLE")
