import math

def dist(x,y):
    return math.dist([x[0], x[1]], [y[0], y[1]])

n = int(input())
total_dist = 0
min = 9999
city = -1
arr = [] 
answer = []

for i in range(n):
    arr.append(tuple(map(int, input().split())))

ans = arr.copy()
start = finish = arr[0]
city = -1
answer.append(0)
del arr[0]

while len(arr)>0:
    min = 9999
    for i in range(len(arr)):
        if dist(start,arr[i]) < min:
            min = dist(start,arr[i])
            city = i
    total_dist += min
    start = arr[city]
    answer.append(ans.index(arr[city]))
    del arr[city]

answer.append(0)
print(*answer)