n = int(input())
a = 0
c = 0
for i in range(n):
    row = input().split(" ")
    for i in row:
        if int(i) == a:
            c += 1
    a+=1

print(c)
