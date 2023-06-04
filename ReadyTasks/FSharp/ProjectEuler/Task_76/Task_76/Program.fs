open System

let getResult numb =
    let nums = Array.zeroCreate (numb + 1)
    nums.[0] <- 1
    for i in {1..numb} do
        for j in {i..numb} do
            nums.[j] <- nums.[j] + nums.[j - i]
    nums.[numb] - 1

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 100)
    0 // return an integer exit code