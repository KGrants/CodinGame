import sys
from math import sin, asin, pi
import re

# Input trimmed
R = int(re.sub("[^0-9]", "", input()))

# Constants
g = 9.8  # Acceleration due to gravity (m/s^2)
v = 158  # Initial velocity of the mortar round (m/s)

# Sanity checks based on M2 Mortar specifications
if R < 0 or R > 1800:
    print("OUT OF RANGE")
    sys.exit()

# Calculations
θ = (asin((R * g) / (v * v)) / 2) * (180 / pi)
θ = max(θ, 90 - θ)
t = (2 * v * sin(θ * pi / 180)) / g

# Round values
angle_rounded = round(θ, 1)
time_rounded = round(t, 1)

# Final answer check: If angle is out of range, return "OUT OF RANGE"
if θ <= 40 or θ >= 85:
    print("OUT OF RANGE")
else:
    print(f"{angle_rounded} degrees\n{time_rounded} seconds")
