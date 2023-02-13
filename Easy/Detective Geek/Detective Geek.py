time = str(int(input().replace('#', '1').replace('*','0'), 2)).zfill(4)
time = time[0:2]+":"+time[2:]
address = input().split(" ")
months = ("jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec")
answer = ""

for i in range(len(address)):
    answer += chr(months.index(address[i][0:3])*12+months.index(address[i][3:]))

print(time)
print(answer)