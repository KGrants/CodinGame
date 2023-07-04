n = int(input())
n_str = str(n)
i = len(n_str) - 1
reverse = ""
while i >= 0:
    reverse += n_str[i]
    i -= 1

number = int(reverse)
number_two = n - number

print(number_two)