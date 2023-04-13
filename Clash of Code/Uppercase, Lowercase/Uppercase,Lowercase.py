s = input()
res = ''
for l in range(len(s)):
    if l == 0:
        res += s[l].upper()
    elif s[l-1] == ' ':
        res += s[l].upper()
    else:
        res += s[l].lower()

print(res)