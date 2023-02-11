lu = int(input())
h = int(input())
tu = input()
t = [char for char in tu]
for i in range(h):
    row = input()
    answer = ""
    for l in range(len(t)):     
        if t[l].isalpha():
            Order = int(((ord(t[l].upper()) - 64)-1))
            answer += row[Order*lu:Order*lu+lu]
        else:
            answer +=row[len(row)-4:]
    print(answer)