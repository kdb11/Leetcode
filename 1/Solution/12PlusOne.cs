namespace Solution
{   
     class solution12
    {
        public static int[] PlusOne(int[] digits) {
            
            string digitsToString = ""; 
            foreach (var number in digits)
            {
                digitsToString += number.ToString();
            }   
            Console.WriteLine(digitsToString);

            double.TryParse(digitsToString, out double numberFromDigits);

            Console.WriteLine(numberFromDigits);

            numberFromDigits = numberFromDigits + 1;

            string numberAfterAdditionAsString = numberFromDigits.ToString();

            double[] reusltArray = new double [numberAfterAdditionAsString.Length];

            for (int i = 0; i < numberAfterAdditionAsString.Length; i++)
            {
                double eachNumberAfterAddition = double.Parse(numberAfterAdditionAsString[i].ToString());
                reusltArray[i] = eachNumberAfterAddition;
            }

            foreach (var number in reusltArray)
            {
                Console.WriteLine(number);
            }

            return [];
        }
    }
}