public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] combined = nums1.Concat(nums2).ToArray();
        Array.Sort(combined);
        int length = combined.Length;
        int left = 0;
        int right = length - 1;
        double result = 0;

        while (left <= right)
        {
            if (length % 2 == 0)
            {
                result = (combined[left] + combined[right]) / 2.0;
            }
            else
            {
                result = combined[left];
            }

            left++;
            right--;
        }

        return result;
    }
}