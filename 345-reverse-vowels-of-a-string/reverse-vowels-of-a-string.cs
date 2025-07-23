public class Solution {
    public string ReverseVowels(string s) {
        char[] charArray = s.ToCharArray();  
        HashSet<char> vowels = new HashSet<char>(){'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        int leftChecker = 0;
        int rightChecker = charArray.Length - 1;
        char temp = '\0';

        while (leftChecker < rightChecker)
        {

            while (leftChecker < rightChecker && !vowels.Contains(charArray[leftChecker]))
            {
                leftChecker++;
            };
            
            while (rightChecker > leftChecker && !vowels.Contains(charArray[rightChecker]))
            {
                rightChecker--;
            };
            
            temp = charArray[leftChecker];
            charArray[leftChecker] = charArray[rightChecker];
            charArray[rightChecker] = temp;

            rightChecker--;
            leftChecker++;
        }

        return string.Join("", charArray); 
    }  
}
