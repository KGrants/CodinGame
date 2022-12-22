import sys
import math

def calculatescore(a):
    scores = []
    for i in a:
        if (i.isdigit()==False):
            if (i == "A"):
                scores.append(11)
            else:
                scores.append(10)
        else:
            scores.append(int(i))

    while sum(scores) > 21 and scores.count(11)>0:
        scores[scores.index(11)] = 1

    return sum(scores)

bank_cards = input().split(' ')
player_cards = input().split(' ')

bankresult = calculatescore(bank_cards)
playerresult = calculatescore(player_cards)

if len(player_cards) == 2 and playerresult == 21 and bankresult ==21 and len(bank_cards) == 2:
    print("Draw")
elif len(player_cards) == 2 and playerresult ==21:
    print("Blackjack!")
elif playerresult>21:
    print("Bank")
elif (bankresult>21):
    print("Player")
elif bankresult<playerresult:
    print("Player")
elif bankresult>playerresult:
    print("Bank")
else:
    print("Draw")