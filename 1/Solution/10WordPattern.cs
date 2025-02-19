namespace Solution
{
    class solution10
    {
        public static bool WordPattern(string pattern, string s)
        {

            string[] wordsInSArray = s.Split(" ").ToArray();
            string check = "";

            Dictionary<char, string> wordPatternDictionary = new();

            string distinctLettersInPattern = new(pattern.Distinct().ToArray());

            string[] distinctWordsArray = s.Split(" ").Distinct().ToArray();
            bool result = false;

            Console.WriteLine(distinctWordsArray.Length);

            if (distinctLettersInPattern.Length == distinctWordsArray.Length)
            {
                for (int i = 0; i < distinctWordsArray.Length; i++)
                {
                    wordPatternDictionary.Add(distinctLettersInPattern[i], distinctWordsArray[i]);
                }
            }

            for (int i = 0; i < wordsInSArray.Length; i++)
            {
                check += wordPatternDictionary.FirstOrDefault(x => x.Value == wordsInSArray[i]).Key;
            }


            if (check == pattern)
            {
                result = true;
            } else {
                result = false;
            }
/*             foreach (var ele in wordPatternDictionary)
            {
                Console.WriteLine($"Key: {ele.Key}, Value: {ele.Value}");
            } */

/*             foreach (var letter in pattern)
            {
                check = wordPatternDictionary[letter];
                
            } */
            Console.WriteLine(check);
            Console.WriteLine(pattern);

            return result;
        }
    }
}