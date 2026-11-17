public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        int left = 0;
        int maxFreq = 0;
        int answer = 0;

        // right expands outwards, creating a dictionary-frequency mapping 
        for (int right = 0; right < s.Length; right++) 
        {
            char currChar = s[right];

            if (!dict.ContainsKey(currChar))        // if new char, add to dictionary w/ count 1
                dict.Add(currChar, 1);
            else
                dict[currChar]++;                   // else increment the count of that char

            if (dict[currChar] > maxFreq)
                maxFreq = dict[currChar];

            int length = right - left + 1;

            if (length - maxFreq > k){          /*
                                                    Right now left++ runs but dict still counts that character, 
                                                    so the frequencies get out of sync with the actual window.
                                                */  
            
                dict[s[left]]--;
                left++;
            }

            int curr_window = right-left+1;
            if(curr_window > answer)
                answer = curr_window;

        }

        foreach (var pair in dict)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
        
        return answer;

    }
}
