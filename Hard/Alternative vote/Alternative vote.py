import math

candidate = {}
votes = []

c = int(input())
for i in range(1, c +1):
    candidate[i] = input()
v = int(input())
for i in range(v):
    votes.append([int(x) for x in input().split()])
    
while len(candidate) > 1:
    count_votes = [0] * (c+1)
    for i in votes:
        count_votes[i[0]] += 1

    min_votes = math.inf
    l_id = 0
    for i in candidate.keys():
        v = count_votes[i]
        if v < min_votes:
            min_votes = v
            l_id = i
    print(candidate[l_id])
    del candidate[l_id]

    for i in votes:
        i.remove(l_id)
    
    for i in range(0, c+1):
        count_votes[i] = 0

winner = list(candidate.keys())[0]
print(f"winner:{candidate.get(winner)}")