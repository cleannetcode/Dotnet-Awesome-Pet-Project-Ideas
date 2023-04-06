// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let getBMI weight height =
    weight / (height ** 2.0)

[<EntryPoint>]
let main argv =
    Console.Write("Your weight: ")
    let weight = Console.ReadLine() |> double
    Console.Write("Your height: ")
    let height = Console.ReadLine() |> double
    printfn "Hello world %f" (getBMI weight height)
    0 // return an integer exit code