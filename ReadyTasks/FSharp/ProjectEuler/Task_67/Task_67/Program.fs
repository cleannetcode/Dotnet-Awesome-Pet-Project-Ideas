open System
open System.IO

let readArray (pathToFile: string) =
    let lines = File.ReadAllLines(pathToFile)
    lines |> Array.map (fun x -> x.Trim().Split(' ') |> Array.filter (fun x -> x.Length > 0) |> Array.map int)

let getResult array =
    let length = array |> Array.last |> Array.length |> (fun x -> x - 1)
    let copy = array |> Array.map (fun x -> x)
    for i in [(length - 1)..(-1)..0] do
        let arr = [|1..(Array.length copy.[i + 1] - 1)|] |> Array.map (fun ind -> max copy.[i + 1].[ind] copy.[i + 1].[ind - 1])
        for j in [0..(Array.length copy.[i] - 1)] do
            copy.[i].[j] <- copy.[i].[j] + arr.[j]
    copy.[0].[0]

[<EntryPoint>]
let main argv =
    let pathToFile = @"C:\Users\Daniel\OneDrive\Рабочий стол\Elements.txt"
    printfn "%A" (pathToFile |> readArray |> getResult)
    0 // return an integer exit code