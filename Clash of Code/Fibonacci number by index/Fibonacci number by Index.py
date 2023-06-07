input()
for i in input().split():
    u=int(i)
    n1,n2=0,1
    x=1
    v=0
    if u==0:print(0)
    elif u==1:print(1)
    else:
        while x<u:
            v=n1+n2
            n1=n2
            n2=v
            x+=1
        print(v)