open System

let isPrime num =
    if (num < 2) then
        false
    else
        Seq.initInfinite (fun x -> x + 2) |> 
        Seq.takeWhile (fun x -> x * x <= num) |> 
        Seq.forall (fun x -> num % x > 0)

let rec getCodeNumb (numb: int) =
    if (numb = 0) then
        0L
    else
        (pown 10L (numb % 10)) + (getCodeNumb (numb / 10))

let isPermitations (numb: int list) =
    let code = numb |> List.head |> getCodeNumb
    numb |> List.forall (fun x -> code = (getCodeNumb x))

let getResult () =
    let primes = [1000..9999] |> List.filter isPrime
    let primesSet = primes |> Set.ofList
    primes |> 
    List.collect (fun x -> primes |> List.filter (fun y -> y > x && (Set.contains (2 * y - x) primesSet)) |> List.map (fun y -> [x; y; 2 * y - x])) |>
    List.filter isPermitations

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult())
    0 // return an integer exit code