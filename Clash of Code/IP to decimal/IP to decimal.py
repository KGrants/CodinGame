import sys
import math


w,x,y,z = input().split('.')
w = int(w)
x = int(x)
y = int(y)
z = int(z)

print(16777216*w + 65536*x + 256*y + z)
