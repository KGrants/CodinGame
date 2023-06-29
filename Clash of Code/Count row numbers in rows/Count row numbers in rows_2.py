n = int(input())
s=0
for i in range(n):
    row = input()
    s+=row.count(str(i))
print(s)
