n = int(input())
data = list(map(int, input().split()))
size = max(data)

o = 0
acc = 0
for i in data:
    if (acc + i) > size:
        acc = 0
        o += size
    acc += i
    
if acc:
    o += size


print(o)