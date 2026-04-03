public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0, r = 1;
        int mProf = 0;
        while (r < prices.Length) {
            if (prices[l] < prices[r]) {
                int prof = prices[r] - prices[l];
                mProf = Math.Max(prof, mProf); 
            } else {
                l = r;
            }
            r++;
        }

        return mProf;
    }
}
