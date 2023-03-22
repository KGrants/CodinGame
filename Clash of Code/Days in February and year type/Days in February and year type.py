import sys
import math

year = int(input())
a = ""
if year%400==0:
    a = "L"
elif year%100==0:
    a = "H"
elif year%4==0:
    a = "F"
else:
    a = "N"

answer = ""
if a == "L" or a == "F":
    answer = "29"
else:
    answer = "28"


print(answer, a)