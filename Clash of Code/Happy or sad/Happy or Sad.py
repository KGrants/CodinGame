import sys
import math

faces = input().split()
amt = 0
for face in faces:
    if face=="=)" or face=="^_^":amt+=1
    elif face==":(" or face==">_<":amt-=1

print(amt)