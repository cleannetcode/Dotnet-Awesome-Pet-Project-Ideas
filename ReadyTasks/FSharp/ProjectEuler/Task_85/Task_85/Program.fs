open System

let inc x = x + 1

let getSum a =
    a * (a + 1L) / 2L

let getResult a b =
    getSum a * getSum b

let findSolution numb =
    {1..(numb |> float |> sqrt |> int |> inc |> (fun x -> x * 2))} |> Seq.collect (fun x -> {1..(numb |> float |> sqrt |> int |> inc |> (fun x -> x * 2))} |> Seq.map (fun y -> (x,y))) |>
    Seq.minBy (fun (x,y) -> numb - (getResult ((int64)x) ((int64)y)) |> abs)

[<EntryPoint>]
let main argv =
    printfn "%A" (findSolution 2000000L)
    0 // return an integer exit code