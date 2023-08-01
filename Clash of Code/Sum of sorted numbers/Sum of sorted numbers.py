n = int(input())
x=0
for i in range(n+1):
    c=""
    a = [int(x) for x in str(i)]
    a.sort()
    for n in a:
        c+=str(n)
    x+=int(c)

print(x)
