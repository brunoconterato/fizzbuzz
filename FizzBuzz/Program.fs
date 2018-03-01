// Learn more about F# at http://fsharp.org

open System
open System
open System

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
        printf "%s" "Enter an integer, please: "
        let input = Console.ReadLine() |> int
        printfn "%s" ( fizzBuzz input )
    with
        | :? System.FormatException ->
            printfn "Invalid number!"
        | :? System.ArgumentOutOfRangeException ->
            printfn "Number must be positive"
        | _ -> printfn "Something went wrong"
    0 // return an integer exit code