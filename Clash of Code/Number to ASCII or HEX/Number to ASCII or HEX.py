a = ""
n = [int(x) for x in input().split()]
for f in n:
    if 31 < f < 127:
        a+=(chr(f))
    else:
        a+="\\"+(hex(f)).upper()[2:]
print(a)