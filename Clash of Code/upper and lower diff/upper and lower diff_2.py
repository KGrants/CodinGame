## This failed one test case 

s = input()
a = 0
b = 0
for i in s:
    if i.isalpha():
        if i.isupper():
            a+=1
        else:
            b+=1

print(b-a)