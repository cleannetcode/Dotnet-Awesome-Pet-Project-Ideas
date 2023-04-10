open System

let factorial numb =
    {1..numb} |> Seq.reduce (fun acc x -> acc * x)

let rec getNumb (letters: string) (ind: int) =
    if (letters.Length = 0) then
        ""
    else if (letters.Length = 1) then
        letters.[0].ToString()
    else
        let fact = (factorial (String.length letters - 1))
        let letterInd = ind / fact
        if (letterInd >= letters.Length) then
            ""
        else
            let letter = letters.[letterInd]
            let newLetters = letters |> String.filter (fun x -> x <> letter)
            letter.ToString() + (getNumb newLetters (ind % fact))

[<EntryPoint>]
let main argv =
    printfn "%A" (getNumb "0123456789" 999999)
    0 // return an integer exit code