def l(x,y,z):
 p("|"+c[x]+c[y]+c[z]+"|")
def f(x):
 l(x>1,0,x>3);l(x>5,x%2,x>5);l(x>3,0,x>1)
p=print
t,b=map(int,input().split())
s="+---+"
c=" *"
p(s)
f(t)
p(s)
f(b)
p(s)
