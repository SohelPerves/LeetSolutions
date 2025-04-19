public class Solution {
    public int CountSymmetricIntegers(int low, int high) {
        int result=0;

        for(int i = low; i<=high;i++){
            string num = i.ToString();
            int n =num.Length;
           if (n % 2 != 0) continue;
            int firstSum=0; 
            int lastSum=0;
            for(int j = 0; j < n/2; j++){
                firstSum += num[j];
                lastSum += num[n-j-1];
            }
            if(firstSum==lastSum) result++;           
        }
        return result;
    }
}
