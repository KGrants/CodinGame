n = int(input())
for i in range(n):
    string = input()
    str1, str2 = string.split(" ")

    str1 = str1.lower()
    str2 = str2.lower()

    if(len(str1) == len(str2)):
        sorted_str1 = sorted(str1)
        sorted_str2 = sorted(str2)  
        if(sorted_str1 == sorted_str2):
            print("true")
        else:
            print("false")
    else:
        print("false")