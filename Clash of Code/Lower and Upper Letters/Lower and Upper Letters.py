import sys
import math

answer = ""
s = input()
for i in range(len(s)):
    if len(s)%2 !=0:
        if i%2 !=0:
            answer += s[i].capitalize()
        else:
            answer += s[i].lower()
    else:
        if i%2 ==0:
            answer += s[i].capitalize()
        else:
            answer += s[i].lower()

print(answer)