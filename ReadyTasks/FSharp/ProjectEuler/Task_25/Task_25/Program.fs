open System

let getFibonacciSeq () =
    Seq.unfold (fun (a,b) -> Some(a,(b, a + b))) (0I, 1I)

let getResult len =
    let filterFunc (num: bigint) =
        num |> string |> String.length |> (fun x -> x >= len)
    getFibonacciSeq() |> Seq.findIndex filterFunc

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 1000)
    0 // return an integer exit code