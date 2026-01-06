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
            string copyOfString = numberString;
            sum = 0;

            for (int i = 0; i < copyOfString.Length; i++)
            {
                int digit = copyOfString[i] - '0';
                sum += digit;
            } 
            numberString = sum.ToString();
        }

        return sum;
    }
}