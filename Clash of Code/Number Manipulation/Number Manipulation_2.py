s=input().replace('8','')
u=0
a=""
while u < 10:
    a=""
    for i in range(len(s)):
        if s[i] == '9' and (s[i-1 if i>0 else i] == '7' or s[i+1 if i<len(s)-1 else i] =='7'):
            continue
        else:
            a+=s[i]
    s=a
    u+=1
print(a if len(a)>0 else "Nothing!")
