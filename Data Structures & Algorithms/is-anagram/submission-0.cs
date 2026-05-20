public class Solution {
    public bool IsAnagram(string s, string t) {

            char[] arr1 = s.ToCharArray();
           char[] arr2 = t.ToCharArray();
           Array.Sort(arr1);
           Array.Sort(arr2);

            string sSorted = new string(arr1);
            string tSorted = new string(arr2);

            if(sSorted == tSorted){
                return true;
            }
            else{
                return false;
            }
           

    }
}
