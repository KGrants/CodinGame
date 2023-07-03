import sys
import math

a = input()
b = input()
c = ""

for j in range(26):
    c = ""
    for i in a:
        if ord(i) + 1 > 90:
            c += chr(ord(i) + 1-26)
        else:
            c += chr(ord(i) + 1)

    if c == b:
        print("true")
        exit()
    a = c


print("false")
