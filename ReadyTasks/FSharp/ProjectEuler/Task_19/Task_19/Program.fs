open System

let getFirstSundaysInMonth (startDate: DateTime) (endDate: DateTime) =
    let filterFunc (date: DateTime) =
        date.DayOfWeek = DayOfWeek.Sunday
    Seq.initInfinite (fun i -> startDate.AddMonths(i)) |> Seq.takeWhile (fun date -> date <= endDate) |>
    Seq.filter filterFunc |> Seq.length

[<EntryPoint>]
let main argv =
    printfn "%A" (getFirstSundaysInMonth (new DateTime(1901,1,1)) (new DateTime(2000,12,31)))
    0 // return an integer exit code