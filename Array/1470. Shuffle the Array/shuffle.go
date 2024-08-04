func shuffle(nums []int, n int) []int {
	result := make([]int, len(nums))
	index := 0
	for i := 0; i < len(nums)/2; i++ {
		result[index] = nums[i]
		index++
		result[index] = nums[i+n]
		index++
	}
	return result
}