func canBeIncreasing(nums []int) bool {
	for i := 0; i < len(nums); i++ {
		temp := make([]int, 0, len(nums)-1)
		for j := 0; j < len(nums); j++ {
			if i != j {
				temp = append(temp, nums[j])
			}
		}
		increasing := true
		for k := 0; k < len(temp)-1; k++ {
			if temp[k] >= temp[k+1] {
				increasing = false
				break
			}
		}
		if increasing {
			return true
		}
	}
	return false
}