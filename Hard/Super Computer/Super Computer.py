needs = []
n = int(input())
for i in range(n):
    start, dur = [int(j) for j in input().split()]
    end = start + dur - 1
    needs.append((start,end))

needs.sort(key=lambda x: x[1])
calendar = 1 
occ_index = 0

for i in range(1,n):
    free_date = needs[occ_index][1]
    start = needs[i][0]
    if start > free_date:
        calendar +=1
        occ_index = i

print(calendar)
