def nextletter(a):
    if a[1] == 'Z':
        if a[0] == 'Z':
            return "AA"
        else:
            return chr(ord(a[0])+1)+'A'
    else:
        return a[0]+chr(ord(a[1])+1)

x = input().split('-')
n = int(input())

if int(x[1])+n>999:
    for i in range(int((int(x[1])+n)/999)):
        if x[2] == "ZZ":
            x[0] = nextletter(x[0])
        x[2] = nextletter(x[2])
    x[1] = str((int(x[1])+n)%999).zfill(3)
else:
    x[1]=str((int(x[1])+n)).zfill(3)

print('-'.join(x))