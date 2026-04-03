public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0, r = 1;
        int maxP = 0;

        while (r < prices.Length) {
            if (prices[r] > prices[l]) {
                int profit = prices[r] - prices[l];
                maxP = catMax(maxP, profit);
            } else {
                l = r;
            }
            r++;
        }

        return maxP;
    }
    private int catMax(int x, int y) {
        int z = 0;
        if (x > y) {
            z = x;
        } else {
            z = y;
        }
        return z;
    }
}
