public class Solution {
    public int MaxArea(int[] heights) {

       int left =0;
       int right = heights.Length -1;
       int area = 0;
       int result =0;

       while(left<right){
        
        area = (right-left) * Math.Min(heights[left],heights[right]);
        result = Math.Max(area,result);

        if(heights[left]<heights[right]){

            left++;
        }
        else if(heights[left]>heights[right]){
            right--;
        }
        else{
            right--;
        }
        
       }
       return result;
        
    }
}
