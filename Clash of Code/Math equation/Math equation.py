import sys
import math

inputs = input().split()
o = inputs[0]
x = int(inputs[1])
n = int(inputs[2])

a = ""
c = 0

for i in range(x):
    a+=str(n)[i]
if len(a) == 0:
    a+="0"

a+=" "+o+" "

for i in range(x,len(str(n))):
    a+=str(n)[i]

b = a.split(" ")

if b[1] == "+":
    c = int(b[0])+int(b[2])
elif b[1] == "-":
    c = int(b[0])-int(b[2])
elif b[1] == "*":
    c = int(b[0])*int(b[2])
elif b[1] == "/":
    c = int(b[0])/int(b[2])

print(int(c))
