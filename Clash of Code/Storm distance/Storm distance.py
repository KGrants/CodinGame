#Not correct, 40% of tasts passed

nl, nt = [int(i) for i in input().split()]
a=[]
b=[]
for i in input().split():
    a.append(int(i))
for i in input().split():
    b.append(int(i))

for i in range(len(a)):
    c = ((b[i]-a[i])/1000)*340
    print(abs(int(c)))
    exit()