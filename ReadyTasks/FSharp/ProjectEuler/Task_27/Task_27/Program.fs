open System

let isPrime num =
    if (num < 2L) then
        false
    else
        Seq.initInfinite (fun x -> (int64)(x + 2)) |> 
        Seq.takeWhile (fun x -> x * x <= num) |>
        Seq.forall (fun x -> num % x > 0L)

let countMaxPrimes a b =
    Seq.initInfinite (fun x -> x) |>
    Seq.takeWhile (fun x -> x * x + a * x + b |> int64 |> isPrime) |>
    Seq.length

let getResult maxA maxB =
    [-maxA..maxA] |> List.allPairs [-maxB..maxB] |>
    List.maxBy (fun (a,b) -> countMaxPrimes a b) |>
    (fun (a,b) -> a * b)

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 999 1000)
    0 // return an integer exit code