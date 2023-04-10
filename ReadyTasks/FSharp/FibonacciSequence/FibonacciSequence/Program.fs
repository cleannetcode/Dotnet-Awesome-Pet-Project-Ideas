open System

let fibonacciSequence () =
    let rec func a b =
        seq{
            yield a
            yield! func b (a + b)
        }
    func (bigint 1) (bigint 1)

[<EntryPoint>]
let main argv =
    fibonacciSequence() |> Seq.take 100 |> Seq.iteri (fun i x -> printfn "Fibonacci value at index %d is equal to %A" i x)
    0 // return an integer exit code