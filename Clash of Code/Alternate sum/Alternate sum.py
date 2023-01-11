n = int(input())
n_0 = int(input())
for i in range(1,n):
    n_i = int(input())
    if i%2:
        print(n_0+n_i)
    else:
        print(f"{n_0}{n_i}")
    n_0 = n_i