package main

import (
	"fmt"
)

func interpret(command string) string {
	result := ""
	bracket := false
	temp := ""
	for _, ch := range command {
		if ch == '(' {
			bracket = true
		} else if ch == ')' {
			if temp == "" {
				result += "o"
			} else {
				result += temp
				temp = ""
			}
			bracket = false
		} else if bracket {
			temp += string(ch)
		} else {
			result += string(ch)
		}
	}
	return result
}

func main() {
	command := "G()(al)"
	result := interpret(command)
	fmt.Println(result)
}
