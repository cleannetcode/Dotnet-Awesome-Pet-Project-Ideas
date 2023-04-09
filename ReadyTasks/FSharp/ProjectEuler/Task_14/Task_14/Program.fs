// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let rec getCollatz numb = 
    if (numb = 1L) then
        1L
    else if (numb % 2L = 0L) then
        1L + (getCollatz (numb / 2L))
    else
        1L + (getCollatz ((3L * numb + 1L) / 2L))

let memorise func =
    let cache = new System.Collections.Generic.Dictionary<_,_>()
    fun x -> match cache.TryGetValue x with
    | true, result -> result
    | _ -> let result = func x
           cache.Add(x, result)
           result

let getCollatzMemorised = memorise getCollatz

let getResult numb =
    [1..numb] |> List.map int64 |> List.maxBy getCollatzMemorised

[<EntryPoint>]
let main argv =
    printfn "%d" (getResult 1000000)
    0 // return an integer exit code