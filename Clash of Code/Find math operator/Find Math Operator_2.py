import sys
import math

x = ""
p = input().split(" ")
if  int(p[0]) + int(p[2]) == int(p[4]):
    x += "+"
elif int(p[0]) - int(p[2]) == int(p[4]):
    x += "-"
elif (int(p[0])  * int(p[2])) == int(p[4]):
    x += "*"
elif int(p[0]) / int(p[2]) == int(p[4]):
    x += "/"

print(x)