open System

let rec getPowerSum num power =
    if (num = 0) then
        0
    else
        let rem = num % 10
        let div = num / 10
        (pown rem power) + (getPowerSum div power)

let getResult power =
    let max = pown 10 (power + 1)
    [2..max] |> List.filter (fun x -> x = getPowerSum x power) |> List.sum

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 5)
    0 // return an integer exit code