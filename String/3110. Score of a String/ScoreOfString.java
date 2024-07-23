public class ScoreOfString {
    public int scoreOfString(String s) {
        int score=0;
        for(int i=0;i<s.length()-1;i++){
            if (s.charAt(i) > s.charAt(i + 1)) {
                score += s.charAt(i) - s.charAt(i + 1);
            } else {
                score += s.charAt(i + 1) - s.charAt(i);
            }
        }
        return score;
    }
    public static void main(String[] args){
        ScoreOfString sol = new ScoreOfString();
        System.out.println(sol.scoreOfString("hello"));
        System.out.println(sol.scoreOfString("zaz"));
    }
}
