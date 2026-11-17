public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        int left = 0;
        int maxFreq = 0;
        int answer = 0;

        for (int right = 0; right < s.Length; right++) {
            char currChar = s[right];

            if (!dict.ContainsKey(currChar))
                dict.Add(currChar, 1);
            else
                dict[currChar]++;  

            if (dict[currChar] > maxFreq)
                maxFreq = dict[currChar];

            int length = right - left + 1;

            if (length - maxFreq > k) {
                dict[s[left]]--;
                left++;
            }

            int curr_window = right - left + 1;
            if (curr_window > answer)
                answer = curr_window;
        }
        return answer;
    }
}
