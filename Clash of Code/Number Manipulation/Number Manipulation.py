o=input()
while 1:
  n=""
  for i in range(len(o)):
    if (o[i]=="9" and ((i<len(o)-1 and o[i+1]=="7") or (i>0 and o[i-1]=="7"))) or o[i]=="8":continue
    n += o[i]
  if n==o:break
  o=n
print("Nothing!"if o==""else o)
