module Tests

open System
open Xunit
open Program

[<Fact>]
let ``My test`` () =
    Assert.True(true)

[<Fact>]
let ``fizzBuzz function test`` () =
    let expected = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz\n16\n17\nFizz\n19\nBuzz"
    // let actual = (main [|"5"|])
    let actual = (fizzBuzz 20)
    Assert.Equal(expected, actual)