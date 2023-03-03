import sys
import math

n = int(input())
for i in range(1,n+1):
    if i == 1:
        print("if n ==",str(i)+":")
        print("    print(\"n is 1\")")
        if n == 1:
            break
    else:
        print("elif n ==", str(i)+":")
        print("    print(\"n is", str(i)+"\")")
print("else:")
print("    print(\"number not found :(\")")