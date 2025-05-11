using System;

class Program
{
    static void Main()
    {
        int[] digits = {1,2,3};
        var result = PlusOne(digits);
        Console.WriteLine(string.Join(",", result));
    }

    static int[] PlusOne(int[] digits)
    {
        string num = "";
        foreach(int d in digits)
        {
            num += d.ToString();
        }
        
        int number = int.Parse(num) + 1;
        string result = number.ToString();
        
        int[] newDigits = new int[result.Length];
        for(int i = 0; i < result.Length; i++)
        {
            newDigits[i] = int.Parse(result[i].ToString());
        }
        
        return newDigits;
    }
} 