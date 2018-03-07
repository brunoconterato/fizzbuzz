module Tests

open System
open Xunit
open Program

let testEqual actual expected =
    Assert.Equal(actual, expected)

[<Fact>]
let ``isDivisibleBy Test`` () =
    Assert.False (isDivisibleBy 5 2)
    Assert.False (isDivisibleBy 10 3)
    Assert.True (isDivisibleBy 25 5)
    Assert.True (isDivisibleBy 60 15)

[<Fact>]
let ``isFizz Test`` () =
    Assert.False (isFizz 5)
    Assert.False (isFizz 4)
    Assert.True (isFizz 3)
    Assert.True (isFizz 6)
    Assert.True (isFizz 18)

   
[<Fact>]
let ``isBuzz Test`` () =
    Assert.True (isBuzz 5)
    Assert.False (isBuzz 4)
    Assert.False (isBuzz 3)
    Assert.False (isBuzz 6)
    Assert.True (isBuzz 15)
    Assert.True (isBuzz 10)


[<Fact>]
let ``fizzBuzz Test`` () =
    testEqual (fizzBuzz 4) "4"
    testEqual (fizzBuzz 3) "Fizz"
    testEqual (fizzBuzz 5) "Buzz"
    testEqual (fizzBuzz 30) "FizzBuzz"

[<Fact>]
let ``invalid Input Test`` () =
    Assert.Throws<System.FormatException>(fun () -> ( (fizzBuzzList "") |> ignore))
        |> ignore
    Assert.Throws<System.FormatException>(fun () -> ( (fizzBuzzList "1.5") |> ignore))
        |> ignore
    Assert.Throws<System.ArgumentOutOfRangeException>(fun () -> ( (fizzBuzzList "-2") |> ignore))
        |> ignore