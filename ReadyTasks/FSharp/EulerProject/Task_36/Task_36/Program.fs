open System

let isPallindrome (numb: int) (baseVal: int) =
    Convert.ToString(numb, baseVal) = (Convert.ToString(numb, baseVal) |> Seq.rev |> Seq.map (fun x -> x.ToString()) |> String.concat "")

let getResult numb =
    let filterFunc numb = (isPallindrome numb 10) && (isPallindrome numb 2)
    [1..numb] |> List.filter filterFunc |> List.sum

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 1000000)
    0 // return an integer exit code