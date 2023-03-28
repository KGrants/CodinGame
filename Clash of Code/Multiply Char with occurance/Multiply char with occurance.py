import sys
import math

x = input()
f = ""
for i in range(len(x)):
    f += x[i]*x[0:i+1].count(x[i])

print(f)