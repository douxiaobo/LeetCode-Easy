package main

func findPermutationDifference(s string, t string) int {
	index := [26]int{}
	for i, ch := range s {
		index[ch-'a'] = i
	}
	result := 0
	for i, ch := range t {
		if index[ch-'a'] > i {
			index[ch-'a'] = index[ch-'a'] - i
		} else {
			index[ch-'a'] = i - index[ch-'a']
		}
		result += index[ch-'a']
	}
	return result
}
