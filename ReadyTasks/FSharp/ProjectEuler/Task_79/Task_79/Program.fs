open System
open System.IO

let str = "319
680
180
690
129
620
762
689
762
318
368
710
720
710
629
168
160
689
716
731
736
729
316
729
729
710
769
290
719
680
318
389
162
289
162
718
729
319
790
680
890
362
319
760
316
729
380
319
728
716"

let getResult triplets =
    let letters = triplets |> List.collect (fun x -> x |> List.ofSeq) |> List.distinct
    let isValidForTriplet (passed: string) (letter: char) (tripl: string) =
        let ind = tripl.IndexOf(letter)
        if (ind = -1) then
            true
        else
            {0..(ind - 1)} |> Seq.forall (fun x -> Seq.contains tripl.[x] passed)

    let determineLetter (passed: string) (letter: char) =
        triplets |> List.forall (isValidForTriplet passed letter)

    let rec helpFunc (passed: string) =
        if ((String.length passed) >= (List.length letters)) then
            passed
        else
            let newLetter = letters |> List.find (fun x -> not (Seq.contains x passed) && (determineLetter passed x))
            helpFunc (passed + newLetter.ToString())

    helpFunc ""

[<EntryPoint>]
let main argv =
    let triplets = str.Split("\013\010") |> List.ofArray
    printfn "%A" (getResult triplets)
    0 // return an integer exit code