open System

// Define a function to construct a message to print

let getTriangleNumbAtInd (ind: bigint) =
    ind |> (fun x -> x * (x + bigint(1)) / bigint(2))

let triangleSequence () =
    Seq.initInfinite (fun x -> x + 1) |> Seq.map (bigint >> getTriangleNumbAtInd)

[<EntryPoint>]
let main argv =
    triangleSequence() |> Seq.take 10 |> Seq.iter (printfn "%A")
    0 // return an integer exit code