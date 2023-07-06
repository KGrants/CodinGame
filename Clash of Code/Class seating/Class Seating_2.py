l=[]
for i in range(10):
 r=input().split()
 l+=[[sum(map(float,r[1:])),i,r[0]]]
for i in sorted(l):print(i[2])