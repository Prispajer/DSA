public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder mergedString = new StringBuilder();
        int iterationLength = Math.Max(word1.Length, word2.Length);

        for(int i = 0; i < iterationLength; i++){
            if(i < word1.Length) {
                mergedString.Append(word1[i]);
            }
            if(i < word2.Length) {
                mergedString.Append(word2[i]);
            }
        }

        return mergedString.ToString();
    }
}