package main

import (
	"fmt"
	"strconv"
	"strings"
)

func getChunkSum(chunk string) int {
	sum := 0
	isDouble := false

	for i := len(chunk) - 1; i >= 0; i-- {
		digit, _ := strconv.Atoi(string(chunk[i]))

		if isDouble {
			digit *= 2
			if digit > 9 {
				digit -= 9
			}
		}

		sum += digit
		isDouble = !isDouble
	}

	return sum
}

func main() {
	creditCard := "Credit_Card_Number"
	chunks := strings.Split(creditCard, " ")

	totalSum := 0
	for _, chunk := range chunks {
		totalSum += getChunkSum(chunk)
	}

	fmt.Println(totalSum%10 == 0)
}
