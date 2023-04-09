open System

let isPandigital (str: string) =
    (str |> Seq.sort |> Seq.map (fun x -> x.ToString()) |> String.concat "") = "123456789"

let getResult () =
    [1..1000] |> List.allPairs [1..10000] |> 
    List.filter (fun (a,b) -> a.ToString() + b.ToString() + (a * b).ToString() |> isPandigital) |>
    List.map (fun (a,b) -> a * b) |> List.distinct |> List.sum

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult())
    0 // return an integer exit code