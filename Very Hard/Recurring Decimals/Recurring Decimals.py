def fractionToDecimal(numr, denr):
    res = ""
    mp = {}
    rem = numr % denr
    aaa = str(numr //denr)+"."
    while ((rem != 0) and (rem not in mp)):
        mp[rem] = len(res)
        rem = rem * 10
        res_part = rem // denr
        aaa += str(res_part)
        res += str(res_part)
        rem = rem % denr
 
    if (rem == 0):
        return aaa
    else:
        return aaa[0:aaa.find(str(res[mp[rem]:]))]+"("+res[mp[rem]:]+")"
 
n = int(input())
print(fractionToDecimal(1, n))