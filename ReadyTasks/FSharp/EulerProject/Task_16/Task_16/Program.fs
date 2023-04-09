// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open System.Numerics

let rec getDigitSum (numb: bigint) =
    if (numb = 0I) then
        0I
    else
        (numb % 10I) + (getDigitSum (numb / 10I))

[<EntryPoint>]
let main argv =
    printfn "%A" (getDigitSum <| BigInteger.Pow(2I, 1000))
    0 // return an integer exit code