open System

// Define a function to construct a message to print
let rec collatzSeq (numb: bigint) =
    if (numb = bigint(1)) then
        [bigint(1)]
    else if (numb % bigint(2) = bigint(0)) then
        numb :: (collatzSeq (numb / bigint(2)))
    else
        numb :: (collatzSeq (numb * bigint(3) + bigint(1)))
        

[<EntryPoint>]
let main argv =
    Console.Write("Write number: ")
    let numb = Console.ReadLine() |> bigint.Parse
    printfn "Collatz sequence for number %A: %A" numb (collatzSeq numb)
    0 // return an integer exit code