class Solution:
    def interpret(self, command: str) -> str:
        result = ""
        bracket = False
        temp = ""
        for ch in command:
            if ch == '(':
                bracket = True
            elif ch == ')':
                if temp == "":
                    result += 'o'
                else:
                    result += temp
                    temp = ""
                bracket = False
            elif bracket:
                temp += ch
            else:
                result += ch
        return result