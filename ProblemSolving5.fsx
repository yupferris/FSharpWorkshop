type User =
    {
        name : string
        email : string
    }

type Transaction =
    | CreateUser of string * string
    | DeleteUser of string
    | ChangeName of string * string
    | ChangeEmail of string * string

let apply state transaction =
    let updateUser name f =
        Set.map
            (fun x ->
                if x.name = name then f x
                else x)
            state

    match transaction with
    | CreateUser (name, email) -> Set.add { name = name; email = email } state
    | DeleteUser (name) -> Set.filter (fun x -> x.name <> name) state
    | ChangeName (name, newName) ->
        updateUser name (fun x -> { x with name = newName })
    | ChangeEmail (name, newEmail) ->
        updateUser name (fun x -> { x with name = newEmail })

let aggregate = List.fold apply Set.empty

let transactions =
    [
        CreateUser ("jimbo", "email@dot.com")
        CreateUser ("jane", "jane.rocks@com.com")
        ChangeEmail ("jane", "jane.new.email@com.com")
        CreateUser ("jeff", "ilikebands@music.com")
        ChangeName ("jimbo", "jimbaaao")
        DeleteUser "jane"
    ]

let expected =
    [
        { name = "jimbaaao"; email = "email@dot.com" }
        { name = "jeff"; email = "ilikebands@music.com" }
    ]
    |> Set.ofList

match aggregate transactions with
| x when x = expected -> printfn "Nailed it! Well done! :D"
| _ -> failwith "Keep at it, you'll get it soon ^^"
