from re import match

n = int(input())
a = [input() for i in range(n)]

m = int(input())
for i in range(m):
    s = input()
    for w in a:
        if match(s.replace('_', '.'), w):
            print(w)
            break

