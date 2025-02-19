namespace Solution
{
    class solution11
    {
        public static bool IsHappy(int n)
        {
            int separateNumbers = 0;
            bool niklas = true;
            bool result = false;
            int sum = 0;

            Dictionary<int, int> numbersDictionary = new Dictionary<int, int>();

            string numberAsString = n.ToString();

            while (niklas)
            {
                foreach (var number in numberAsString)
                {
                    separateNumbers = int.Parse(number.ToString());

                    int multipliedNumbers = separateNumbers * separateNumbers;

                    numbersDictionary.Add(separateNumbers, multipliedNumbers);
                }

                foreach (var element in numbersDictionary)
                {
                    sum += element.Value;

                }
                Console.WriteLine(sum);
                if (sum == 1)
                {
                    niklas = false;
                    result = true;
                }
            }

            return result;
        }
    }
}