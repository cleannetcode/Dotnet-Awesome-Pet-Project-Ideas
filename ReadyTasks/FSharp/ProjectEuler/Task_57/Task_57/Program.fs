open System
open System.Numerics

let generateNumbSeq () =
    Seq.unfold (fun (a,b) -> Some((a,b), (a + 2I * b, a + b))) (3I,2I)

let getResult numb =
    let filterFunc (a,b) =
        a.ToString().Length > b.ToString().Length
    generateNumbSeq() |> Seq.take numb |> Seq.filter filterFunc |> Seq.length

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 1000)
    0 // return an integer exit code