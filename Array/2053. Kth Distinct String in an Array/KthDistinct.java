import java.util.HashMap;

class Solution {
    public String kthDistinct(String[] arr, int k) {
        HashMap<String, Integer> dict = new HashMap<>();

        // 统计每个字符串的出现次数
        for (String str : arr) {
            dict.put(str, dict.getOrDefault(str, 0) + 1);
        }

        int count = 0;
        // 找到第k个独特的字符串
        for (String str : arr) {
            if (dict.get(str) == 1) {
                count++;
                if (count == k) {
                    return str;
                }
            }
        }
        return "";
    }

    public static void main(String[] args) {
        Solution solution = new Solution();
        String[] arr = {"a", "b", "a", "c", "b"};
        int k = 2;
        System.out.println(solution.kthDistinct(arr, k)); // 输出 "c"
    }
}