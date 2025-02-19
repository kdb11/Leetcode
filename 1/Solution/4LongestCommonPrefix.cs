/* namespace Solution
{
    class Solution4
    {
        public static string LongestCommonPrefix(string[] strs) {
            char commonPrefix = 'a';
            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(strs[i].CompareTo(strs[i+1]));
                for (int j = 0; j < strs[i].Length; j++)
                {
                    Console.WriteLine(strs[i][j]);

                    if (strs[i][j] == strs[i][j] ){
                        Console.WriteLine("same");
                    }
                }
            }

            return "";
        }
    }
} */