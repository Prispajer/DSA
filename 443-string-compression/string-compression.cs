public class Solution {
    public int Compress(char[] chars) {
        char current = '\0';
        int read = 0;
        int write = 0;
        int count = 0;

        if(chars.Length <= 1){
            return 1;
        }

        while(read < chars.Length){
            current = chars[read];
            count = 0;
            
            while(read < chars.Length && chars[read] == current){
                read++;
                count++;
            }

            chars[write++] = current;

            if(count > 1){
                string countString = count.ToString();
                for(int i = 0; i < countString.Length; i++){
                chars[write++] = countString[i];
                }
            }
        }
        
        return write;
    }
}
