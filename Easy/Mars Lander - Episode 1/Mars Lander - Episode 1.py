import sys

surfaceN = int(input())

for i in range(surfaceN):
    input()
        
while True:
    vSpeed = int(input().split(' ')[3])

    if vSpeed <= -40:
        print("0 4")
    else:
        print("0 0")