public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] answer = new int[nums.Length];
        int prefix = 1;
        int suffix = 1;

        answer[0] = prefix;

        for(int i = 1; i < nums.Length; i++){
            answer[i] = answer[i - 1] * nums[i - 1] ;
        }

        for(int i = nums.Length - 1; i >= 0; i--){
            answer[i] = answer[i] * suffix;
            suffix = suffix * nums[i];
        }

        return answer;
    }
}
