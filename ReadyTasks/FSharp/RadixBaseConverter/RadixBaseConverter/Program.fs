open System

// Define a function to construct a message to print
let getRadix num radix =
    let alphabet = "0123456789ABCDEF"

    if (num = 0) then
        "0"
    else
        let rec numToList num radix =  
            if (num = 0) then
                [0]
            else
                (num % radix) :: (numToList (num / radix) radix)
        let absNum = num |> abs
        let str = (numToList absNum radix) |> List.map (fun ind -> alphabet.[ind]) |> List.rev |> String.Concat
        let newStr = str.TrimStart('0')
        if (num < 0) then
            "-" + newStr
        else
            newStr

[<EntryPoint>]
let main argv =
    Console.Write("Write number: ")
    let value = Console.ReadLine() |> int
    Console.Write("Write radix: ")
    let radix = Console.ReadLine() |> int

    printfn "The number %d in radix %d is equal to %s" value radix (getRadix value radix)
    Console.ReadKey()
    0 // return an integer exit code