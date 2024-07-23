package main

import (
	"fmt"
)

func scoreOfString(s string) int {
	score := 0
	for i := 0; i < len(s)-1; i++ {
		if s[i] > s[i+1] {
			score += int(s[i]) - int(s[i+1])
		} else {
			score += int(s[i+1]) - int(s[i])
		}
	}
	return score
}

func main() {
	fmt.Println(scoreOfString("hello")) // 输出结果
	fmt.Println(scoreOfString("zaz"))   // 输出结果
}
