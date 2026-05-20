public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
              //  key, value
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(!dict.ContainsKey(num))     // key is nums[num]
                dict.Add(num, 1);          // creates dict entry for nums[num], frequency
            else
                dict[num]++;                // if key already exists, increase frequency
        }

        int[] frequencies = dict.Values.ToArray(); 
        int[] numbers = dict.Keys.ToArray(); 

        Array.Sort(frequencies, numbers); // sorts numbers determined by frequencies as the ordering key, so both stay paired
        Array.Reverse(numbers);


        int[] answer = new int[k];

        int i =0;
        while(k != 0)
        {
            answer[i] = numbers[i];
            i++;
            k--;
        }

        return answer;
    }
}
