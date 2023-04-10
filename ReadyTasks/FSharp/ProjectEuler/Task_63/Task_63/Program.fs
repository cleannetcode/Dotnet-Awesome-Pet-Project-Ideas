open System
open System.Numerics
let rec getResult power =
    let max = BigInteger.Pow(10I, power)
    let min = BigInteger.Pow(10I, power - 1)
    let len = Seq.initInfinite (fun x -> (x + 1) |> bigint) |> Seq.takeWhile (fun x -> BigInteger.Pow(x, power) < max) |> Seq.filter (fun x -> BigInteger.Pow(x, power) >= min) |> Seq.length
    if (len = 0) then 
        0
    else
        len + (getResult (power + 1))

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 1)
    0 // return an integer exit code