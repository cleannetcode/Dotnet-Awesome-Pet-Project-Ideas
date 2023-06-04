open System

let getResult maxP =
    let isIntegerRightTriangle a b =
        let c = (a * a + b * b) |> double |> sqrt |> int
        (a * a + b * b) = c * c && (a + b + c) <= maxP
    [1..(maxP - 1)] |> List.collect (fun a -> [(a + 1)..maxP] |> List.map (fun b -> (a, b))) |>
    List.filter (fun (a,b) -> (isIntegerRightTriangle a b)) |> List.map (fun (a,b) -> (a,b,(a * a + b * b) |> double |> sqrt |> int)) |>
    List.countBy (fun (a,b,c) -> a + b + c) |> List.maxBy (fun (_,a) -> a)
    

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 1000)
    0 // return an integer exit code