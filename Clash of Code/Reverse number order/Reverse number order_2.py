l='-'.join([input()for _ in[0]*4])
a=sorted([e for e in l if e.isnumeric()])
k=0
for i in range(63):
 if l[i] in a:l=l[:i]+a[k]+l[i+1:];k+=1
print(*l.split('-'),sep='\n')