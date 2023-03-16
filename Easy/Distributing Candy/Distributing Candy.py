import sys

n, m = [int(i) for i in input().split()]
a = []
for i in input().split():
    a.append(int(i))
a.sort()

answer = sys.maxsize
for i in range(len(a)-(m-1)):
    if abs(a[i+(m-1)]-a[i])<answer:
        answer = abs(a[i+(m-1)]-a[i])

print(answer)