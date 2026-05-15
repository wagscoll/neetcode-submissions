public class Solution {
    public int MaxProfit(int[] prices) 
    {
        
        int currentDay = 0;
        int maxProfit = 0;
        for(int i = 0; i < prices.Length; i++)
        {
            //set current day and check future profits
            currentDay = prices[i];
            Console.WriteLine($"Purchase Day = {i} -- Price: {prices[i]}");

            int j = i+1;
            while(j <= prices.Length -1)
            {
                int tempProfit = prices[j] - prices[i];
                if(maxProfit < tempProfit){maxProfit = tempProfit;}

                Console.WriteLine($"\tSell Day = {j} \n\t\tPotential Profit: {maxProfit}");
                j++;
            }
        }
        return maxProfit;
    }
}
