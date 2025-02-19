namespace Solution
{
    class Solution3
    {
        public static int RemoveElement(int[] nums, int val) {

            var numbersList = nums.ToList();
            
            numbersList.RemoveAll(i => i == val);

            nums = numbersList.ToArray();

            foreach (var number in nums)
            {
                Console.WriteLine(number);
            }

            return nums.Length;       
          
        }
    }
}

