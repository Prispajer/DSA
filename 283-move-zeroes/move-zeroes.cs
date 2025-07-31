public class Solution {
    public void MoveZeroes(int[] nums) {
        int firstNumber = 0;
        int firstZero = 0; 
        int read = 0;

        // Usuwam warunek if, bo ogranicza przypadki
        while(read < nums.Length){
            // Szukamy pierwszego zera od lewej
            while(firstZero < nums.Length && nums[firstZero] != 0){
                firstZero++;
            }

            // Szukamy liczby ≠ 0, która jest po zerze
            firstNumber = firstZero + 1;
            while(firstNumber < nums.Length && nums[firstNumber] == 0){
                firstNumber++;
            }

            // Jeśli nie znaleziono już niezerowego – przerwij
            if (firstNumber >= nums.Length || firstZero >= nums.Length) {
                break;
            }

            // Zamiana miejscami
            Swapper(nums, firstZero, firstNumber);
            
            // Przesuwamy read (niekoniecznie potrzebny, ale zostawiam zgodnie z Twoją logiką)
            read++;
        }

        void Swapper(int[] arr, int left, int right){
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;    
        }
    }
}
