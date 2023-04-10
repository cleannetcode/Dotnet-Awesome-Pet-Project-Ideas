open System

let getKey numb =
    numb.ToString() |> Seq.sort |> Seq.map (fun x -> x.ToString()) |> String.concat ""

let getRes numb =
    let rec helpFunc value =
        let res = [1..value] |> List.map (fun x -> x |> int64 |> (fun y -> pown y 3)) |> List.groupBy getKey
        let v = res |> List.tryFind (fun (a,b) -> (List.length b) = numb)
        if (Option.isSome v) then
            Option.get v
        else
            helpFunc (value * 10)
    helpFunc 10

[<EntryPoint>]
let main argv =
    printfn "%A" (getRes 5)
    0 // return an integer exit code