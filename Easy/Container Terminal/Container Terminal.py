stacks = []
n = int(input())
for i in range(n):
    stacks.clear()
    line = input()
    stacks.append(line[0])

    for u in range(1, len(line)):
        for l in range (len(stacks)):
            if (line[u]<=stacks[l]):
                stacks[l] = line[u]
                break
            if line[u]>stacks[l] and l == len(stacks)-1:
                stacks.append(line[u])
                break
    print(len(stacks))