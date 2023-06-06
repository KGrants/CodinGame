is_leap = input()
year_type = input()
y = 353
if(is_leap=="LEAP"):
    y += 29
if(year_type=="SERIAL"):
    y += 1
elif(year_type=="FULL"):
    y += 2
print(y)