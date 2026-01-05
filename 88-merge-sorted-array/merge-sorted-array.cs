public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
       int nums1Length = m - 1;
       int nums2Length = n - 1;
       int combinedLength = m + n - 1;  

       while(nums2Length >= 0){
        if(nums1Length >= 0 && nums2[nums2Length] > nums1[nums1Length]){
            nums1[combinedLength] = nums2[nums2Length];
            nums2Length--;
        }
        else if(nums1Length >= 0 && nums2[nums2Length] < nums1[nums1Length]){
            nums1[combinedLength] = nums1[nums1Length];
            nums1Length--;
        }
        else{
            nums1[combinedLength] = nums2[nums2Length];
            nums2Length--;
        }
        combinedLength--;
       }
    }
}