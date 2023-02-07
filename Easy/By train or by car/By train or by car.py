start, stop = input().split(" ")
n = int(input())
d = {}
car = 0.0
train = 57.0
for i in range(n):
    dep,arr,dist = input().split()
    d[dep] = (arr, float(dist))

while start != stop:
    start,distance = d[start]
    train += min(distance,6)*60/50 + max(0,distance-6)*60/284 + 8
    car += min(distance,14)*60/50 + max(0, distance-14)*60/105
    
hour = min(train,car)//60
minutes = min(train,car)%60//1
print("TRAIN" if train<car else "CAR",str("%d:%02d" % (hour, minutes)))