let square x = x * x

let fixMe x =
    let square x = square x * x
    [for i in 0 .. x -> square x]

match fixMe 4 with
| [16; 16; 16; 16; 16] -> printfn "Perfect!"
| _ -> failwith "Not quite, try again :)"
