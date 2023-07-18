call_1, call_2 = input().split()
if call_1 == "ROCK" and call_2 =="SCISSORS":
    print("PLAYER1")
elif call_1 == "PAPER" and call_2 =="ROCK":
    print("PLAYER1")
elif call_1 == "SCISSORS" and call_2 =="PAPER":
    print("PLAYER1")
elif call_1 == "SCISSORS" and call_2 =="ROCK":
    print("PLAYER2")
elif call_1 == "PAPER" and call_2 =="SCISSORS":
    print("PLAYER2")
elif call_1 == "ROCK" and call_2 =="PAPER":
    print("PLAYER2")
else:
    print("DRAW")
