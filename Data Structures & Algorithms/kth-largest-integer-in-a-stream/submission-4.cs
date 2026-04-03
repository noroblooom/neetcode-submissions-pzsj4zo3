public class KthLargest {
    private List<int> arr;
    private int k;

    public KthLargest(int k, int[] nums) {
        this.k = k;
        this.arr = new List<int>(nums);    
    }
    
    public int Add(int val) {
        arr.Add(val);
        arr.Sort();
        return arr[arr.Count - k];
    }
}
