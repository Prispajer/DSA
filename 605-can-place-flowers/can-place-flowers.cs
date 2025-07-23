public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {     
        int counter = 0;

        if(flowerbed.Length >= 2 && flowerbed[0] == 0 && flowerbed[1] == 0){
            flowerbed[0] = 1;
            counter++;
            if(counter >= n) return true;
        }

        if(flowerbed.Length >= 2 && flowerbed[^1] == 0 && flowerbed[^2] == 0){
            flowerbed[^1] = 1;
            counter++;
            if(counter >= n) return true;
        }

        if(flowerbed.Length == 1 && flowerbed[0] == 0) return true;

        for(int i = 1; i + 1 < flowerbed.Length; i++){
            if(flowerbed[i] == 0 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0){
                flowerbed[i] = 1;
                counter++;
                if(counter >= n) return true;
            }
        }

        if(counter >= n) return true;

        return false;
    }
}
