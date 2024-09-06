using System;

class Program
{
    static void Main()
    {
        string creditCard = "Credit_Card_Number";
        string[] chunks = creditCard.Split(' ');
        
        int totalSum = 0;
        foreach (string chunk in chunks)
        {
            totalSum += GetChunkSum(chunk);
        }
        
        Console.WriteLine(totalSum % 10 == 0);
    }
    
    static int GetChunkSum(string chunk)
    {
        int sum = 0;
        bool isDouble = false;
        
        for (int i = chunk.Length - 1; i >= 0; i--)
        {
            int digit = chunk[i] - '0';
            
            if (isDouble)
            {
                digit *= 2;
                if (digit > 9) digit -= 9;
            }
            
            sum += digit;
            isDouble = !isDouble;
        }
        
        return sum;
    }
}
