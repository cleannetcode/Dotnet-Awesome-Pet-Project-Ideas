open System

let getFizzBuzzElem (numb: int) =
    if (numb % 15 = 0) then
        "FizzBuzz"
    elif (numb % 5 = 0) then
        "Buzz"
    elif (numb % 3 = 0) then
        "Fizz"
    else
        numb.ToString()

let getFizzBuzzElemByMatch (numb: int) =
    match numb with
    | a when a % 15 = 0 -> "FizzBuzz"
    | a when a % 3 = 0 -> "Fizz"
    | a when a % 5 = 0 -> "Buzz"
    | a -> a.ToString()

let getFizzBuzzSeq () =
    Seq.initInfinite (fun x -> x + 1) |> Seq.map getFizzBuzzElemByMatch

[<EntryPoint>]
let main argv =
    getFizzBuzzSeq () |> Seq.take 10 |> Seq.iter (printfn "%s")
    0 // return an integer exit code