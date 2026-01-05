public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int read = 0;
        int write = 0;
        int currentNumber = 0;

        while (read < nums.Length) {
            currentNumber = nums[read];

            while (read < nums.Length && currentNumber == nums[read]) {
                read++;
            }

            nums[write] = currentNumber;
            write++;
        }

        return write;
    }
}