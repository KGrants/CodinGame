m, s = map(int, input().split())
n = int(input())
b = -1
t = float('inf')

for _ in range(n):
    i, d, o = map(int, input().split())
    tr = d / s
    tt = max(tr, o)

    if tt <= m and tt < t:
        b = i
        t = tt

if b == -1:
    print("Ohh sh*t!")
else:
    print(b)
