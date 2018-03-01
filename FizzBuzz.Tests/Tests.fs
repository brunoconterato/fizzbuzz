module Tests

open System
open Xunit
open Program

[<Fact>]
let ``My test`` () =
    Assert.True(true)

[<Fact>]
let ``Sum Of Squares`` () =
    let expected = [1; 4; 9; 16; 25; 36; 49; 64; 81; 100]
    let actual = sumOfSquares [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
    Assert.Equal(expected, actual)

[<Fact>]
let ``fizzBuzz test 1`` () =
    let expected = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz\n16\n17\nFizz\n19\nBuzz"
    // let actual = (main [|"5"|])
    let actual = (fizzBuzz 20)
    Assert.Equal(expected, actual)