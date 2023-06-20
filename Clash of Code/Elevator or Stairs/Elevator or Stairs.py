import sys
import math

nb_person, max_person = [int(i) for i in input().split()]
floor = int(input())
for i in range(floor):
    person_out, person_in = [int(j) for j in input().split()]
    nb_person += person_in
    nb_person -= person_out

if nb_person >= max_person:
    print('STAIRS 0')
else:
    print(f"ELEVATOR {max_person - nb_person}")
