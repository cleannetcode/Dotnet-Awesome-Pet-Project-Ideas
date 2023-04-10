open System

let isPrime num =
    if (num < 2) then
        false
    else
        Seq.initInfinite (fun x -> x + 2) |> 
        Seq.takeWhile (fun x -> x * x <= num) |> 
        Seq.forall (fun x -> num % x > 0)

let isCircularPrime num =
    let generateNums numb =   
        let power = numb.ToString() |> String.length
        let mult = pown 10 (power - 1)
        [1..(power - 1)] |> List.scan (fun acc x -> acc / 10 + (acc % 10) * mult) numb
    generateNums num |> List.forall isPrime

let getResult numb =
    [1..numb] |> List.filter isCircularPrime |> List.length

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 1000000)
    0 // return an integer exit code