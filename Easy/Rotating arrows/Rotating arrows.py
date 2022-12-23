import sys
import math

##Return new position based on input position and direction
def getnextpos(x, y, c):
    if c == '>'                 : return (x+1,y)
    elif c == '<'               : return (x-1,y)
    elif c == '^'               : return (x, y-1)
    else                        : return (x,y+1)

##Return new character that is rotated clockwise
def roratechar(a):
    direction = ['>','v','<','^']
    if direction.index(a)==3    :  return direction[0]
    else                        :  return direction[direction.index(a)+1]

##inputs and variables
w, h = [int(i) for i in input().split()]
x, y = [int(i) for i in input().split()]
grid = [list(input()) for i in range(h)]
counter = 0
start = (x, y)

##Loop till position is out of bounds of "2D array" or we are back at starting point
while w > x >= 0 and h > y >= 0:
    counter+=1
    grid[y][x] = roratechar(grid[y][x])
    x , y = getnextpos(x,y,grid[y][x])
    if (x,y) ==start: break

print(counter)