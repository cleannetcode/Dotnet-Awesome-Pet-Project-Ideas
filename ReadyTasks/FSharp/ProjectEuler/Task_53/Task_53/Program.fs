open System
open System.Numerics

let factorial numb =
    if (numb < 2) then
        1I
    else
        [2..numb] |> List.fold (fun acc x -> acc * BigInteger(x)) 1I

let C n k =
    if (k > n) then
        0I
    else
        (factorial n) / ((factorial k) * (factorial (n - k)))

let getResult num =
    [1..num] |> List.allPairs [1..num] |> List.map (fun (a,b) -> C a b) |>
    List.filter (fun x -> x > 1000000I) |> List.length

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 100)
    0 // return an integer exit code