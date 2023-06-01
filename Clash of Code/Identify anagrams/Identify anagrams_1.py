import sys
import math

n = int(input())
for i in range(n):
    p, q = input().upper().split()

    str1_list = list(p)
    str1_list.sort()
    str2_list = list(q)
    str2_list.sort()
    if str1_list == str2_list:
        print("true")
    else:
        print("false")