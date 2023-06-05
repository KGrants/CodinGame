text = input()
a = ""
for i in text:
    if i.isupper():
        a+=i.lower()

print(a)