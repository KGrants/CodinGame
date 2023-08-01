n = int(input())
print(sum([int(''.join(sorted(str(i)))) for i in range(1,n+1)]))