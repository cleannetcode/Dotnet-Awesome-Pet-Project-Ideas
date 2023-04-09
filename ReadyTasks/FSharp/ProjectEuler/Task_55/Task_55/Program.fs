open System
open System.Numerics

let getRevNumb (numb: bigint) =
    let rec helpFunc (numb: bigint) (copy: bigint) =
        if (numb = 0I) then
            copy
        else
            helpFunc (numb / 10I) (copy * 10I + numb % 10I)
    helpFunc numb 0I

let isLychrel (numb: bigint) =
    let rec helpFunc (numb: bigint) (iter: int) =
        if (iter < 0) then
            false
        else
            let revNumb = getRevNumb numb
            if (revNumb = numb) then
                true
            else
                helpFunc (numb + revNumb) (iter - 1)
    helpFunc (numb + getRevNumb numb) 60

let getResult maxNumb =
    [1..maxNumb] |> List.filter (fun x -> BigInteger(x) |> isLychrel |> not) |> List.length

[<EntryPoint>]
let main argv =
    printfn "%A" (getRevNumb 18241123I)
    printfn "%A" (getResult 10000)
    0 // return an integer exit code