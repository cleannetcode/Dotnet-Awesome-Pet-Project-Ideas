open System

let getMultSum mul max =
    let numb = max / mul
    (mul * numb * (numb + 1)) / 2

[<EntryPoint>]
let main argv =
    let result = (getMultSum 3 999) + (getMultSum 5 999) - (getMultSum 15 999)
    printfn "%d" result
    1