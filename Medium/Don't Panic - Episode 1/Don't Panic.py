nb_floors, width, nb_rounds, exit_floor, exit_pos, nb_total_clones, nb_additional_elevators, nb_elevators = [int(i) for i in input().split()]
elev = {}
for i in range(nb_elevators):
    f, pos = [int(j) for j in input().split()]
    elev[f] = pos

while True:
    cf, pos, d = input().split()
    cf = int(cf)
    pos = int(pos)
    targ= elev.get(cf) if cf in elev else exit_pos
    if (d=="RIGHT" and targ<pos) or (d=="LEFT" and targ>pos):
        print("BLOCK")
    else: print("WAIT")