lst = []
result = 9999
n = int(input())
for i in range(n):
    lst.append(int(input()))

lst = sorted(lst)

for i in range(n-1):
    if abs(lst[i+1]-lst[i])<result:
        result = abs(lst[i+1]-lst[i])

print(result)