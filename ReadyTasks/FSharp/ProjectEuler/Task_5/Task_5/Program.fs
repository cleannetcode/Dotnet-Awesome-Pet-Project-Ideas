open System

let isPrime numb =
    Seq.initInfinite (fun x -> (int64)x + 2L) |> Seq.takeWhile (fun x -> x * x <= numb) |> Seq.forall (fun x -> numb % x > 0L)

let rec gcd a b =
    if (a % b = 0L) then
        b
    else
        gcd b (a % b)

let getMaxProduct maxVal =
    [2L..maxVal] |> List.fold (fun acc x -> acc * x / (gcd acc x)) 1L

[<EntryPoint>]
let main argv =
    let result = getMaxProduct 20L
    printfn "%d" result
    0 // return an integer exit code