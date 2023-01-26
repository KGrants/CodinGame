import sys
import math
import itertools

stuff = []
for i in range(5):
    stuff.append(int(input()))

for L in range(len(stuff) + 1):
    for subset in itertools.combinations(stuff, L):
        if len(subset) == 3:
            if sum(subset) == 0:
                for item in subset:
                    print(item)