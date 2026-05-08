public class Solution {
    public bool IsAnagram(string s, string t) {

        List<char> characters1 = new List<char>();
        List<char> characters2 = new List<char>();

        if(s.Length != t.Length)
        {
            return false;
        }

        else //adds characters into a list
        {
            for(int i = 0; i < s.Length; i++)
            {
                characters1.Add(s[i]);
                characters2.Add(t[i]);
            }

            for(int i = 0; i < s.Length; i++)
            {
                if(characters1.Contains(s[i]) && characters2.Contains(s[i]))
                {
                    characters1.Remove(s[i]);
                    characters2.Remove(s[i]);
                }
            }
            if (!characters1.Any() && !characters2.Any()) //if list1 and list2 are empty then Anagram = true
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
