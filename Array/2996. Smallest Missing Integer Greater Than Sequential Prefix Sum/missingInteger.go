package main

import "fmt"

func missingInteger(nums []int) int {
	sum := nums[0]
	var prefix bool
	for i := 1; i < len(nums); i++ {
		if nums[i-1] == nums[i]-1 {
			sum += nums[i]
		} else {
			break
		}
	}
	for {
		prefix = true
		for i := 0; i < len(nums); i++ {
			if nums[i] == sum {
				sum++
				prefix = false
			}
		}
		if prefix {
			break
		}
	}
	return sum
}

// 示例用法
func main() {
	nums := []int{1, 2, 3, 5}
	result := missingInteger(nums)
	fmt.Println("Missing integer:", result)
}
