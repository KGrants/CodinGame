import sys
import math

message = input()
a=""
for i in message:
    if i.islower():
        a+=i
        a+='-'
        break
for i in reversed(message):
    if i.islower():
        a+=i
        break    

print(a)