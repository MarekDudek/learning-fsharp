module AnonymouosFunctions

let f = fun x y -> x + y
let g x y = x + y // this is recommended

printfn "It works!"
printfn "f    : %A" f
printfn "f 2 3: %i" (f 2 3)
printfn "g    : %A" g
printfn "g 2 3: %i" (g 2 3)

let ``isPrime?`` = true

printfn "prime? %b" ``isPrime?``

let x' = 23


let halfWay a b =
    let diff = b - a
    let mid = diff / 2
    mid + a

printfn "5-11 %i" (halfWay 5 11)
printfn "11-5 %i" (halfWay 11 5)

printfn "this is how you print %s" "string"

// redefining a value inside function
// if expression
// comparison with single equality!!!

let SafeUpperCase(s: string) =
    let s = if s = null then "" else s
    s.ToUpperInvariant()

printfn "something in upper-case is %s" (SafeUpperCase "something")

