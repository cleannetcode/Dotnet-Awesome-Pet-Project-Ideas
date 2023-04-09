open System

let getDivSum num = 
    Seq.initInfinite (fun x -> x + 2) |> Seq.takeWhile (fun x -> x * x <= num) |>
    Seq.sumBy (fun x -> if x * x = num then x else if (num % x = 0) then x + num / x else 0) |>
    (fun x -> x + 1)

let isAmicable num =
    num = getDivSum (getDivSum num) && (getDivSum num <> num)

let getResult num =
    [1..num] |> List.filter isAmicable |> List.sum

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 10000)
    0 // return an integer exit code