namespace Solution
{
    class solution20
    {
        public static bool IsSubsequence(string s, string t)
        {
            if (s == ""){
                return true;
            }

            string result = "";

            for (int i = 0; i < t.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == t[i])
                    {
                        result += s[j];
                    }

                    if (result == s){
                        return true;
                    }
                }
            }

            Console.WriteLine(result);

            return false;
        }
    }
}