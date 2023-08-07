_type = input()
value = int(input())

if _type == "even":
    divnum = 0
else: divnum = 1
ans = 0
for i in range(value+1):
    if i % 2 == divnum:
        ans += i

print(ans)