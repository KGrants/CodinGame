a = 0
n = int(input())
for i in range(n):
    inputs = input().split()
    h = int(inputs[0])
    l = float(inputs[1])
    f = l * 0.6
    while f < l:
        a += h
        l -= 1

print(a)
