package main

import (
	"fmt"
)

func convertTemperature(celsius float64) []float64 {
	result := make([]float64, 2) // 创建一个长度为2的float64切片
	result[0] = celsius + 273.15 // 将摄氏度转换为开尔文并存储
	result[1] = celsius*1.8 + 32 // 将摄氏度转换为华氏度并存储
	return result
}

func main() {
	temperatures := convertTemperature(0.0) // 示例：将 0 摄氏度转换为开尔文和华氏度
	fmt.Println(temperatures)               // 输出: [273.15 32]
}
