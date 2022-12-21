import sys
import math
import re

n = int(input())
limits = [0, 30.1, 17.6, 12.5, 9.7, 7.9, 6.7, 5.8, 5.1, 4.6]
acclist = []
answer = "false"

for i in range(n):
    acclist.append(input())
    
acclist = list(map(lambda x: int(re.search('[1-9]+', x).group()[:1]), acclist))

for x in range(1,10):
    if acclist.count(x)/len(acclist)*100<(limits[x]-10) or acclist.count(x)/len(acclist)*100>(limits[x]+10):
        answer = "true"

print(answer)