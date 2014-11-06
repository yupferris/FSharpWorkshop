let rec quicksort = function
    | [] -> []
    | head :: tail ->
        let smaller, larger = List.partition ((>=) head) tail
        List.concat
            [quicksort smaller; quicksort larger]

match quicksort [1; 5; 23; 18; 9; 1; 3] with
| [1; 1; 3; 5; 9; 18; 23] -> printfn "Great :D"
| _ -> failwith "Bummer, not there yet!"
