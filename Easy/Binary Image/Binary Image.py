h = int(input())
lst = []

for i in range(h):
    answer = ""
    row = input()
    for i in range(len(row.split())):
        if int(i)%2==0:
            answer += '.'*int(row.split()[int(i)])
        else:
            answer += 'O'*int(row.split()[int(i)])      
    lst.append(answer)

check = len(lst[0])
for i in lst:
    if len(i) != check:
        print("INVALID")
        quit()

for i in lst:
    print(i)