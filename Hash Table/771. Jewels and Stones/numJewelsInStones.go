func numJewelsInStones(jewels string, stones string) int {
	result := 0
	for _, j := range jewels {
		for _, s := range stones {
			if j == s {
				result++
			}
		}
	}
	return result
}