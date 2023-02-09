import math

cat_speed = int(input())
mouse_speed = 10.0
radius = 500.0
pi = math.pi
circumference = 2.0 * radius * pi
cat_speed = cat_speed / circumference
circumference = mouse_speed / cat_speed
radius_mouse = circumference / 2.0 / pi
ratio = (radius_mouse - 5.0) / radius
escaping = False
dist_to_escape = 0.0

while True:
    mouse_x, mouse_y, cat_x, cat_y = [int(i) for i in input().split()]
    point_x = math.floor((-cat_x * ratio))
    point_y = math.floor((-cat_y * ratio))

    if escaping:
        print(math.ceil(mouse_x * 2.0), math.ceil(mouse_y * 2.0))
    else:
        print(point_x, point_y)
    
    dist_to_escape = math.sqrt((point_x - mouse_x)**2 + (point_y - mouse_y)**2)
            
    if ratio < 0.5:
        if dist_to_escape < 10.0:
            escaping = True
    else:
        if dist_to_escape < 80.0:
            escaping = True



