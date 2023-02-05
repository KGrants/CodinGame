import sys

n, m, c = [int(i) for i in input().split()]
a = [int(i) for i in input().split(" ")]
b = [False for i in range(n)]
click = [int(i)-1 for i in input().split(" ")]

sum = 0
maxsum = 0

for i in click:
    if b[i] == False:
        b[i] = True
        sum += a[i]
    else:
        b[i] = False
        sum -= a[i]
    if (sum>c):
        print("Fuse was blown.")
        sys.exit()
    if sum>maxsum:
        maxsum=sum
print("Fuse was not blown.")
print("Maximal consumed current was", maxsum, "A.")