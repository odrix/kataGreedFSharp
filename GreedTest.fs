
open Greed
open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

[<Test>]
let OneOne_Should_Score100 () =    
    let dices = [1]
    Assert.AreEqual(100, GreedScore(dices))

[<Test>]
let OneFive_Should_Score50 () =    
    let dices = [5]
    Assert.AreEqual(50, GreedScore(dices))

[<Test>]
let ThreeOne_Should_Score1000 () =    
    let dices = [1;1;1]
    Assert.AreEqual(1000, GreedScore(dices))


[<TestCase(2, 200)>]
[<TestCase(3, 300)>]
[<TestCase(4, 400)>]
[<TestCase(5, 500)>]
[<TestCase(6, 600)>]
let ThreeSame_Should_ScoreX100 (dicesValue, expectedScore) =    
    let dices = [for i in 1..3 -> dicesValue]
    Assert.AreEqual(expectedScore, GreedScore(dices))