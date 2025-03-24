namespace Solution
{
    class solution20
    {
        public static bool IsSubsequence(string s, string t)
        {

            
            List<char> result = [];

            for (int i = 0; i < t.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {

                    /* Console.WriteLine(s[j]); */
                    if (s[j] == t[i])
                    {
                        result.Add(s[j]);
                    }
                }
            }

            Console.WriteLine(result); 
            Console.WriteLine(t);

            return false;
        }
    }
}