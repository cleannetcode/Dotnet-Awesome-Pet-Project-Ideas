open System

let pandigitals () =
    Seq.initInfinite (fun x -> (((x + 1) * (3 * x + 2)) / 2) |> int64)

let getResult () =
    let rec helpFunc numb =
        let pandigs = pandigitals() |> Seq.take numb |> Array.ofSeq
        let pandSet = pandigs |> Set.ofArray
        let mutable result = -1L
        for i in {1..(numb - 1)} do
            for j in {(i - 1)..(-1)..0} do
                let f = pandigs.[i]
                let s = pandigs.[j]
                let diff = f - s
                let sum = s + f
                result <- if (result > -1L) then result else if (Set.contains sum pandSet && Set.contains diff pandSet) then diff else -1L
        if (result = -1L) then
            helpFunc (numb * 2)
        else
            result
    helpFunc 1000
[<EntryPoint>]
let main argv =
    printfn "%A" (getResult ())
    0 // return an integer exit code