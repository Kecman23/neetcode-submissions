public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> map = new Dictionary<int,int>();

        foreach (int num in nums){
            if(map.ContainsKey(num)){
                map[num]++;
            }
            else{
                map[num] = 1;
            }
        }

        var sorted = map.OrderByDescending(x=>x.Value);
        var topK = sorted.Take(k);
        var result = topK.Select(x=> x.Key).ToArray();
        return result;
    }
}
