open System

let isPrime numb =
    if (numb < 2) then
        false
    else
        Seq.initInfinite (fun x -> x + 2) |> Seq.takeWhile (fun x -> x * x <= numb) |>
        Seq.forall (fun x -> numb % x > 0)

let isConjecture numb =
    if (numb % 2 = 0 || isPrime numb) then
        true
    else
        Seq.initInfinite (fun x -> x + 1) |> Seq.takeWhile (fun x -> x * x * 2 < numb) |>
        Seq.exists (fun x -> (numb - 2 * x * x) |> isPrime)

let getResult () =
    Seq.initInfinite (fun x -> 2 * x + 3) |>
    Seq.filter (isConjecture >> not)

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult() |> Seq.take 2)
    0 // return an integer exit code