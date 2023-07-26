health = int(input())
level = int(input())-1

x = health - (200+(20*level))

print(f"hehehehaw {x}" if x <= 0 else f"rawr {x}")
