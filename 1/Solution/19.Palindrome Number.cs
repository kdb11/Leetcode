namespace Solution
{
    class solution19
    {
        public static bool IsPalindrome(int x)
        {

            string xAsString = x.ToString();

            char[] xAsArray = xAsString.ToCharArray();

            string reversedString = "";

            Console.WriteLine(xAsString);

            Array.Reverse(xAsArray);

            foreach (var item in xAsArray)
            {
                reversedString += item;
            }

            Console.WriteLine(reversedString);

            if (xAsString == reversedString)
            {
                return true;
            }

            return false;
        }
    }
}