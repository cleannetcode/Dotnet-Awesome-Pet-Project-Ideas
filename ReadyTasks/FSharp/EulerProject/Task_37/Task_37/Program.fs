open System

let isPrime numb =
    if (numb < 2) then
        false
    else
        Seq.initInfinite (fun x -> x + 2) |> 
        Seq.takeWhile (fun x -> x * x <= numb) |>
        Seq.forall (fun x -> numb % x > 0)

let isTruncPrime numb =
    if (numb < 10) then
        false
    else
        let strNumb = numb.ToString()
        [1..(String.length strNumb)] |> List.forall (fun ind -> (strNumb.Substring(0, ind)) |> int |> isPrime)

let isRevTruncPrime numb =
    if (numb < 10) then
        false
    else
        let strNumb = numb.ToString()
        [0..(String.length strNumb - 1)] |> List.forall (fun ind -> (strNumb.Substring(ind)) |> int |> isPrime)

let getResult numb =
    Seq.initInfinite (fun x -> x + 10) |> Seq.filter (fun x -> isTruncPrime x && isRevTruncPrime x) |>
    Seq.take (numb) |> Seq.sum

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 11)
    0 // return an integer exit code