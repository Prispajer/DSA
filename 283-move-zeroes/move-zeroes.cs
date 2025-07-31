public class Solution {
    public void MoveZeroes(int[] nums) {
        int firstNumber = 0;
        int firstZero = 0; 
        int read = 0;
 
            while(read < nums.Length){
                   while(firstZero < nums.Length && nums[firstZero] != 0){
                firstZero++;
            }

                firstNumber = firstZero + 1;
                while(firstNumber < read && nums[firstNumber] == 0){
                    firstNumber++;
                }
                
                if (firstNumber >= nums.Length || firstZero >= nums.Length) {
                break;
                }
                        
                Swapper(nums, firstZero, firstNumber);
                read++;
            }
        

        void Swapper(int[] arr, int left, int right){
            int temp = 0;
            temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;    
        }
    }
}
