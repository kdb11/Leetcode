namespace Solution
{
    class solution13
    {
        public static bool IsIsomorphic(string s, string t)
        {
            Dictionary<int, char> firstStringDictonary = new Dictionary<int, char>();
            Dictionary<int, char> secondStringDictonary = new Dictionary<int, char>();
            int firstStringExtra = 0;
            int secondStringExtra = 0;

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
                }
            }
            for (int i = 0; i < firstStringDictonary.Count; i++)
            {
                
                KeyValuePair<int, char> firstStringItems = secondStringDictonary.ElementAt(i);
                KeyValuePair<int, char> secondStringItems = secondStringDictonary.ElementAt(i);

            }

            /* Console.WriteLine(firstStringExtra);
            Console.WriteLine(secondStringExtra); */

            firstStringDictonary.AsParallel().ForAll(x => Console.WriteLine(x.Key));

            if (firstStringExtra == secondStringExtra)
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