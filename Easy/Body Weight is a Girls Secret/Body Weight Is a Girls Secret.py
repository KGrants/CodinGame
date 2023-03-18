weights = []
answer = []
for i in input().split():
    weights.append(int(i))

c = sum(weights)//4 - weights[0] - weights[-1]

answer.append(c)
answer.append(weights[8] - c)
answer.append(weights[9]-(weights[8] - c))
answer.append(weights[1] - c)
answer.append(weights[0]-(weights[1] - c))
answer.sort()

print(*answer)