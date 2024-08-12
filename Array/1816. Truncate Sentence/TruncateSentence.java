class Solution {
    public String truncateSentence(String s, int k) {
        StringBuilder result = new StringBuilder();
        for (char ch : s.toCharArray()) {
            if (ch == ' ') {
                k--;
            }
            if (k == 0) {
                break;
            }
            result.append(ch);
        }
        return result.toString();
    }

    public static void main(String[] args) {
        Solution sol = new Solution();
        String str = "Hello how are you Contestant";
        int k = 4;
        String result = sol.truncateSentence(str, k);
        System.out.println("Truncated sentence: " + result);
    }
}
