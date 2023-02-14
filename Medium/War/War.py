import sys

def compare(a, b):
    aa, bb = 0, 0
    if   a[0] == '1': aa = int(10)
    elif a[0] == 'J': aa = int(11)
    elif a[0] == 'Q': aa = int(12)
    elif a[0] == 'K': aa = int(13)
    elif a[0] == 'A': aa = int(14)
    else:             aa = int(a[0])

    if   b[0] == '1': bb = int(10)
    elif b[0] == 'J': bb = int(11)
    elif b[0] == 'Q': bb = int(12)
    elif b[0] == 'K': bb = int(13)
    elif b[0] == 'A': bb = int(14)
    else:             bb = int(b[0])

    if   (aa>bb): return 1
    elif (aa<bb): return 2
    else:         return 3

n = int(input())  # the number of cards for player 1
player_one = []
for i in range(n):
    player_one.append(input())  # the n cards of player 1
m = int(input())  # the number of cards for player 2
player_two = []
for i in range(m):
    player_two.append(input())  # the m cards of player 2

counter = 0
c1 = []
c2 = []

while True:
    a = str(player_one.pop(0))
    b = str(player_two.pop(0))
    c1.append(a)
    c2.append(b)
    counter+=1
    round_winner = compare(a,b)

    if round_winner == 3:
        while True:
            if len(player_one)<4 or len(player_two)<4:
                print("PAT")
                exit()
            for i in range(3):
                c1.append(player_one.pop(0))
                c2.append(player_two.pop(0))

            a = str(player_one.pop(0))
            b = str(player_two.pop(0))
            c1.append(a)
            c2.append(b)
            round_winner = compare(a,b)
            if round_winner != 3:
                break

    cc = len(c1)
    if round_winner == 1:
        for i in range(cc):
            player_one.append(c1.pop(0))
        for i in range(cc):
            player_one.append(c2.pop(0))
    elif round_winner == 2:
        for i in range(cc):
            player_two.append(c1.pop(0))
        for i in range(cc):
            player_two.append(c2.pop(0))
    if len(player_one) < 1 or len(player_two) < 1:
        h = 1 if len(player_two) < 1 else 2
        print(h,counter)
        break