n=int(input())
m=int(input())
print([i for i in range(1,min(n,m)+1)if n%i==m%i==0][-2])