import sys
import math

w = input()
a = 0
for i in w:  
    if ord(i)<a:
        print(i)
    a = ord(i)