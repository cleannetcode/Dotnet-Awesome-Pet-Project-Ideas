open System

let getDigitAtInd ind =
    let rec helpFunc ind digits mult =
        if (9 * mult * digits >= ind) then
            let numb = mult + (ind / digits)
            let digit = ind % digits
            numb.ToString().[digit] |> (fun x -> (int)x - (int)'0')
        else
            let newInd = ind - 9 * mult * digits
            helpFunc newInd (digits + 1) (mult * 10)
    if (ind = 0) then
        0
    else
        helpFunc (ind - 1) 1 1

let getResult indexes =
    indexes |> List.map getDigitAtInd |> List.fold (fun acc x -> acc * x) 1

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult [1;10;100;1000;10000;100000;1000000])
    0 // return an integer exit code