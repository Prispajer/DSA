public class Solution {
    public bool IsSubsequence(string s, string t) {
        int read_s = 0;

        for(int i = 0; i  < t.Length; i++){
            if(read_s < s.Length && s[read_s] == t[i]){
                read_s++;
            }
        }

        return read_s == s.Length;
    }
}
