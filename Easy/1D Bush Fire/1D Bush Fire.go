package main

import "fmt"
import "os"
import "bufio"

func main() {
    scanner := bufio.NewScanner(os.Stdin)
    scanner.Buffer(make([]byte, 1000000), 1000000)

    var N int
    scanner.Scan()
    fmt.Sscan(scanner.Text(),&N)
    
    for i := 0; i < N; i++ {
        scanner.Scan()
        line := scanner.Text()
        _ = line // to avoid unused error
        var a int
        a = 0
        for j := 0; j < len(line); j++ {
            if line[j]=='f'{
                a = a + 1
                j = j + 2
            }
        }
        fmt.Println(a)
    }
}