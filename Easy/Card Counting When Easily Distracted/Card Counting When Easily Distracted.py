cards = ('A','2','3','4','5','6','7','8','9','T','J','Q','K')
stream_of_consciousness = input().split(".")
cardsonly = ""
for i in stream_of_consciousness:
    if all(c in cards for c in i):
        cardsonly += i

belowbust = 0
abovebust = 0

bust_threshold = input()
if bust_threshold == "10":
    bust_threshold = "T"; 

for char in cards:
    if cardsonly.count(char)<4 and cards.index(char)<cards.index(bust_threshold):
        belowbust += 4-cardsonly.count(char)
    if cardsonly.count(char)<4 and cards.index(char)>=cards.index(bust_threshold):
        abovebust += 4-cardsonly.count(char)

print("%.0f%%" % (belowbust/(belowbust+abovebust)*100))