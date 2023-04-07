import sys
import math

m = input()
d = int(input())
k = int(input())%26 ## to be able to handle "multiple circles"
answer = ""

for i in m:
    if (ord(i) + k > 90 and d>0) or (ord(i) - k < 65 and d<0) :
        b = ord(i) + k - 26 if d > 0 else ord(i) - k +26
    else:
        b = ord(i) + k if d > 0 else ord(i) - k
    answer += chr(b)

print(answer)