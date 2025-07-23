public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int maxValue = candies.Max();
        IList<bool> result = new List<bool>();

        for(int i = 0; i < candies.Length; i++){
            if(candies[i] + extraCandies >= maxValue){
                result.Add(true);
            }
            else{
                result.Add(false);
            }
        }
        
        return result;
        // return candies.Select(c => c + extraCandies >= maxValue).ToList();
    }
}