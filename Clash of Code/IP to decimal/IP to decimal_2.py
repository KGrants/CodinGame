import sys
import math

ipv_4 = input()

bins = (f"{int(n):08b}" for n in ipv_4.split('.'))
print(int(''.join(bins), 2))