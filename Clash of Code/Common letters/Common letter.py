words = input().upper().split(' ')
a = 100

result = ''
for ch in words[0]:
   result = result + ch + ' '

for i in range(len(result)):
    if result[i] in words[1]:
        a = i
        break
if a == 100:
    print("NO COMMON CHARACTER")
    exit()

print(result.strip())
for i in words[1][1:]:
    print(' '*a+i)

