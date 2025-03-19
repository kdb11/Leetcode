namespace Solution
{
    class solution18
    {
        public static string MergeAlternately(string word1, string word2)
        {
            string merged = "";
            int lengthOfLongestWord = 0;


            if (word1.Length >= word2.Length)
            {
                lengthOfLongestWord = word1.Length;
                for (int i = 0; i < lengthOfLongestWord; i++)
                {
                    merged += word1[i];
                    if (i < word2.Length)
                    {
                        merged += word2[i];
                    }
                }
            }
            else
            {
                lengthOfLongestWord = word2.Length;
                for (int i = 0; i < lengthOfLongestWord; i++)
                {
                    if (i < word1.Length)
                    {
                        merged += word1[i];
                    }
                    merged += word2[i];
                }
            }

            Console.WriteLine(merged);

            return merged;
        }
    }
}