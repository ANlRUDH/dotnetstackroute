using System;

class Program
{
    static void Main()
    {
        int x = 123;
        Console.WriteLine(Reverse(x));
    }

    static int Reverse(int x)
    {
        string num = x.ToString();
        string reversed = "";
        
        if(num[0] == '-')
        {
            reversed = "-";
            for(int i = num.Length - 1; i > 0; i--)
            {
                reversed += num[i];
            }
        }
        else
        {
            for(int i = num.Length - 1; i >= 0; i--)
            {
                reversed += num[i];
            }
        }
        
        try
        {
            return int.Parse(reversed);
        }
        catch
        {
            return 0;
        }
    }
} 