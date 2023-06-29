c=0
t=0
for i in range(int(input())):
    lst = [int(s) for s in input().split()]
    t+=lst.count(c)
    c+=1
print(t)