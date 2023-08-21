word = input()
print(sum([ord(c) for c in word if ord(c)%2==1]))