namespace Solution
{
    class solution13
    {
        public static bool IsIsomorphic(string s, string t)
        {
            string resultCheck = "";

            Dictionary<int, char> firstStringDictonary = new Dictionary<int, char>();
            Dictionary<char, int> secondStringDictonary = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (firstStringDictonary.ContainsKey(s[i]))
                {

                    continue;
                }
                else
                {
                    firstStringDictonary.Add(i, s[i]);
                }
                /* Console.WriteLine(firstStringDictonary[i]); */
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (secondStringDictonary.ContainsKey(t[i]))
                {

                    continue;
                }
                else
                {
                    secondStringDictonary.Add(t[i], i);
                }

            }

            for (int i = 0; i < firstStringDictonary.Count; i++)
            {
                /* if (secondStringDictonary[t[i]] == firstStringDictonary[i])
                resultCheck += firstStringDictonary[secondStringDictonary[t[i]]]; */

                Console.WriteLine(firstStringDictonary[secondStringDictonary[t[i]]]);
                Console.WriteLine();

            }

            

/*             Console.WriteLine(t);
            Console.WriteLine(resultCheck); */

            if (resultCheck == t)
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