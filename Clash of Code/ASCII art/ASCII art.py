width = int(input())
height = int(input())
corner = input()
vertical_sides = input()
horizontal_sides = input()
composition = input()

for x in range(height):
    if x == 0 or x == height-1:
        print(corner + (width-2)*horizontal_sides + corner)
    else:
        print(vertical_sides + (width-2)*composition + vertical_sides)
