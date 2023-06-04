open System

let rec gcd a b =
    if (b = 0) then
        a
    else
        gcd b (a % b)

let getResult () =
    let filterFunc a b =
        if (a % 10 = b % 10 && a * (b / 10) = b * (a / 10)) then
            a % 10 > 0
        elif (a / 10 = b / 10 && a * (b % 10) = b * (a % 10)) then
            true
        elif (a / 10 = b % 10 && a * (b / 10) = b * (a % 10)) then
            true
        elif (a % 10 = b / 10 && a * (b % 10) = b * (a / 10)) then
            true
        else
            false
    [10..99] |> List.allPairs [10..99] |> List.filter (fun (a,b) -> a < b && filterFunc a b) |>
    List.reduce (fun (f,s) (a,b) -> (f * a, s * b)) |> (fun (num, den) -> den / (gcd num den))

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult ())
    0 // return an integer exit code