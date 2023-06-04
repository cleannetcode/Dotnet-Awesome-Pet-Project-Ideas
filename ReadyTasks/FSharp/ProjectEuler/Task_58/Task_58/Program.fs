open System

let isPrime numb =
    if (numb < 2I) then
        false
    else
        Seq.initInfinite (fun x -> bigint(x) + 2I) |> Seq.takeWhile (fun x -> x * x <= numb) |> Seq.forall (fun x -> numb % x > 0I)

let getSpiralNumbers numb =
    if (numb = 0) then
        [1I]
    else
        let x = numb |> bigint
        let a = 4I * x * x + 4I * x + 1I
        let b = 4I * x * x + 2I * x + 1I
        let c = 4I * x * x + 1I
        let d = 4I * x * x - 2I * x + 1I
        [d; c; b; a]

let getResult (numb, den) =
    let rec helpFunc n (a,b) =
        if (a > 0 && a * den < b * numb) then
            2 * n - 1
        else
            let nums = getSpiralNumbers n
            let newB = b  + (nums |> List.length)
            let newA = a + (nums |> List.filter isPrime |> List.length)
            (helpFunc (n + 1) (newA, newB))
    helpFunc 0 (0,0)

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult (10, 100))
    0 // return an integer exit code