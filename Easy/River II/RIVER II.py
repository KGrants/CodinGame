import sys
import math

def getnextnumber(i):
    result = i
    while i > 0:
        result += i % 10
        i -= i % 10
        i /= 10
    return result

r_1 = int(input())
for i in range(r_1,0,-1):
    check = getnextnumber(i)
    if (check == r_1):
        print("YES")
        break
    elif (i == 1):
        print("NO")