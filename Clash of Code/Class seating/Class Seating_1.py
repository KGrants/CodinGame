r=[]
for i in'.'*10:
 n=input().split()
 x=sum(map(float,n[1:]))
 r+=[(n[0],x)]
print(*[g[0]for g in sorted(r,key=lambda x:x[1])],sep='\n')