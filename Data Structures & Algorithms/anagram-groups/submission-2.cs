public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

        foreach (string str in strs) {
            char[] sortedChars = str.ToCharArray();
            Array.Sort(sortedChars);
            string sortedStr = new string(sortedChars);

            if (!anagramGroups.ContainsKey(sortedStr)) {
                anagramGroups[sortedStr] = new List<string>();
            }

            anagramGroups[sortedStr].Add(str);
        }

        return anagramGroups.Values.ToList();
    }
}