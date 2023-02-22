width, height = [int(i) for i in input().split()]
count = int(input())
arr = []
for i in range(height):
    arr.append(input())

for i in range(count):
    for j in range(len(arr)):
        arr[j] = sorted(arr[j], reverse=True)
    arr = list(zip(*arr))

for i in arr:
    print(''.join(i))