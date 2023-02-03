n = int(input())
a = list(map(int,input().strip().split()))[:n]
totalcost = 0
        
while len(a) > 1:
    a.sort()
    sum = a[0] + a[1]
    totalcost += sum
    del a[0]
    del a[0]
    a.append(sum)

print(totalcost)