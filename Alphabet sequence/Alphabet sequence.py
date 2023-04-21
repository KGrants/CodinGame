import sys
import math

line = input()
start = ord(line[0].upper())
finish = abs(ord(line[2].upper()))

if start <= finish:
finish += 27
a = []

for i in range(start,finish):
    if i>90:
        a.append(chr(i-26).upper())
    else:
        a.append(chr(i).upper())

print(*a)

