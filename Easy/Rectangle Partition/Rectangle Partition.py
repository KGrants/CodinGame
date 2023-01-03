import sys
import math

w, h, count_x, count_y = [int(i) for i in input().split()]
measureX = []
measureY = []
for i in input().split():
    measureX.append(int(i))
for i in input().split():
    measureY.append(int(i))


def mergeDict(dict1, dict2):
    dict3 = {**dict1, **dict2}
    for key, value in dict3.items():
        if key in dict1 and key in dict2:
            dict3[key] = value + dict1[key]
    
    return dict3
    
def countUnique(cutsList):
    unique = set(cutsList)
    result = {}
    for i in unique:
        result[i] = cutsList.count(i)
    
    return result
    
def getCuts(length, measures):
    listLength = len(measures)
    if listLength > 1:
        tempList = [(measures[-1] - measures[i]) for i in range(listLength) if (measures[-1] - measures[i]) > 0]
    else:
        tempList = []
    tempList.append(measures[-1])
    cut = length - measures[-1]   
    if cut > 0:
        tempList.append(cut)
    
    return countUnique(tempList)
    

def getCutList(cutsList, length, measures):
    for i in range(1, len(measures)+1):
        cutsList = mergeDict(cutsList, getCuts(length, measures[:i]))
        
    try:
        cutsList[length] = 1
    except:
        cutsList[length] += 1
    
    return cutsList
    
    
def countTotals(dictX, dictY):
    result = 0
    
    if len(dictX) >= len(dictY):
        smaller = dictY
        bigger = dictX
    else:
        smaller = dictX
        bigger = dictY
    
    for key in smaller:
        try:
            result += bigger[key] * smaller[key]
        except:
            pass
             
    return result


cutsX = getCutList({}, w, measureX)
cutsY = getCutList({}, h, measureY)

print(countTotals(cutsX, cutsY))