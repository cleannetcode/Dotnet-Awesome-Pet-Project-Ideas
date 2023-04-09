open System

let rec generatePandigitals digits =
    if (Array.isEmpty digits) then
        [|0L|]
    else
        digits |> 
        Array.collect (fun x -> (digits |> Array.filter (fun y -> y <> x) |> generatePandigitals |> Array.map (fun y -> (int64)x + y * 10L)))

let hasProperty (numb: int64) =
    let primes = [|17L;13L;11L;7L;5L;3L;2L|]
    primes |> Array.mapi (fun i x -> ((numb / (pown 10L i)) % 1000L) % x = 0L) |> Array.forall (fun x -> x)

// Define a function to construct a message to print
let getResult () =
    [|0..9|] |> generatePandigitals |> Array.filter hasProperty |> Array.sum

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult ())
    0 // return an integer exit code