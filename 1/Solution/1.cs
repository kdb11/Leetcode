namespace Solution
{
class solution1
{
    public static int RemoveDuplicates(int[] nums) {

        nums.OrderDescending();
        int[] noDup = nums.Distinct().ToArray();

        /* foreach (var number in noDup)
        {
            
            Console.WriteLine(number);
        } */
        int k = 0;
        if (noDup.Length == 0)
        {
            k = noDup.Length;
            return k;
        }

        k = noDup.Length;
        for (int i = 0; i < k; i++)
        {
            nums[i] = noDup[i];
        }
        
        return k;
        
        
        
    }
}
}