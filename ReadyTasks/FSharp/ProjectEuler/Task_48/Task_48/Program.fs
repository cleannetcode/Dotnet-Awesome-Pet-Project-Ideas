open System

let getRemPow (numb: int64) (pow: int32) (rem: int64) =
    [1..pow] |> List.fold (fun acc x -> ((int64)acc * numb) % rem) 1L

let getResult (numb: int) (rem: int64) =
    [1..numb] |> List.map (fun x -> getRemPow ((int64)x) x rem) |> List.sum |> (fun x -> x % rem)

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 1000 10000000000L)
    0 // return an integer exit code