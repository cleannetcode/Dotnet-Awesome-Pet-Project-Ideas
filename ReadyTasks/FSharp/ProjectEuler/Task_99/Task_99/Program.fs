open System
open System.IO

let getResult arr =
    let func [|b; exp|] =
        let pow = b |> double |> log
        let exp = exp |> double
        pow * exp
    arr |> Array.indexed |> Array.maxBy (fun (a,b) -> func b) |> (fun (a,b) -> a + 1)

[<EntryPoint>]
let main argv =
    let file = @"C:\Users\Daniel\OneDrive\Рабочий стол\baseexp.txt"
    let elems = file |> File.ReadAllLines |> Array.map (fun x -> x.Split(',') |> Array.map int)
    printfn "%A" (getResult elems)
    0 // return an integer exit code