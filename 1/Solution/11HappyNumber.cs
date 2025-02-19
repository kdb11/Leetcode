namespace Solution
{
    class solution11
    {
        public static bool IsHappy(int n)
        {
            int separateNumbers;
            bool niklas = true;
            bool result = false;
            int sum;

            Dictionary<int, int> numbersDictionary = new Dictionary<int, int>();

            string numberAsString = n.ToString();

            while (niklas)
            {
                for (int i = 0; i < numberAsString.Length; i++)
                {
                    separateNumbers = int.Parse(numberAsString[i].ToString());

                    int multipliedNumbers = separateNumbers * separateNumbers;

                    numbersDictionary.Add(i, multipliedNumbers);
                }

                sum = 0;
                foreach (var element in numbersDictionary)
                {
                    sum += element.Value;
                }
                Console.WriteLine(sum);
                if (sum == 1)
                {
                    result = true;
                    break;
                }
                numbersDictionary.Clear();
                numberAsString = sum.ToString();
                Console.WriteLine(sum);
                if (4 == sum || n == sum)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}