open System

let getCharacterCount (text: string) =
    let arr = text.ToCharArray()
    arr |> Array.distinct |> Array.map (fun x -> (x, Array.filter (fun y -> y = x) arr |> Array.length)) |> Map

[<EntryPoint>]
let main argv =
    Console.Write("Write text: ")
    let str = Console.ReadLine()
    let mapStr = str |> getCharacterCount
    Console.WriteLine("Character count: ")
    mapStr |> Map.iter (fun key value -> printfn "%c: %d" key value)
    0 // return an integer exit code