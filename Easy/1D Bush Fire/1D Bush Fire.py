n = int(input())
for i in range(n):
    answer = 0
    u = 0
    line = input()
    while u < len(line):
        if line[u] == 'f':
            answer+=1
            u+=2
        u+=1
    print(answer)
exit(0)
