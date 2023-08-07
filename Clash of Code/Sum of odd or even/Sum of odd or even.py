_type = input()
value = int(input())
a=0
if _type == 'even':
    for i in range(value+1):
        if i%2 == 0:
            a+=i
else:
    for i in range(value+1):
        if i%2 == 1:
            a+=i

print(a)