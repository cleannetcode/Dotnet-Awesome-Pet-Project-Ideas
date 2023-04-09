// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let isPrime numb =
    let rec helpFunc i numb =
        if (i * i > numb) then
            true
        elif (numb % i = 0) then
            false
        else
            helpFunc (i + 1) numb
    helpFunc 2 numb

let getLargestPrimeFactor numb =
    let rec helpFunc i numb =
        if (i >= numb) then
            numb
        elif (numb % i = 0L) then
            helpFunc i (numb / i)
        else
            helpFunc (i + 1L) numb
    helpFunc 2L numb

[<EntryPoint>]
let main argv =
    let result = getLargestPrimeFactor 600851475143L
    printfn "%d" result
    0