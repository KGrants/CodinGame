from collections import deque

def can_escape(N, grid):
    # Start position is always at the center
    start_x = start_y = N // 2  
    start_elevation = grid[start_x][start_y]
    
    # Directions: Up, Down, Left, Right
    directions = [(-1, 0), (1, 0), (0, -1), (0, 1)]
    
    # BFS queue and visited set
    queue = deque([(start_x, start_y)])
    visited = set(queue)

    while queue:
        x, y = queue.popleft()

        # Check if we're at the border with elevation 0
        if (x == 0 or y == 0 or x == N-1 or y == N-1) and grid[x][y] == 0:
            return "yes"

        # Explore all possible moves
        for dx, dy in directions:
            nx, ny = x + dx, y + dy

            # Check if within bounds
            if 0 <= nx < N and 0 <= ny < N:
                # Check elevation difference constraint
                if abs(grid[nx][ny] - grid[x][y]) <= 1 and (nx, ny) not in visited:
                    queue.append((nx, ny))
                    visited.add((nx, ny))

    return "no"

# Read input
N = int(input())
grid = [list(map(int, input().split())) for _ in range(N)]

# Output result
print(can_escape(N, grid))
