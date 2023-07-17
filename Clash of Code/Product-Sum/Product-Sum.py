n = input()
a = 1
for i in n:
    a *= int(i)

b = 0
for i in n:
    b += int(i)

print(a - b)
