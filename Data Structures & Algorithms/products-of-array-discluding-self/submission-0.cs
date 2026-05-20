public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        List<int> numbers = new List<int>();
        for(int i=0;i<nums.Length;i++){

            int product = 1;
            for(int j=0;j<nums.Length;j++){
                
                if(j==i){
                    continue;
                }
                product *= nums[j];
            }
            numbers.Add(product);

        }

        int[] result = numbers.ToArray();
        return result;
        
    }
}
