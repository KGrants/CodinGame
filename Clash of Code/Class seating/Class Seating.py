import statistics as s
a=[]
for i in range(10):
    r=input().split(' ')
    a.append((r[0],s.mean([float(r[i])for i in range(1,4)])))
a.sort(key=lambda x:x[1])
for i in a:
    print(i[0])