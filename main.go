// main.go
package main

import "C"
import "fmt"

//export HelloWorld
func HelloWorld() {
	fmt.Printf("hello world from GO\n")
}

// Sum :
//
//export Sum
func Sum(a, b int) int {
	return a + b
}

func main() {}

// compile the code as:
// go build -ldflags="-s -w" -buildmode=c-shared -o libgo.dll main.go
