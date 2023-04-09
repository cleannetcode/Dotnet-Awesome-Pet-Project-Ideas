open System
open System.Collections.Generic

let isPrime num =
    let rec helpFunc num ind =
        match num with
        | n when n % ind = 0 -> false
        | n when n < (ind * ind) -> true
        | n                      -> helpFunc num (ind + 1)
    helpFunc num 2

let getResult maxNumb =
    let primes = [|2..maxNumb|] |> Array.filter isPrime |> Array.map int64
    let primesSet = HashSet<int64>(primes)
    let primesSum = Seq.scan (fun acc x -> acc + (int64)x) 0L primes |> Seq.takeWhile (fun x -> x <= (int64)maxNumb) |> Array.ofSeq
    let primesLength = (primesSum |> Array.length) - 1
    [0..primesLength] |> 
    List.map (fun i -> {primesLength..(-1)..(i + 1)} |> Seq.tryFind (fun j -> primesSet.Contains(primesSum.[j] - primesSum.[i])) |> (fun x -> (i,x))) |>
    List.filter (fun (_,b) -> Option.isSome b) |> List.maxBy (fun (a, Some b) -> b - a) |> (fun (i, Some j) -> primesSum.[j] - primesSum.[i])

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 1000000)
    0 // return an integer exit code