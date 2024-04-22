func getConcatenation(nums []int) []int {
	res := make([]int, 0, len(nums)*2)
	for i := 0; i < 2; i++ {
		for j := 0; j < len(nums); j++ {
			res = append(res, nums[j])
		}
	}
	return res
}