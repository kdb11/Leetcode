namespace Solution
{
    class solution14
    {
        public static bool IsAnagram(string s, string t)
        {
            List<char> ifEmptyThereIsAnagram = [];
            List<char> tToList = [];
            if (s.Length != t.Length)
            {
                return false;
            }

            foreach (var c in s)
            {
                ifEmptyThereIsAnagram.Add(c);
            }
            foreach (var c in t)
            {
                tToList.Add(c);
            }

/*             foreach (var element in ifEmptyThereIsAnagram)
            {
                Console.WriteLine(element);
            } */

            /* Dictionary<char, char> anagram = new Dictionary<char, char>(); */

            for (int i = 0; i < s.Length; i++)
            {
                /* if (s[i] == t[i])
                {
                    anagram.Add(s[i], t[i]);
                    ifEmptyThereIsAnagram.Remove(s[i]);
                    Console.WriteLine(s[i]);
                } */

                for (int j = 0; j < s.Length; j++)
                {

                    if (s[i] == tToList[j])
                    {
                        ifEmptyThereIsAnagram.Remove(s[i]);
                        tToList[j] = '0';
                    }
                }
            }

/*             foreach (var element in ifEmptyThereIsAnagram)
            {
                Console.WriteLine(element);
            } */
            if (ifEmptyThereIsAnagram.Count == 0)
            {
                return true;
            } else{
                return false;
            }

        }
    }
}