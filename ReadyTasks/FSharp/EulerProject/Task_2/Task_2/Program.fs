// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let fibonacciSequence () =
    Seq.unfold (fun (a,b) -> Some(a, (b, a + b))) (1,2)

let getEvenSum max =
    fibonacciSequence() |> Seq.takeWhile (fun x -> x < max) |> Seq.filter (fun x -> x % 2 = 0) |> Seq.sum

let rec getEvenSumFast a b max =
    if (a > max) then
        0
    elif (a % 2 = 0) then
        a + (getEvenSumFast b (a + b) max)
    else
        (getEvenSumFast b (a + b) max)

[<EntryPoint>]
let main argv =
    let result = getEvenSumFast 1 2 4000000
    printfn "%d" result
    0 // return an integer exit code