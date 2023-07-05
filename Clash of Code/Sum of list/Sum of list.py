a=[int(input()) for i in range(int(input()))]
print(sum([i*3 if i%2==0 else i*5 for i in a]))