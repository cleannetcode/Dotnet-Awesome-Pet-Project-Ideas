open System

let isPandigital (numb: string) =
    if ((String.length numb) <> 9) then
        false
    else
        (numb |> Seq.map (fun x -> (int)x - (int)'0') |> Seq.sum) = 45 && (numb |> Seq.distinct |> Seq.length) = 9

let formPandigital numb =
    let rec helpFunc numb mult currStr =
        if ((String.length currStr) >= 9) then
            currStr
        else
            let newStr = currStr + (numb * mult).ToString()
            helpFunc numb (mult + 1) newStr
    helpFunc numb 1 ""

let getResult () =
    [1..10000] |> List.map formPandigital |> List.filter isPandigital |> List.map int |> List.max

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult ())
    0 // return an integer exit code