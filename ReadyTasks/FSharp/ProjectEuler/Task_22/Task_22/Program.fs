open System
open System.IO

let getNameScore (name: string) =
    name |> Seq.filter Char.IsLetter |> Seq.map (fun x -> (int)x - (int)'A' + 1) |> Seq.sum

let getResult (names: string []) =
    names |> Array.mapi (fun i x -> (i + 1) * (getNameScore x)) |> Array.sum

[<EntryPoint>]
let main argv =
    let fileName = @"C:\Users\Daniel\OneDrive\Рабочий стол\Elements.txt"
    let names = File.ReadAllText(fileName).Split(',') |> Array.map (fun x -> x.Substring(1, x.Length - 2)) |> Array.sort
    printfn "%A" (getResult names)
    0 // return an integer exit code