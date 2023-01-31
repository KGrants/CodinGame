line_1 = input()
line_2 = input()
line_3 = input()

for i in range(int(len(line_1)/3)):
    l1 = line_1[i*3:(i*3)+3]
    l2 = line_2[i*3:(i*3)+3]
    l3 = line_3[i*3:(i*3)+3]

    if not l1.strip():
        if l2[1] == '_':
            print(4, end="")
        else:
            print(1, end="")
    elif l2[0] == ' ':
        if l2[1] == ' ':
            print(7, end="")
        elif l3[0] == ' ':
            print(3, end="")
        else:
            print(2, end="")

    elif l3[0] == ' ':
        if l2[2] == ' ':
            print(5, end="")
        else:
            print(9, end="")

    elif l2[1] == ' ':
        print(0, end="")
    elif l2[2] == ' ':
        print(6, end="")
    
    else:
        print(8,end="")

