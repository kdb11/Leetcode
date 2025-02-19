namespace Solution
{
    class solution6
    {
        public static int MajorityElement(int[] nums) {
            
            nums = nums.Select(i => i).OrderByDescending(i => i).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            return 0;
        }
    }
}