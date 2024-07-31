func equalFrequency(word string) bool {
	digit := [26]int{}
	for i := 0; i < len(word); i++ {
		digit[word[i]-'a']++
	}

	for i := 0; i < len(word); i++ {
		index := word[i] - 'a'
		digit[index]--
		freqs := 0
		temp := true
		for j := 0; j < 26; j++ {
			if digit[j] != 0 {
				if freqs == 0 {
					freqs = digit[j]
				} else if freqs != digit[j] {
					temp = false
				}
			}
		}
		if temp {
			return true
		}
		digit[index]++
	}

	return false
}