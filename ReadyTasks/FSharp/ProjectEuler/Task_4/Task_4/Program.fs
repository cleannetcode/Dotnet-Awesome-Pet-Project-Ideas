open System

let getReverseNumb n =
    let rec helpFunc numb res =
        if (numb = 0) then
            res
        else
            helpFunc (numb / 10) (res * 10 + numb % 10)
    helpFunc n 0

let isPallindrome numb =
    numb = (getReverseNumb numb)

let getMaxPallindromeProduct digitNumb =
    let min = pown 10 digitNumb
    let max = (pown 10 (digitNumb + 1)) - 1
    [min..max] |> List.allPairs [min..max] |> List.map (fun (a,b) -> a * b) |> List.filter isPallindrome |> List.max

[<EntryPoint>]
let main argv =
    let result = getMaxPallindromeProduct 2
    printfn "%d" result
    0 // return an integer exit code