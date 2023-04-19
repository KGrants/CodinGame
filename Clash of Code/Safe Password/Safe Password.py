# It's not beautiful, but it will do for fastest mode clash of code.
s = input()
if len(s)>=8:
    if len([i for i in s if i.isupper()]) > 0:
        if len([i for i in s if i.islower()]) > 0:
            if len([i for i in s if i.isnumeric()]) > 0:
                print("true")
            else:
                print("false")
        else:
            print("false")
    else:
        print("false")
else:
    print("false")
