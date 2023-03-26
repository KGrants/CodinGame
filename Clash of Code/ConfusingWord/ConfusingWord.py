confusing_word = input()
print(''.join([i for i in confusing_word if confusing_word.count(i)==1]))