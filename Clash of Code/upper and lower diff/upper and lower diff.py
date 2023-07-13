import sys
import math

s = input()
print(abs(sum(1 for i in s if i in "QWERTYUIOPASDFGHJKLZXCVBNM")-sum(1 for i in s if i in "qwertyuiopasdfghjklzxcvbnm")))