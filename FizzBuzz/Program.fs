// Learn more about F# at http://fsharp.org

open System

let isDivisibleBy number by =
    number % by = 0

let isFizz number =
    isDivisibleBy number 3

let isBuzz number =
    isDivisibleBy number 5

let fizzBuzz number =
    let fizz = isFizz number
    let buzz = isBuzz number
    
    if (fizz && buzz) then
        "FizzBuzz"
    elif (fizz) then
        "Fizz"
    elif (buzz) then
        "Buzz"
    else
        string number

let fizzBuzzList (number: string) =
    try
        let newNumber = number |> int
        if newNumber<1 then
            raise(new System.ArgumentOutOfRangeException(""))

        [1..newNumber]
            |> List.map (fun n -> (fizzBuzz n))
            |> String.concat "\n"
    with
        | :? System.FormatException ->
            printfn "%s" "Invalid number!"
            reraise()
        | :? System.ArgumentOutOfRangeException ->
            printfn "%s" "Number must be positive"
            reraise()
        | _ ->
            printfn "%s" "Something went wrong"
            reraise()

[<EntryPoint>]

let main argv =
    printf "%s" "Enter an integer, please: "
    let input = Console.ReadLine()

    try
        printfn "%s" ( fizzBuzzList input )
    with
        | _ -> ()
    0
