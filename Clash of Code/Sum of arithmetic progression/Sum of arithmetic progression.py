x=int(input())
y=int(input())-x
a=[]
for i in range(12):
    a.append(x)
    x+=y
print(sum(a))
