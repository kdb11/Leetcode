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
                merged = word1;
                for (int i = 0; i < lengthOfLongestWord; i++)
                {
                    merged.Remove(i, 1);
                    merged += word2[i];
                }
            }
            else
            {
                lengthOfLongestWord = word2.Length;
                merged = word2;
                for (int i = 0; i < lengthOfLongestWord; i++)
                {
                    merged.Remove(i, 1);
                    merged += word1[i];
                    
                }
            }



            Console.WriteLine(merged);

            return merged;
        }
    }
}