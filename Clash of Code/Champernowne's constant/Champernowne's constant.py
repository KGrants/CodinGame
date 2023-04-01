# You are going to have to get C10's decimal expansion's 
# digits from the Ith digit to the Jth digit inclusive

i, j = map(int, input().split(","))
c10 = ""

for x in range(1,j):
    c10+=str(x)

print(c10[i:j])