i=input
n=int(i())
x=map(int, i().split())
y=sum(x)/n
print([y, int(y)][y%1==0])
