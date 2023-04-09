open System

let factorial num =
    if (num < 0) then
        failwith "Number must be greater then 0"
    else
        Seq.init num (fun i -> bigint(i + 1)) |> Seq.fold (fun acc i -> acc * i) (1 |> bigint)

[<EntryPoint>]
let main argv =
    Console.Write("Write number: ")
    let numb = (Console.ReadLine >> int)()
    printfn "Factorial of number %i is equal to %A" numb (factorial numb)
    0 // return an integer exit code