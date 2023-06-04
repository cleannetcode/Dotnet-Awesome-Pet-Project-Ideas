// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let isPrime num = 
    {2..num} |> Seq.takeWhile (fun x -> x * x <= num) |> Seq.forall (fun x -> num % x > 0)

let getPrimeSum max =
    {2..max} |> Seq.filter isPrime |> Seq.sumBy int64

[<EntryPoint>]
let main argv =
    let result = getPrimeSum 2000000
    printfn "%A" result
    0 // return an integer exit code