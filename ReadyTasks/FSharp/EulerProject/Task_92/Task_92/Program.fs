open System
open System.Collections.Generic;

let dict = new Dictionary<int,int>()
let rec getSquareSum numb =
    if (numb = 0) then
        0
    else
        (numb % 10) * (numb % 10) + (getSquareSum (numb / 10))

let rec getResult numb =
    if (numb = 89 || numb = 1) then
        numb
    else if (dict.ContainsKey(numb)) then
        dict.[numb]
    else
        let value = numb |> getSquareSum |> getResult
        dict.Add(numb, value)
        value

let getNumbers numb =
    {1..numb} |> Seq.filter (fun x -> getResult x = 89) |> Seq.length

[<EntryPoint>]
let main argv =
    printfn "%A" (getNumbers 10000000)
    0 // return an integer exit code