n = int(input())
canon = (0,0)
aircraft = []
lst = [0] * 100

for i in range(n):
    for j, ch in enumerate(input()):
        if ch in '<>':
            aircraft.append((i, j))
        if ch == '^':
            canon = (n,j)

for i in aircraft:
    shot = abs(canon[1]-i[1]) - abs(canon[0]-i[0])
    lst[shot] = 1

o = 0
for i in lst:
    if i == 1:
        print("SHOOT")
        o += 1
    else:
        print("WAIT")
    if o == len(aircraft):
        break
    
# Write an answer using print
# To debug: print("Debug messages...", file=sys.stderr, flush=True)
