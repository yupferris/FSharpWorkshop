let someList = [1; 2; 3]

let rec fixMe = function
    | [] -> (2, 3)
    | [a; b] -> (a, b)
    | [x; y; z] -> (y, x)
    | head :: tail -> fixMe tail

match fixMe someList with
| (2, 3) -> printfn "That's it!"
| _ -> failwith "Nope!"
