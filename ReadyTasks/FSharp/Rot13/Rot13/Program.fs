open System

let rotateLetter (rotation: int) (letter: char) =
    let alphabet = "abcdefghijklmnopqrstuvwxyz"
    let ind = alphabet.IndexOf(letter) + rotation
    let newInd = ind % alphabet.Length
    alphabet.[newInd]

let rotateString (rotation: int) (text: string) =
    text |> String.map (rotateLetter rotation)

let rot13 = rotateString 13

[<EntryPoint>]
let main argv =
    Console.Write("Write text: ")
    let text = Console.ReadLine()

    Console.Write("Rotated text: ")
    Console.WriteLine(text |> rot13)

    Console.Write("Rotated twice text: ")
    Console.WriteLine(text |> rot13 |> rot13)
    0 // return an integer exit code