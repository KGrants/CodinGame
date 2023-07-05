s = 0
for i in range(int(input())):
    n = int(input())
    s += n * 5 if n % 2 else n * 3
print(s)
