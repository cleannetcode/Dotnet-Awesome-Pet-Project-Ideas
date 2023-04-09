open System

let isPrime numb =
    if (numb < 2) then
        false
    else
        Seq.initInfinite (fun x -> x + 2) |>
        Seq.takeWhile (fun x -> x * x <= numb) |>
        Seq.forall (fun x -> numb % x > 0)

let generatePandigital numb =
    let rec generator digits currnumb =
        if (List.isEmpty digits) then
            [currnumb]
        else
            digits |> List.collect (fun x -> generator (List.filter (fun y -> y <> x) digits) (currnumb * 10 + x))
    generator [1..numb] 0

let getResult () =
    [1..9] |> List.collect generatePandigital |> List.filter isPrime |> List.max

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult ())
    0 // return an integer exit code