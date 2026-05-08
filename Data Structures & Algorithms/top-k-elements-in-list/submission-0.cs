public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        List<int> list = new List<int>();

                 //<key, value>
                 //<value, count>
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int value = 1;
            int key = nums[i];
           
            //if new element
            if (!dictionary.ContainsKey(key)) { dictionary.Add(key, value); }
            else //if dictionary already exists, increment value
            {
                dictionary[key]++;
            }
        }

        var sortedList = dictionary.OrderByDescending(pair => pair.Value).ToList();
  

       int[] answer = new int[k];


       for (int i = 0; i < k; i++)
       {
        answer[i] = sortedList[i].Key;

       }

       return answer;

    }
}
