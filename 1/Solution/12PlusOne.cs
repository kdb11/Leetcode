using System.Numerics;

namespace Solution
{
    class solution12
    {
        public static int[] PlusOne(int[] digits)
        {

            string digitsToString = "";
            
            foreach (var number in digits)
            {
                digitsToString += number.ToString();
            }
            Console.WriteLine(digitsToString);

            BigInteger.TryParse(digitsToString, out BigInteger numberFromDigits);

            Console.WriteLine(numberFromDigits);

            numberFromDigits = numberFromDigits + 1;

            string numberAfterAdditionAsString = numberFromDigits.ToString();

            int[] reusltArray = new int[numberAfterAdditionAsString.Length];

            for (int i = 0; i < numberAfterAdditionAsString.Length; i++)
            {
                
                reusltArray[i] = int.Parse(numberAfterAdditionAsString[i].ToString());
            }

            foreach (var number in reusltArray)
            {
                Console.WriteLine(number);
            }

            return reusltArray;
        }
    }
}