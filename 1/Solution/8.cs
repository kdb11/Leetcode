// two sum

namespace Solution
{
    class solution8
    {
        public static int[] TwoSum(int[] nums, int target) {
            
            int[] resultIndexes = [];
            int comparison = 0;
            int comparisonIndex = 0;
            bool nextIterationBool = true;
            bool abdi = true;
            int a = 0;

            while(abdi)
            {
                
                for (int i = a; i < nums.Length; i++)
                {
                    
                    while (nextIterationBool)
                    {
                        comparison = nums[i];
                        comparisonIndex = i;
                        nextIterationBool = false;    
                    }
                        
                        if (comparison + nums[i] == target && comparisonIndex != i){
                            resultIndexes = [comparisonIndex, i];
                            abdi = false;
                            break;        
                        }   
                            
                }
                    nextIterationBool = true;
                    a++; 
                    continue;
                
            }
            
            Console.WriteLine(comparison);
            foreach (var index in resultIndexes)
            {
                Console.WriteLine(index);
            }
            return resultIndexes;
        }
    }
}