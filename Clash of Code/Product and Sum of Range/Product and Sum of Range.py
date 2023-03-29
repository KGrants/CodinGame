n = int(input())
a = 0
b = 1

for i in range (1,n+1):
    a += i
    b *= i

print(b)
print(a)