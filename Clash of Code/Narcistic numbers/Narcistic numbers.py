import sys
import math

num = input()
a = 0 
for i in num:
    a+=int(i)**len(num)

if int(num) == a:
    print("true")
else:
    print("false")
