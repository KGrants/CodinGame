import sys
import math

m = input()
if len(m)%2 == 0:
    print("Error")
else:
    for i in range(len(m)):
        if i < len(m)/2:
            print(str(" "*i)+m[i:len(m)-i]+str(""*i))
        else:
            print(str(" "*(len(m)-i-1))+m[(len(m)-i-1):len(m)-(len(m)-i-1)]+str(""*(len(m)-i-1)))