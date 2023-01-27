num_dict = {}
next_num = int(input())
sequence = ''
n = int(input())

for i in range(n+1):
    if next_num in num_dict:
        distance = i - num_dict[next_num]
    else:
        distance = 0

    num_dict[next_num] = i
    sequence += "%d, " % next_num
    next_num = distance

newlist = sequence.split(", ")
print(newlist[n-1])