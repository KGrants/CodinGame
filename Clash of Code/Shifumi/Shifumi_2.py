f=["Scissors", "Hand", "Stone"]
g=["Stone", "Scissors", "Hand"]
o = input()
a=0
if(o not in f):
    print("Error")
while a < 3:
    if(o == f[a]):
        print(g[a])
    a+=1