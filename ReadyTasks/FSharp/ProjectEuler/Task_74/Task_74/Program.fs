open System
open System.Collections.Generic

let fact numb =
    {1..numb} |> Seq.fold (fun acc x -> acc * bigint(x)) 1I

let rec getSum numb =
    if (numb = 0I) then
        0I
    else
        (fact ((numb % 10I) |> int)) + (getSum (numb / 10I))

let getChainLength numb =
    let nums = new HashSet<bigint>()
    let rec getLength numb =
        if (nums.Contains(numb)) then
            0
        else
            let isAdded = nums.Add(numb)
            1 + (numb |> getSum |> getLength)
    getLength numb

let getResult max numb =
    {1..max} |> Seq.map (fun x -> x |> bigint |> getChainLength) |> Seq.filter (fun x -> x = numb) |> Seq.length

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 1000000 60)
    0 // return an integer exit code