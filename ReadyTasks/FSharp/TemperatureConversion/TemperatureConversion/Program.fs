open System

type TemperaturesTypes =
    | Celsius
    | Kelvin
    | Fahrenheit

let mapToCelsius = [(TemperaturesTypes.Celsius, fun x -> x); (TemperaturesTypes.Kelvin, fun x -> x - 273.13); 
    (TemperaturesTypes.Fahrenheit, fun x -> 5.0 * (x - 32.0) / 9.0)] |> Map

let mapFromCelsius = [(TemperaturesTypes.Celsius, fun x -> x); (TemperaturesTypes.Kelvin, fun x -> x + 273.13); 
    (TemperaturesTypes.Fahrenheit, fun x -> 1.8 * x + 32.0)] |> Map

let convertTemp fromType toType temp =
    let celsius = temp |> (Map.find fromType mapToCelsius)
    let result = celsius |> (Map.find toType mapFromCelsius)
    result

[<EntryPoint>]
let main argv =
    Seq.initInfinite (fun x -> x |> float) |> Seq.take 10 |> Seq.map (convertTemp TemperaturesTypes.Celsius TemperaturesTypes.Celsius) |> Seq.iter (printfn "%f")
    Seq.initInfinite (fun x -> x |> float) |> Seq.take 10 |> Seq.map (convertTemp TemperaturesTypes.Kelvin TemperaturesTypes.Kelvin) |> Seq.iter (printfn "%f")
    Seq.initInfinite (fun x -> x |> float) |> Seq.take 10 |> Seq.map (convertTemp TemperaturesTypes.Fahrenheit TemperaturesTypes.Fahrenheit) |> Seq.iter (printfn "%f")
    0 // return an integer exit code