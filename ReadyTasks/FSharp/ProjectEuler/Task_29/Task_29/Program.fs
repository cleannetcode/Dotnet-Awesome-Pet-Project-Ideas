open System

let getResult minA maxA minB maxB =
    [minA..maxA] |> List.allPairs [minB..maxB] |> List.map (fun (a: int,b) -> bigint.Pow(bigint(a), b)) |>
    List.distinct |> List.length

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 2 100 2 100)
    0 // return an integer exit code