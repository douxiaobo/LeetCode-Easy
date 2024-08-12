package main

func findIntersectionValues(nums1 []int, nums2 []int) []int {
	num1 := 0
	num2 := 0

	for _, num := range nums1 {
		for _, val := range nums2 {
			if num == val {
				num1++
				break
			}
		}
	}

	for _, num := range nums2 {
		for _, val := range nums1 {
			if num == val {
				num2++
				break
			}
		}
	}

	return []int{num1, num2}
}

// 示例用法
func main() {
	nums1 := []int{1, 2, 3, 4, 5}
	nums2 := []int{3, 4, 5, 6, 7}
	result := findIntersectionValues(nums1, nums2)
	println("Intersection counts:", result[0], result[1])
}
