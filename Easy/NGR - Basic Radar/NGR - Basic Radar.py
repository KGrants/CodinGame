n = int(input())
start = {}
answer = []
for i in range(n):
    inputs = input().split()
    plate = inputs[0]
    radarname = inputs[1]
    timestamp = int(inputs[2])
    if radarname == "A21-42":
        start[plate] = timestamp
    else:
        if (timestamp-start[plate])/(3.6e+6)<0.099236641:
            answer.append(str(plate+" "+str(int(13/((timestamp-start[plate])/(3.6e+6))))))

answer.sort()
for i in answer:
    print(i)