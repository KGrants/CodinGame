import sys
import math

x = int(input())
n = int(input())
weights = []
answer = 0
for i in input().split():
    weights.append(int(i))

weights.sort(reverse=True)

for i in range(0, len(weights)): 
        answer += (((int((i/x))+1)-1) * 6.5 / 100) * 10 * weights[i]

print(f'{answer:.3f}')