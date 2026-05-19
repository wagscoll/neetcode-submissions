public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
 
        List<string> list1 = new List<string>();
        List<List<string>> answer = new List<List<string>>();
        // string word = "";


        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        foreach(string str in strs) 
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            string sortedWord = new string(arr);

            if(!dict.ContainsKey(sortedWord)) 
            {
                dict[sortedWord] = new List<string>();
            }

            dict[sortedWord].Add(str);
        }

        return dict.Values.ToList<List<string>>();
    }
}