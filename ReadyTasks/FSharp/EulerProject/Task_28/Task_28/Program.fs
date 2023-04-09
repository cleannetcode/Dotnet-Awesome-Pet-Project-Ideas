open System

let getResult (num: int) =
    let halfNum = num / 2 + 1
    let firstSum = Seq.initInfinite (fun x -> 4 * x * x + 4 * x + 1) |> Seq.take halfNum |> Seq.sum
    let secondNum = Seq.initInfinite (fun x -> 4 * x * x + 2 * x + 1) |> Seq.take halfNum |> Seq.sum
    let thirdNum = Seq.initInfinite (fun x -> 4 * x * x + 1) |> Seq.take halfNum |> Seq.sum
    let fourthNum = Seq.initInfinite (fun x -> 4 * x * x - 2 * x + 1) |> Seq.take halfNum |> Seq.sum
    firstSum + secondNum + thirdNum + fourthNum - 3

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 1001)
    0 // return an integer exit code