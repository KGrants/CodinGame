n = int(input())

for i in range(n):
    a = True
    w = input()
    for i in range(len(w)-1):
        if w[i] != w[-(i+1)]:
            print("false")
            a = False
            break
    if a:
        print("true")
