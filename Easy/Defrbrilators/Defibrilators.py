import sys
import math

lon = float(input().replace(',','.'))
lat = float(input().replace(',','.'))
n = int(input())
closest = sys.float_info.max
answer = ""

for i in range(n):
    defib = input().split(';')
    x = (lon - float(defib[4].replace(',','.'))) * math.cos(lat+float(defib[5].replace(',', '.')))
    y = lat - float(defib[5].replace(',', '.'))
    dist = math.sqrt((x*x)+(y*y))*6371

    if dist < closest:
        closest = dist
        answer = defib[1]

print(answer)