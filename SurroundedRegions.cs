using System;

class Program
{
    static void Main()
    {
        char[][] board = new char[][] {
            new char[] {'X','X','X','X'},
            new char[] {'X','O','O','X'},
            new char[] {'X','X','O','X'},
            new char[] {'X','O','X','X'}
        };
        Solve(board);
        for(int i = 0; i < board.Length; i++)
        {
            Console.WriteLine(new string(board[i]));
        }
    }

    static void Solve(char[][] board)
    {
        if(board.Length == 0) return;
        
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[0].Length; j++)
            {
                if(board[i][j] == 'O')
                {
                    if(IsSurrounded(board, i, j))
                    {
                        CaptureRegion(board, i, j);
                    }
                }
            }
        }
    }
    
    static bool IsSurrounded(char[][] board, int i, int j)
    {
        if(i < 0 || i >= board.Length || j < 0 || j >= board[0].Length) return false;
        if(board[i][j] != 'O') return true;
        
        board[i][j] = '#';
        bool result = IsSurrounded(board, i+1, j) &&
                     IsSurrounded(board, i-1, j) &&
                     IsSurrounded(board, i, j+1) &&
                     IsSurrounded(board, i, j-1);
        board[i][j] = 'O';
        
        return result;
    }
    
    static void CaptureRegion(char[][] board, int i, int j)
    {
        if(i < 0 || i >= board.Length || j < 0 || j >= board[0].Length) return;
        if(board[i][j] != 'O') return;
        
        board[i][j] = 'X';
        CaptureRegion(board, i+1, j);
        CaptureRegion(board, i-1, j);
        CaptureRegion(board, i, j+1);
        CaptureRegion(board, i, j-1);
    }
} 