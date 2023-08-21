word = input()
s=0
for x in word:
    if ord(x)%2:
        s+=ord(x)
print(s)