package main

import "fmt"

func kthDistinct(arr []string, k int) string {
	dict := make(map[string]int)

	for _, str := range arr {
		dict[str]++
	}

	count := 0
	for _, str := range arr {
		if dict[str] == 1 {
			count++
			if count == k {
				return str
			}
		}
	}
	return ""
}

func main() {
	arr := []string{"d", "b", "c", "b", "c", "a"}
	k := 2
	fmt.Println(kthDistinct(arr, k)) // 输出 "c"
}
