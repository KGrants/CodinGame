u = "no delivery"
a,g,b,m = [int(input())for _ in range(4)]
if a+g>b:print(u if m<b else "B")
else:print(u if m<a+g else "A")