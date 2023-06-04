open System

let rec gcd a b =
    if (b = 0) then 
        a
    else
        gcd b (a % b)

let getMaxDiv num div =
    let rec helpFunc num div prevIter =
        if (num = 0) then
            -1
        else
            let r = gcd num div
            let newNum = num / r
            let newDiv = div / r
            let ind = List.tryFindIndex (fun (a,b) -> a = newNum && b = newDiv) prevIter
            if (ind = None) then
                let newNumR = (newNum * 10) % newDiv
                let newList = List.append prevIter [(newNum, newDiv)]
                helpFunc newNumR newDiv newList
            else
                (List.length prevIter) - (Option.get ind)
    helpFunc num div []

let getResult numb =
    [1..numb] |> List.maxBy (fun x -> getMaxDiv 1 x)

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 1000)
    0 // return an integer exit code