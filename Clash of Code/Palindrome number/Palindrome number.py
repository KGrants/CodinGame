n = int(input())
a = str(bin(n))[2:]

if a != a[::-1]:
    print("no")
else:
    if len(a)%2 == 0:
        print("YES")
    else:
        print("yes")
