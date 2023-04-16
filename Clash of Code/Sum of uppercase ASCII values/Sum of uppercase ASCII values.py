import sys
import math

s = input()
a=0
for i in s:
    if i.isupper():
        a+=ord(i)
print(a)