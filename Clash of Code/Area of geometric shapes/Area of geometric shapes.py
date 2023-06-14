import math

n = int(input())
x=0
for i in range(n):
    inputs = input().split()
    shape_type = inputs[0]
    a = int(inputs[1])
    b = int(inputs[2])
    if shape_type =='R':
        x+=a*b
    else:
        x+=((math.pi)*a**2)

print(round(x,2))