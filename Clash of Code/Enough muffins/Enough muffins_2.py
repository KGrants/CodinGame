n, m, r, t = [int(i) for i in input().split()]
print("HAPPY" if n <= m - t*r else "NOT HAPPY")