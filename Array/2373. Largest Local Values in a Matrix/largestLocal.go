func largestLocal(grid [][]int) [][]int {
	n := len(grid) - 2
	result := make([][]int, n)
	for i := range result {
		result[i] = make([]int, n)
	}
	for i := 0; i < n; i++ {
		for j := 0; j < n; j++ {
			num := 0
			for a := i; a < i+3; a++ {
				for b := j; b < j+3; b++ {
					if grid[a][b] > num {
						num = grid[a][b]
					}
				}
			}
			result[i][j] = num
		}
	}
	return result
}