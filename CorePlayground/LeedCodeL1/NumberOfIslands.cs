namespace LeedCodeLove.LeedCodeL1
{
    public static class NumberOfIslands
    {
        public static int NumIslands(char[][] grid)
        {
            if (grid == null) return 0;
            int island = 0;

            for(int r=0; r < grid.Length; r++)
            {
                for(int c=0; c < grid[r].Length; c++)
                {
                    if(grid[r][c] == '1')
                    {
                        DFS(grid, r, c);
                        island += 1;
                    }
                }
            }
            return island;
        }

        public static void DFS(char[][] grid, int row, int col)
        {
            if (row < 0 || row >= grid.Length || col < 0 || col >= grid[row].Length || grid[row][col] == '0')
                return;

            grid[row][col] = '0';

            // Right
            DFS(grid, row + 1, col);

            // Left
            DFS(grid, row - 1, col);

            // Up
            DFS(grid, row, col + 1);

            // Down
            DFS(grid, row, col - 1);
        }
    }

    
}
