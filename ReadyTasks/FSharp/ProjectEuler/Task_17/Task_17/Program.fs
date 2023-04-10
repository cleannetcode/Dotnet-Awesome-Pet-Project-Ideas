open System

let rec getStrDigit (numb: int) =
    let toTwenty = [|"zero"; "one"; "two"; "three"; "four"; "five"; "six"; "seven"; 
        "eight"; "nine"; "ten"; "eleven"; "twelve"; "thirteen"; "fourteen"; "fifteen";
        "sixteen"; "seventeen"; "eighteen"; "nineteen"|]
    let tenth = [|"twenty"; "thirty"; "forty"; "fifty"; "sixty"; "seventy"; "eighty"; "ninety"|]
    if (numb < 20) then
        toTwenty.[numb]
    else if (numb < 100) then
        if (numb % 10 = 0) then
            tenth.[numb / 10 - 2]
        else
            tenth.[numb / 10 - 2] + "-" + toTwenty.[numb % 10]
    else if (numb < 1000) then
        if (numb % 100 = 0) then
            toTwenty.[numb / 100] + " hundred"
        else
            toTwenty.[numb / 100] + " hundred and " + (getStrDigit (numb % 100))
    else if (numb < 10000) then
        if (numb % 1000 = 0) then
            toTwenty.[numb / 100] + " thousand"
        else
            toTwenty.[numb / 1000] + (getStrDigit (numb % 1000))
    else
        "Not supported yet"

let getNumbLength (numb: int) =
    numb |> getStrDigit |> String.filter Char.IsLetter |> String.length

let getResult (numb: int) =
    [1..numb] |> List.map getNumbLength |> List.sum

[<EntryPoint>]
let main argv =
    printfn "%A" (1000 |> getResult)
    0 // return an integer exit code