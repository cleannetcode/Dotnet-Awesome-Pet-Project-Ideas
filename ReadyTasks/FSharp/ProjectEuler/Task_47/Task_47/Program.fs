open System

let getPrimeDivsCount numb =
    let rec getDiv numb div =
        if (numb % div > 0) then
            numb
        else
            getDiv (numb / div) div

    let rec helpFunc numb ind =
        if (numb = 1) then
            0
        else if (ind * ind > numb) then
            1
        else if (numb % ind = 0) then
            let newNumb = getDiv numb ind
            1 + helpFunc newNumb (ind + 1)
        else
            helpFunc numb (ind + 1)
    helpFunc numb 2
        
let getResult numb =
    let filterFunc n =
        [n..(n + numb - 1)] |> List.forall (fun x -> getPrimeDivsCount x = numb)
    Seq.initInfinite (fun x -> x + 1) |> Seq.filter filterFunc

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 4)
    0 // return an integer exit code