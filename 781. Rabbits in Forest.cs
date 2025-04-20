public class Solution {
    public int NumRabbits(int[] answers) {
        Dictionary<int,int> freq = new Dictionary<int,int>();
        int total=0;

        foreach(int answer in answers ){
            if(!freq.ContainsKey(answer)){
                freq[answer]=0;
            }
            freq[answer]++;
        }
        foreach(var kvp in freq){
            int answer = kvp.Key;
            int count = kvp.Value;
            int groupSize = answer + 1;
            int groups = (count + groupSize - 1) / groupSize;
            total += groups * groupSize;
        }
        return total;
            
    }
}
