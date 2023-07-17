n = [int(i) for i in input()]

prod = 1
for x in n:
    prod*=x

print(prod - sum(n))
