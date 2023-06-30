n = int(input())
a = 0
for i in range(n+1):
    if i>0:
        a+=i
        a+=i**2
        a+=i**3
print(a)