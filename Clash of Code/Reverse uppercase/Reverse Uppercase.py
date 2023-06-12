s = input()
r = ''
for i in s:
    if i.isupper():
        r += i
if len(r) == 0:
    print("...")
else:
    print(r[::-1])