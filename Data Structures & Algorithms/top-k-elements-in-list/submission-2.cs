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

        int[] arr = dict.Values.ToArray(); //frequency Count
        int[] arr1 = dict.Keys.ToArray();  //actual number

        Array.Sort(arr, arr1);
        Array.Reverse(arr1);


        int[] answer = new int[k];

        int i =0;
        while(k != 0)
        {
            answer[i] = arr1[i];
            i++;
            k--;
        }

        return answer;

    }
}
