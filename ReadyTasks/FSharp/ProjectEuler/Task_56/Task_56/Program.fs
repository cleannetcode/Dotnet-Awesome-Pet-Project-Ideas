open System
open System.Numerics

let rec countDigits numb =
    if (numb = 0I) then
        0
    else
        (int)(numb % 10I) + (countDigits (numb / 10I))

let getResult maxNumb maxPow =
    [1..maxNumb] |> List.allPairs [1..maxPow] |> List.map (fun (a,b) -> BigInteger.Pow(BigInteger(b), a) |> countDigits) |> List.max

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 100 100)
    0 // return an integer exit code