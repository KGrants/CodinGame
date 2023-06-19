flour_total, sugar_total, eggs_total = [int(i) for i in input().split()]
flour_required, sugar_required, eggs_required = [int(i) for i in input().split()]

print(min(flour_total // flour_required, sugar_total // sugar_required, eggs_total // eggs_required))
