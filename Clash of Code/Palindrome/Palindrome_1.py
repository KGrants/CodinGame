n = int(input())
for i in range(n):
    w = input()
    print('true' if w==w[::-1] else 'false')