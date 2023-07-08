import sys
import math

num = int(input())
print(str(num == sum([int(x)**len(str(num)) for x in str(num)])).lower())
