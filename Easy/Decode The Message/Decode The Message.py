p = int(input())
c = input()
answer = ""

while p >=0:
    answer += c[int(p%len(c))]
    p = p/len(c)-1

print(answer)