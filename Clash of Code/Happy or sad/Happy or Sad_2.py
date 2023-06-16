emoticons = input().split()
score = 0
for i in emoticons:
    if i in ['=)', '^_^']:
        score += 1
    elif i in [':(', '>_<']:
        score -= 1
print(score)