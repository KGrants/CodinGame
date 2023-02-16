a, b, c, d = [int(i) for i in input().split()]
x = a - c
y = b - d

while True:
    r = int(input())
    m = ""
    if (y<0): m += 'N';y+=1
    if (y>0): m += 'S';y-=1
    if (x<0): m += 'W';x+=1
    if (x>0): m += 'E';x-=1
    print(m)