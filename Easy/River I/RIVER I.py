import sys
import math

def getnextnumber(i):
    result = 0
    for element in str(i):
        result += int(element)
    return result

r_1 = int(input())
r_2 = int(input())

while r_1 != r_2:
    if(r_1>r_2):
        r_2 += getnextnumber(r_2)
    elif(r_1<r_2):    
        r_1 += getnextnumber(r_1)

print(r_1)