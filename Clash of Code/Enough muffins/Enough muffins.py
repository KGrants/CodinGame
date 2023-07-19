n, m, r, t = [int(i) for i in input().split()]

m = m - int(r*t)

if n <= m:
    print("HAPPY")

else:
    print("NOT HAPPY")