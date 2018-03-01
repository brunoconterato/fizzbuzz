// Learn more about F# at http://fsharp.org

open System
open System
open System

let private square x = x * x
let sumOfSquares xs = 
    xs 
    |> Seq.map square

let fizzBuzz n =
    let mutable str = ""
    for i=1 to n do
        if (i % 5 = 0 && i % 3 = 0) then
            str <- str + "FizzBuzz\n"
        elif (i % 3 = 0) then
            str <- str + "Fizz\n"
        elif (i % 5 = 0) then
            str <- str + "Buzz\n"
        else
            str <- str + i.ToString() + "\n"

    str.Remove(str.Length-1)

[<EntryPoint>]

let main argv =
    try
        let input = argv.[0] |> int
        printfn "%s" ( fizzBuzz input )
    with
        | :? System.IndexOutOfRangeException ->
            printfn "Need int argument"
        | :? System.FormatException ->
            printfn "Invalid number!"
        | :? System.ArgumentOutOfRangeException ->
            printfn "Number must be positive"
    0 // return an integer exit code

// let main argv =
//     if argv.Length > 0 then
//         //TODO: tratar exception caso valor entrado não seja inteiro
//         let input = argv.[0] |> int

//         printfn "%s" ( fizzBuzz input )
//     else
//         printfn "Error: null argv"
//     0 // return an integer exit code