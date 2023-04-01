import sys
import math

urlbar = input()
if "http://" in urlbar or "ftp://" in urlbar or "https://" in urlbar:
    print(urlbar)
else:
    if '.' in urlbar:
        print("http://"+urlbar)
    else:
	  print("ftp://"+urlbar)