import sys
import math
import string
digs = string.digits + string.ascii_letters

def int2base(x, base):
    if x < 0:
        sign = -1
    elif x == 0:
        return digs[0]
    else:
        sign = 1

    x *= sign
    digits = []

    while x:
        digits.append(digs[int(x % base)])
        x = int(x / base)

    if sign < 0:
        digits.append('-')

    digits.reverse()

    return ''.join(digits)


def reverse_number(v):
    reversed_number = 0
    
    while v > 0:
        last_digit = v % 10
        reversed_number = reversed_number * 10 + last_digit
        v = v // 10

    return reversed_number

b = int(input())
n = int(input())

d = int2base(n, b)
k = reverse_number(int(d))



print(k)

## Need to convert back from base b to base 10

