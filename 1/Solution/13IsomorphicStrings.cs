namespace Solution
{
    class solution13
    {
        public static bool IsIsomorphic(string s, string t)
        {
            Dictionary<int, char> firstStringDictonary = new Dictionary<int, char>();
            Dictionary<int, char> secondStringDictonary = new Dictionary<int, char>();
            Dictionary<char, int> reverseFirstStringDictionary = new Dictionary<char, int>();
            Dictionary<char, int> reverseSecondStringDictionary = new Dictionary<char, int>();
            int firstStringExtra = 0;
            int secondStringExtra = 0;
            string checkFirst = "";
            string checkSecond = "";
            Int64 checkFirstInt = 0;
            Int64 checkSecondInt = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (firstStringDictonary.ContainsValue(s[i]))
                {
                    firstStringExtra += i;
                    continue;
                }
                else
                {
                    firstStringDictonary.Add(i, s[i]);
                    reverseFirstStringDictionary.Add(s[i], i);
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (secondStringDictonary.ContainsValue(t[i]))
                {
                    secondStringExtra += i;
                    continue;
                }
                else
                {
                    secondStringDictonary.Add(i, t[i]);
                    reverseSecondStringDictionary.Add(t[i], i);
                }
            }

            foreach (var key in s)
            {
                checkFirst += reverseFirstStringDictionary[key].ToString();
                checkFirstInt += reverseFirstStringDictionary[key];
            }
            foreach (var key in t)
            {
                checkSecond += reverseSecondStringDictionary[key].ToString();
                checkSecondInt += reverseSecondStringDictionary[key];
            }

            Console.WriteLine(checkFirst);
            Console.WriteLine(checkFirst);

            if (firstStringExtra == secondStringExtra && checkFirstInt == checkSecondInt && checkFirst == checkSecond)
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