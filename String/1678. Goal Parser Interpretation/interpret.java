class Solution {
    public String interpret(String command) {
        String result = "";
        boolean bracket = false;
        String temp = "";
        for (char ch : command.toCharArray()) {
            if (ch == '(') {
                bracket = true;
            } else if (ch == ')') {
                if (temp.equals("")) {
                    result += 'o';
                } else {
                    result += temp;
                    temp = "";
                }
                bracket = false;
            } else if (bracket) {
                temp += ch;
            } else {
                result += ch;
            }
        }
        return result;
    }
}