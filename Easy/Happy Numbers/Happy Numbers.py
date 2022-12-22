import sys
import math

n = int(input())
for i in range(n):
    ## Catch input in two variables, one will be used for printing answer, other will be manipulated.
    answer = x = input() 
    ## Empty list to store all numbers that has been used(to get out of infinite loop)
    existed = []

    ## This will be run till x - 0 or till number exists in existed list
    while x!="1":
        tempsum = 0        
        ## This will parse string to chars and each char to int in list
        intlist = list(map(lambda num: int(num),x))

        ## Calculate and add to sum each number power of two
        for numb in intlist:
            tempsum += numb*numb

        ## For loop to continue change x to newly created number
        x = str(tempsum)

        ## Check and add number to existed list to check later (or break loop)
        if (tempsum in existed):
            break
        existed.append(tempsum)

    ## Display results
    if (x == "1"):
        print(answer + " :)")
    else: 
        print(answer + " :(")