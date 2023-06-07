input()
b=2<<99
for i in input().split():print(b**int(i)*b//(b*b-b-1)%b)