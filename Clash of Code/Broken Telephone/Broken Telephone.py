n = int(input())
for i in range(n):
    phrase = input().split()
    if len(phrase)%2==0:
        print(*[phrase[i] for i in range(int(len(phrase)/2))])
    else:
        print(phrase[0],phrase[len(phrase)//2],phrase[len(phrase)-1])