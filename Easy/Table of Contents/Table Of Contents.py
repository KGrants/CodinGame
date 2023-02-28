l = int(input())
n = int(input())
a = {}
sub = 0
a[sub] = sub
for i in range(n):
    answer=""
    e = input().split()

    if e[0].count('>')>sub:
        a[e[0].count('>')] = 1
        sub = e[0].count('>')
    elif e[0].count('>')==sub:
        a[sub]+=1
    else:
        a[e[0].count('>')]+=1
        sub = e[0].count('>')
        
    if e[0][0] == '>':
        answer += "    "*e[0].count('>')
        e[0] = e[0].replace('>','')
    
    answer += str(a[sub])+" "+e[0]
    answer += "."*(l-(len(answer)+len(str(e[1])))) +e[1]
    print(answer)