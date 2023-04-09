// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let squareSum num = (num * (num + 1I) * num * (num + 1I)) / 4I

let sumSquare num = (num * (num + 1I) * (2I * num + 1I)) / 6I
    
let getResult num = (squareSum num) - (sumSquare num)

[<EntryPoint>]
let main argv =
    let result = getResult 100I
    printfn "%s" (result.ToString())
    0 // return an integer exit code