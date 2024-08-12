package main

import (
	"fmt"
)

func truncateSentence(s string, k int) string {
	result := ""
	for _, ch := range s {
		if ch == ' ' {
			k--
		}
		if k == 0 {
			break
		}
		result += string(ch)
	}
	return result
}

func main() {
	s := "Hello how are you Contestant"
	k := 4
	result := truncateSentence(s, k)
	fmt.Println("Truncated sentence:", result)
}
