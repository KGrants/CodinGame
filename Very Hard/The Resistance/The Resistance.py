import sys

Alphabet = [
  ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
  "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
  "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-",
  "-.--", "--.."]

def morse(s):
    res = ""
    for i in range(len(s)):
        res+= Alphabet[ord(s[i])-65]
    return res

def solve(start, a, dp):
    if start == len(a):
        return 1
    if dp.get(start, "None") != "None":
        return dp[start]

    if dp.get(start, "None") != "None":
        print("dp[start] = ", dp[start], file=sys.stderr, flush=True)
    

    res = 0
    for i in range(len(words)):
        if a[start:(len(words[i])+start if start+len(words[i])<=len(a) else None)] == words[i]:
            res += solve(start + len(words[i]), a, dp)
    if (dp.get(start, "None") == "None"):
        dp[start] = res
    else:
        dp[start] = dp[start] + res
    return res

l = input()
n = int(input())
words = []
for i in range(n):
    words.append(morse(input()))

print(solve(0,l,{}))