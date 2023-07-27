x=int(input())*60
k=input().lower()
l=int(input())
for i in range(l):
    t=input().split(', ')
    if k not in t[0].lower():
        x-=int(t[1])
print(x if x>0 else"Long Enough")
