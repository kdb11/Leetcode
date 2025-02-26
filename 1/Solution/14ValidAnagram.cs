namespace Solution
{
    class solution14
    {
        public static bool IsAnagram(string s, string t) {
            List<char> ifEmptyThereIsAnagram = [];
            if (s.Length != t.Length)
            {
                return false;
            }

            foreach (var c in s)
            {
                ifEmptyThereIsAnagram.Add(c);
            }

            Dictionary<char, char> anagram = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t[i])
                {
                    anagram.Add(s[i], t[i]);
                    ifEmptyThereIsAnagram.Remove(s[i]);
                }

                for (int j = 0; j < s.Length; i++)
                {
                    
                }
            }
            
            foreach (var element in ifEmptyThereIsAnagram)
            {
                Console.WriteLine(element);
            }
            return false;
        }
    }
}