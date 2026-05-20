public class Solution {
    public bool hasDuplicate(int[] nums) {

        
        for (int i=0; i<nums.Length;i++){
            int num = nums[i];

            for(int j=0; j<nums.Length;j++){
                if(j==i){
                    continue;
                }
                else if(nums[i]==nums[j]){
                    return true;
                }
            }
            
            
            
        }
        return false;
    }
}