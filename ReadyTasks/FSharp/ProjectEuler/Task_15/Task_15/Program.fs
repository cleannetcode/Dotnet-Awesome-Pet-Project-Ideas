// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
      
let getResult numb =
    let mult = [(numb + 1)..(numb * 2)] |> List.map bigint |> List.reduce (fun acc x -> acc * x)
    let div = [2..numb] |> List.map bigint |> List.reduce (fun acc x -> acc * x)
    mult / div

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 20)
    0 // return an integer exit code