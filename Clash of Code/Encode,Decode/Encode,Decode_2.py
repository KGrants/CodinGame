import sys
import math

m = input()
d = int(input())
k = int(input())%26

print(*[chr((ord(i)-ord('A')+d*k+26)%26+ord('A')) for i in m],sep='')