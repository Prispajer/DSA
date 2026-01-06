public class Solution
{
    public int AddDigits(int num)
    {
        int sum = 0;
        int copyOfSum = 0;
        string numberString = num.ToString();
        
        if (num < 10)
        {
            return num;
        }

        while(numberString.Length != 1){
            sum = 0;
            for (int i = 0; i < numberString.Length; i++)
            {
                int digit = numberString[i] - '0';
                sum += digit;
            } 
            numberString = sum.ToString();
        }

        return sum;
    }
}