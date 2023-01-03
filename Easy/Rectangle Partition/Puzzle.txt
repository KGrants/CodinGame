There is a rectangle of given width w and height h,

On the width side, you are given a list of measurements.
On the height side, you are given another list of measurements.

Draw perpendicular lines from the measurements to partition the rectangle into smaller rectangles.

In all sub-rectangles (include the combinations of smaller rectangles), how many of them are squares?


Example

w = 10
h = 5
measurements on x-axis: 2, 5
measurements on y-axis: 3

   ___2______5__________ 
  |   |      |          |
  |   |      |          |
 3|___|______|__________|
  |   |      |          |
  |___|______|__________|

Number of squares in sub-rectangles = 4 (one 2x2, one 3x3, two 5x5)