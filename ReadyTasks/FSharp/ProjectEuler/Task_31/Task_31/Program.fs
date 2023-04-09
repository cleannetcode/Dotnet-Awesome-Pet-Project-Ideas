// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let getResult n =
    let coins = [1;2;5;10;20;50;100;200]
    let arr = [|0..n|] |> Array.map (fun x -> 0)
    arr.[0] <- 1
    for coin in coins do
        for i in {1..n} do
            arr.[i] <- if (i >= coin) then arr.[i] + arr.[i - coin] else arr.[i]
    arr.[n]

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 200)
    0 // return an integer exit code