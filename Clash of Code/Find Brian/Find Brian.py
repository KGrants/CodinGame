import sys
import math

h = int(input())
w = int(input())
lastline=""
for i in range(h):
    a = input()
    for j in range(len(a)):
        if a[j]=="B":
            x=""
            if j>0 and a[j-1]!="*":
                x=a[j-1]
            elif j+1<len(a) and a[j+1]!="*":
                x=a[j+1]
            elif i>0 and lastline[j]!="*":
                x=lastline[j]
            else:
                a=input()
                x=a[j]
                i+=1
            if x=="K":
                print("BRIAN IS IN THE KITCHEN")
            elif x=="C":
                print("BRIAN IS IN THE CORRIDOR")
            elif x=="T":
                print("BRIAN IS IN THE BATHROOM")
            elif x=="L":
                print("BRIAN IS IN THE LIVING ROOM")
            elif x=="E":
                print("BRIAN IS IN THE BEDROOM")
            elif x=="S":
                print("BRIAN IS IN THE SWIMMING POOL")
            else:
                print("BRIAN IS NOWHERE")  
    lastline=a

