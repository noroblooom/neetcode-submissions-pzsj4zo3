public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0, r = 1;
        int mProf = 0;

        while (r < prices.Length) {
            if (prices[l] < prices[r]) {
                int profit = prices[r] - prices[l];
                mProf = Math.Max(mProf, profit);
            } else {
                l = r;
            }
            r++;
        }

        return mProf;
    }
}
