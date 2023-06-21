numb = []
lines = []
a = 0
for i in range(4):
    lines.append(input())
    for i in lines[-1]:
        if i.isnumeric():
            numb.append(i)
numb.sort()
a=0
for i in lines:
    line = ""
    for j in i:
        if j.isnumeric():
            line+=numb[a]
            a+=1
        else:
            line+=j
    print(line)

