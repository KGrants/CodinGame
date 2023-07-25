top_number, bottom_number = [int(i) for i in input().split()]

d = {}
d[0] =['|   |',  '|   |','|   |']
d[1] =['|   |',  '| * |','|   |']
d[2] =['|*  |',  '|   |','|  *|']
d[3] =['|*  |',  '| * |','|  *|']
d[4] =['|* *|',  '|   |','|* *|']
d[5] =['|* *|',  '| * |','|* *|']
d[6] =['|* *|',  '|* *|','|* *|']

print('+---+')
print(*d[top_number],sep='\n')
print('+---+')
print(*d[bottom_number],sep='\n')
print('+---+')
