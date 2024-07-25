package main

import "fmt"

func minimumOperations(nums []int) int {
	var result int = 0
	for _, num := range nums {
		if num%3 != 0 {
			result++
		}
	}
	return result
}

func main() {
	nums1 := []int{1, 2, 3, 4}
	nums2 := []int{3, 6, 9}

	fmt.Println(minimumOperations(nums1))
	fmt.Println(minimumOperations(nums2))
}
