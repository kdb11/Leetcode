namespace Solution
{
public class solution2
{


public static int MaxProfit(int[] prices) {
        if (prices.Length == 0) 
        return 0;
    
        
        int lowValIndex = 0;
        for(int i = 0; i < prices.Length; i++){
           
           if(prices[lowValIndex] > prices[i]){
            lowValIndex = i;
           } 
           
        }

        int highValIndex = lowValIndex;
        for (int i = lowValIndex; i < prices.Length; i++)
        {
            if (prices[highValIndex] < prices[i])
            {
                highValIndex = i;
            }
        }

        if(prices[lowValIndex] < prices[highValIndex]){
            Console.WriteLine(prices[highValIndex] - prices[lowValIndex]);
            return prices[highValIndex] - prices[lowValIndex];
        }
        /* Console.WriteLine(lowValIndex);
        Console.WriteLine(highValIndex); */
        return 0;
        
    }

}
}
