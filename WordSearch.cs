using System;

class Program
{
    static void Main()
    {
        char[][] board = new char[][] {
            new char[] {'A','B','C','E'},
            new char[] {'S','F','C','S'},
            new char[] {'A','D','E','E'}
        };
        string word = "ABCCED";
        Console.WriteLine(Exist(board, word));
    }

    static bool Exist(char[][] board, string word)
    {
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[0].Length; j++)
            {
                if(SearchHelper(board, word, 0, i, j))
                {
                    return true;
                }
            }
        }
        return false;
    }
    
    static bool SearchHelper(char[][] board, string word, int index, int i, int j)
    {
        if(index == word.Length) return true;
        if(i < 0 || i >= board.Length || j < 0 || j >= board[0].Length) return false;
        if(board[i][j] != word[index]) return false;
        
        char temp = board[i][j];
        board[i][j] = '#';
        
        bool result = SearchHelper(board, word, index + 1, i + 1, j) ||
                     SearchHelper(board, word, index + 1, i - 1, j) ||
                     SearchHelper(board, word, index + 1, i, j + 1) ||
                     SearchHelper(board, word, index + 1, i, j - 1);
                     
        board[i][j] = temp;
        return result;
    }
} 