## I'm not proud of this, it was fastest mode of clash of code

s = input()
a = 0
for i in s:
    if i == 'a':
        a+=1
    elif i == 'e':
        a+=2
    elif i == 'i':
        a+=3
    elif i == 'o':
        a+=4
    elif i == 'u':
        a+=5
    elif i == 'A':
        a+=2
    elif i == 'E':
        a+=4
    elif i == 'I':
        a+=6
    elif i == 'O':
        a+=8
    elif i == 'U':
        a+=10

print(a)
