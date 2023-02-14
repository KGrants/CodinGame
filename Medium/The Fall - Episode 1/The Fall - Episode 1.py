def make_turn(r, x, y, e):
    if r in (2, 6):
        if e == "LEFT": x += 1
        else          : x -= 1
    elif r == 4:
        if e == "TOP" : x -= 1
        else          : y += 1
    elif r == 5:
        if e == "TOP" : x += 1
        else          : y += 1
    elif r == 10      : x -= 1
    elif r == 11      : x += 1
    else              : y += 1
    print(f"{x} {y}")

w, h = [int(i) for i in input().split()]
arr = [[0 for x in range(w)] for y in range(h)] 
for i in range(h):
    inp = input().split(" ")
    for j in range(w):
        arr[i][j] = int(inp[j])
ex = int(input())  

while True:
    inputs = input().split()
    xi = int(inputs[0])
    yi = int(inputs[1])
    pos = inputs[2]
    make_turn(arr[yi][xi], xi, yi, pos)