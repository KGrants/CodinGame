import re

message = input()
message = re.sub(r"v+", "w", message)
print(message)