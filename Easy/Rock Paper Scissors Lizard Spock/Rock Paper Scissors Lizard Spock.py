import sys
import math

def battleresult(p1, p1m, p2, p2m):
    if p2m ==p1m:
        if p1<p2:
            return (p1,p2)
        else:
            return (p2,p1)

    if ((p1m == 'R' and (p2m == 'L' or p2m == 'C')) or
        (p1m == 'P' and (p2m == 'R' or p2m == 'S')) or
        (p1m == 'C' and (p2m == 'L' or p2m == 'P')) or
        (p1m == 'L' and (p2m == 'S' or p2m == 'P')) or
        (p1m == 'S' and (p2m == 'C' or p2m == 'R'))):
        return (p1,p2)
    else:
        return (p2,p1)             

n = int(input())
signs = {}
won = {}

for i in range(n):
    inputs = input().split()
    signs[int(inputs[0])] = inputs[1]

while len(signs)>1:
    for i in range(0, int(n/2)):  
        win, loose = battleresult(list(signs.items())[i][0],
                                  list(signs.items())[i][1],
                                  list(signs.items())[i+1][0],
                                  list(signs.items())[i+1][1])
                
        if win in won.keys():
            won[win] += " "+str(loose)
        else:
            won[win] = str(loose)

        del signs[loose]

    n/=2
 
print(list(signs.keys())[0])
print(won[list(signs.keys())[0]])