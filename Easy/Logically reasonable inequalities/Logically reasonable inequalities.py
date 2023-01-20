a = []
n = int(input())
for i in range(n):
    r = input().split(" > ")
    if (r[0] not in a):
        a.append(r[0])
    if (r[1] not in a):
        a.append(r[1])
    if a.index(r[0])>a.index(r[1]):
        print("contradiction")
        exit()
print("consistent")