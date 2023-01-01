import sys
import math

move = {
            'R': (4,0,3,5,1,2),
            'L': (4,5,1,0,3,2),
            'U': (4,1,0,3,5,2),
            'D': (4,3,5,1,0,2),
        }

dice = ""

for i in range(3):
    dice += input().strip() 

commands = input()  

for i in range(len(commands)):
    temp = dice
    dice = ""
    for u in range(len(temp)):
        dice += temp[move[commands[i]][u]]

print(dice[2])