public class Solution
{
    public string ReverseWords(string input)
    {
        string trimmedInput = RemoveExtraSpaces(input);
        char[] characters = trimmedInput.ToCharArray();
        string result = ReverseWordsInCharArray(characters);
        return result; 
    }

    private string RemoveExtraSpaces(string input)
    {
        StringBuilder builder = new StringBuilder();
        bool previousWasSpace = true;

        foreach (char c in input)
        {
            if (c == ' ')
            {
                if (!previousWasSpace)
                {
                    builder.Append(' ');
                    previousWasSpace = true;
                }
            }
            else
            {
                builder.Append(c);
                previousWasSpace = false;
            }
        }

        return builder.ToString().Trim();
    }

    private string ReverseWordsInCharArray(char[] characters)
    {
        void Reverse(char[] arr, int left, int right)
        {
            while (left < right)
            {
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }

        Reverse(characters, 0, characters.Length - 1);

        int wordStart = 0;

        while (wordStart < characters.Length)
        {
            while (wordStart < characters.Length && characters[wordStart] == ' ') wordStart++;

            int wordEnd = wordStart;
            while (wordEnd < characters.Length && characters[wordEnd] != ' ') wordEnd++;

            Reverse(characters, wordStart, wordEnd - 1);

            wordStart = wordEnd;
        }

        return new string(characters);
    }
}
