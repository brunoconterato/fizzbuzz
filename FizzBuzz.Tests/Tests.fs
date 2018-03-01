module Tests

open System
open Xunit
open Program

[<Fact>]
let ``My test`` () =
    Assert.True(true)

[<Fact>]
let ``fizzBuzz function test 1`` () =
    let expected = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz\n16\n17\nFizz\n19\nBuzz"
    let actual = (fizzBuzz 20)
    Assert.Equal(expected, actual)

[<Fact>]
let ``fizzBuzz function test 2`` () =
    let expected = "1\n2\nFizz\n4\nBuzz"
    let actual = (fizzBuzz 5)
    Assert.Equal(expected, actual)

[<Fact>]
let ``fizzBuzz function test 3`` () =
    let expected = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11"
    let actual = (fizzBuzz 11)
    Assert.Equal(expected, actual)