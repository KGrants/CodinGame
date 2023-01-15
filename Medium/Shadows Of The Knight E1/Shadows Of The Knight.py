w, h = [int(i) for i in input().split()]
n = int(input())  # maximum number of turns before game over.
x, y = [int(i) for i in input().split()]
x1 = 0
y1 = 0
x2 = w - 1
y2 = h - 1


while True:
    b = input()  
    if b.__contains__("U"):
        y2 = y-1
    elif b.__contains__("D"):
        y1 = y+1

    if b.__contains__("L"):
        x2 = x-1
    elif b.__contains__("R"):
        x1 = x+1

    x = x1 + (x2 - x1)/2
    y = y1 + (y2 - y1)/2
    

    print(str(int(x)) + " " + str(int(y)))