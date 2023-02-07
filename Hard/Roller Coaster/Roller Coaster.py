l, c, n = [int(i) for i in input().split()]
groups = list(map(int, [input() for i in range(n)]))

earnings = {}
group_seq = {}

for i in range(n):
    next_in_line = i
    earnings[i] = 0

    while(True):
        ready_to_ride = groups[next_in_line]

        if earnings[i]+ready_to_ride>l:
            break
        
        earnings[i] += ready_to_ride

        next_in_line += 1
        
        if next_in_line == n:
            next_in_line = 0
        
        if next_in_line == i:
            break
        
    group_seq[i] = next_in_line

answer = 0
group = 0

for i in range(c):
    answer += earnings[group]
    group = group_seq[group]


print(answer)