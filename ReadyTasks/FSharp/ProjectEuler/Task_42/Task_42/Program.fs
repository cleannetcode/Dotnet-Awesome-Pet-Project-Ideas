open System
open System.IO

let isTriangleNumb numb =
    //x * (x + 1) = 2 * numb => x ^ 2 + x - 2 * numb
    let sqrtD = (1 + 8 * numb) |> double |> sqrt
    let res = (-1.0 + sqrtD) / 2.0
    res % 1.0 = 0.0

let getWordNumb word =
    word |> Seq.map (fun x -> (int)x - (int)'A' + 1) |> Seq.sum

let getResult words =
    words |> Array.map getWordNumb |> Array.filter isTriangleNumb |> Array.length

[<EntryPoint>]
let main argv =
    let pathToFile = @"C:\Users\Daniel\OneDrive\Рабочий стол\Elements.txt"
    let words = File.ReadAllText(pathToFile).Split(',') |> Array.map (fun x -> x.[1..(String.length x - 2)])
    printfn "%A" (words |> getResult)
    0 // return an integer exit code