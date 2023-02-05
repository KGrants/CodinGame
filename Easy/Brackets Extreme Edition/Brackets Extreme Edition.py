import sys
import math
import re


e = input()
open = ['(', '{', '[']
close = [')', '}', ']']
a = []
for i in e:
    if i in open:
        a.append(i)
    elif i in close:
        if len(a)>0:
            b = a.pop()
            if close.index(i) == open.index(b):
                continue
            else:
                print("false")
                sys.exit()
        else:
            print("false")
            sys.exit()

if len(a)>0:
    print("false")
else:
    print("true")