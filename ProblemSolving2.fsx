let fixMe list =
    list
    |> List.map (fun x -> x * 3)
    |> List.filter (fun x -> x >= 4)
    |> List.rev

let testResult = fixMe [1 .. 10]

match testResult with
| [30; 27; 24; 21; 18; 15; 12] -> printfn "Success, well done!"
| _ -> failwith "Nope, not fixed yet!"

