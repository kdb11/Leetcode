namespace Solution
{
    class solution10
    {
        public static bool WordPattern(string pattern, string s)
        {

            Dictionary<char, string> wordPatternDictionary = new();

            string distinctLettersInPattern = new(pattern.Distinct().ToArray());

            /* string distinctWordsInS = new(s.Distinct().ToArray()); */
            string[] distinctWordsArray = s.Split(" ").Distinct().ToArray();
            bool result = false;

            Console.WriteLine(distinctWordsArray.Length);
            /* Console.WriteLine(distinctLettersInPattern.Length); */

            if (distinctLettersInPattern.Length == distinctWordsArray.Length)
            {
                for (int i = 0; i < distinctWordsArray.Length; i++)
                {
                    wordPatternDictionary.Add(distinctLettersInPattern[i], distinctWordsArray[i]);
                }
                result = true;
            }

            foreach (var ele in wordPatternDictionary)
            {
                Console.WriteLine($"Key: {ele.Key}, Value: {ele.Value}");
            }

            return result;
        }
    }
}