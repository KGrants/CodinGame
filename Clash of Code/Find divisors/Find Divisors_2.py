n = int(input())
k = n
t=[]
while n > 0:
    if k%n==0:
        t.append(str(n))
    n-=1

print(" ".join(t))