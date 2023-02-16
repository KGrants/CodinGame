import math

def dist(x,y):
    return math.dist([x[0], x[1]], [y[0], y[1]])
    
total_dist = 0
min = 9999
city = -1
arr = [] 

n = int(input())
for i in range(n):
    arr.append(tuple(map(int, input().split())))

start = finish = arr[0]
city = -1
del arr[0]

while len(arr)>0:
    min = 9999
    for i in range(len(arr)):
        if dist(start,arr[i]) < min:
            min = dist(start,arr[i])
            city = i
    total_dist += min
    start = arr[city]
    del arr[city]

print(round(total_dist + dist(start,finish)))