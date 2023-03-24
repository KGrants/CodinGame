a = {}

def influence(i):
    global a
    max = 0
    arr = a.get(i, [])
    if len(arr) == 0: return 0
    else:
        for b in arr:
            temp = influence(b)
            if max < temp:
                max = temp
    return max + 1

n = int(input())  
for i in range(n):
    x, y = [int(j) for j in input().split()]
    a.setdefault(x, []).append(y)

max = 0
for i in a:
    temp = influence(i)
    if max < temp:
        max = temp

print(max+1)