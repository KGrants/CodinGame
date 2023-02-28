import sys
import math
n = str(input())
print(sum([int(i) for i in n[0:len(n):2]])-sum([int(i) for i in n[1:len(n):2]]))