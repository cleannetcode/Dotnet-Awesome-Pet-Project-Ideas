open System

let isTriangle numb =
    //x * (x + 1) = 2 * numb => x ^ 2 + x - 2 * numb
    let D = (1L + 8L * numb) |> double |> sqrt
    let res = (-1.0 + D) / 2.0
    res % 1.0 = 0.0

let isPentagonal numb =
    //x * (3 * x - 1) = 2 * numb => 3 * x ^ 2 - x - 2 * numb
    let D = (1L + 24L * numb) |> double |> sqrt
    let res = (1.0 + D) / 6.0
    res % 1.0 = 0.0

let isHexagonal numb =
    //x * (2 * x - 1) = numb => 2 * x ^ 2 - x - numb
    let D = (1L + 8L * numb) |> double |> sqrt
    let res = (1.0 + D) / 4.0
    res % 1.0 = 0.0

let multSeq () =
    Seq.initInfinite (fun x -> ((x + 1) * (2 * x + 1)) |> int64) |> Seq.filter (fun x -> isPentagonal x && isTriangle x)

[<EntryPoint>]
let main argv =
    printfn "%A" (multSeq() |> Seq.take 3)
    0 // return an integer exit code