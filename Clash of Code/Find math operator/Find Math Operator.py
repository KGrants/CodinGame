problem = input().split(" = ")
a = int(problem[0].split(" ? ")[0])
b = int(problem[0].split(" ? ")[1])
c = int(problem[1])
if a * b == c:
    print("*")
elif a + b == c:
    print("+")
elif a - b == c:
    print("-")
else:
    print("/")