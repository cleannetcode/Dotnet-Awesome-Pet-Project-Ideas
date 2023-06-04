open System

let getDivSum num =
    Seq.initInfinite (fun x -> x + 2) |> Seq.takeWhile (fun x -> x * x <= num) |>
    Seq.map (fun x -> if (x * x = num) then x else if (num % x = 0) then x + num / x else 0) |>
    Seq.sum |> (fun x -> x + 1)

let isAbundant num =
    (getDivSum num) > num

let getResult (num: int) =
    let abundantSet = [1..num] |> List.filter isAbundant |> Set.ofList
    let canBeFormedFromAbundant numb =
        abundantSet |> Set.exists (fun x -> Set.contains (numb - x) abundantSet)
    [1..num] |> List.filter (fun x -> not (canBeFormedFromAbundant x)) |> List.sum

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 28123)
    0 // return an integer exit code