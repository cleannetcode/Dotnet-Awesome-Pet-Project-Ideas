open System

let reverseStr (text: string) =
    text |> Seq.rev |> String.Concat

[<EntryPoint>]
let main argv =
    Console.Write("Write string: ")
    let str = Console.ReadLine()
    printfn "Reversed string is %s" <| reverseStr str
    0 // return an integer exit code