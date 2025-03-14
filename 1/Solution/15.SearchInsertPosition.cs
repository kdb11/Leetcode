namespace Solution
{
    class solution15
    {
        public static int SearchInsert(int[] nums, int target)
        {
            if (nums[nums.Length - 1] < target)
            {
                return nums.Length;
            }

            if (nums[0] > target)
            {
                return 0;
            }

            int leftPointer = 0;
            int rightPointer = nums.Length - 1;

            while (leftPointer <= rightPointer)
            {
                int mid = leftPointer + (rightPointer - leftPointer) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] < target)
                {
                    leftPointer = mid + 1;
                }
                else // nums[mid] > target
                {
                    rightPointer = mid - 1;
                }
            }

            return leftPointer;
        }

    }
}