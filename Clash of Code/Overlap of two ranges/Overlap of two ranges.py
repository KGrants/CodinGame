a1, b1=[int(i) for i in input().split()]
a2, b2=[int(i) for i in input().split()]
x = range(a1,b1+1)
y = range(a2,b2+1)
u = list(set(x)&set(y))
print("Overlap") if len(u) > 0 else print("Not overlap")