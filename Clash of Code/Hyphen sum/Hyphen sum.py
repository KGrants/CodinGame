import sys
import math

l = input()

res=l.count('+')*4+l.count('-')+l.count('*')*5+l.count('/')*2
res=res//4
print(res)
