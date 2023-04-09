open System
open System.Numerics

[<EntryPoint>]
let main argv =
    printfn "%A" ((28433I * BigInteger.ModPow(2I, 7830457I, 10000000000I) + 1I) % 10000000000I)
    0 // return an integer exit code