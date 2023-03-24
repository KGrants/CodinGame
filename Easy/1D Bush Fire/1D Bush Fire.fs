open System

let N = int(Console.In.ReadLine())
let inline (+=) (x : byref<_>) y = x <- x + y
for i in 0 .. N - 1 do
    let line = Console.In.ReadLine()
    ()
    let mutable a = 0
    let b = line.Length
    let mutable c = 0
    
    while c<b do
        if (line[c] = 'f') then
            &a += 1
            &c += 3
            ()
        else 
            &c += 1
            ()
    printfn "%d" a