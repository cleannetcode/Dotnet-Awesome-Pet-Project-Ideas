// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let rec factorial num =
    if (num = 0) then
        1
    else
        num * (factorial (num - 1))

let rec getDigitFactSum num =
    if (num = 0) then
        0
    else
        (factorial (num % 10)) + (getDigitFactSum (num / 10))

let getResult () =
    [10..10000000] |> List.filter (fun x -> x = (getDigitFactSum x)) |> List.sum

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult ())
    0 // return an integer exit code