public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
              //  key, value
        Dictionary<int, int> dict = new Dictionary<int, int>();

        int count = 1;
        foreach(int n in nums)
        {
            if(!dict.ContainsKey(n))
            {
                dict.Add(n, count);
            }
            else
            {
                dict[n]++;
            }
        }

        int[] frequencies = dict.Values.ToArray(); 
        int[] numbers = dict.Keys.ToArray(); 

        Array.Sort(frequencies, numbers); 
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
