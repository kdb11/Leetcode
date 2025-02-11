namespace Solution
{
    class solution5
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n) {
            
            

            /* for (int i = 0; i < m; i++)
            {
                Console.WriteLine(nums1[i]);
            }

            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine(nums2[i]);
            } */
            
            /* nums1 = nums1.Concat(nums2).OrderBy(i => i).Select(x => x).Where(x => x != 0).ToArray();
            nums1.Select(x => x).Where(x => x != 0);

            for (int i = 0; i < nums1.Length; i++)
            {
                Console.WriteLine(nums1[i]);
            } */

            for(int i = 0; i < n; i++){
            nums1[m + i] = nums2[i];
            
            }

            Array.Sort(nums1);

            foreach (var number in nums1)
            {
                Console.WriteLine(number);
            }

        }
    }
}