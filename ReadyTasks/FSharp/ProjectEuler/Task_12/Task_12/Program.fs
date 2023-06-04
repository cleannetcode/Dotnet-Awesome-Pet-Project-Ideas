// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let getDivNumb numb =
    let rec helpFunc numb i =
        if (i * i > numb) then 
            0
        else if (i * i = numb) then 
            1
        else if (numb % i = 0) then
            2 + (helpFunc numb (i + 1))
        else
            (helpFunc numb (i + 1))
    helpFunc numb 1

// Define a function to construct a message to print
let getTriangleSequence () =
    Seq.initInfinite (fun x -> x + 1) |> Seq.scan (fun acc x -> acc + x) 0

let getResult numb =
    getTriangleSequence() |> Seq.find (fun x -> getDivNumb x > 500)

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 500)
    0 // return an integer exit code