open System

let rec numbToList a = 
    if (a < 10) then
        [a]
    else
        (a % 10)::(numbToList (a / 10))

let isSameDigits a b =
    (numbToList a |> List.sort) = (numbToList b |> List.sort)

let getResult numb =
    Seq.initInfinite (fun x -> x + 1) |> Seq.find (fun x -> [1..numb] |> List.map (fun y -> x * y) |> List.forall (fun y -> isSameDigits y x))

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 6)
    0 // return an integer exit code