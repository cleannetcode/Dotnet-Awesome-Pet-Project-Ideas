// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let isSqrt num =
    let sqrt = (num |> float |> sqrt |> int)
    sqrt * sqrt = num

let getCount max =
    let isTriplet a b =
        let cSqr = a * a + b * b
        let sqrtC = cSqr |> float |> sqrt |> int
        (isSqrt cSqr) && (sqrtC + a + b) = max
    [1..max] |> List.collect (fun x -> [(x + 1)..max] |> List.map (fun y -> (x,y))) |> List.filter (fun (a,b) -> isTriplet a b)

[<EntryPoint>]
let main argv =
    let [a,b] = getCount 1000
    let c = (a * a + b * b) |> float |> sqrt |> int
    printfn "%A" (a * b * c)
    0 // return an integer exit code