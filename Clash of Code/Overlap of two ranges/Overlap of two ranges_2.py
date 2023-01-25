a,b=map(int,input().split())
c,d=map(int,input().split())
print(['O','Not o'][a>d or b<c]+'verlap')