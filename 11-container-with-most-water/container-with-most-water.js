/**
 * @param {number[]} height
 * @return {number}
 */
function maxArea(height) {
  let left = 0;
  let right = height.length - 1;
  let max = 0;

  while (left < right) {
    const h = Math.min(height[left], height[right]);
    const w = right - left; 
    const area = h * w; 

    max = Math.max(max, area); 

    if (height[left] < height[right]) {
      left++;
    } else {
      right--;
    }
  }

  return max;
}