n = int(input())

s = 0
for i in range(n+1):
    s += i+i*i+i*i*i
print(s)