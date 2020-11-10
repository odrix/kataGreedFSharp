
open Greed
open NUnit.Framework

//specs: https://codingdojo.org/kata/Greed/

[<TestCase(1, 100, TestName="One one score 100")>]
[<TestCase(5, 50, TestName="One five score 50")>]
[<TestCase(3, 0)>]
let JustOneDice_Should_ScoreSome (dice, expectedScore) =    
    let dices = [dice]
    Assert.AreEqual(expectedScore, GreedScore(dices))

[<Test>]
let ThreeOne_Should_Score1000 () =    
    let dices = [1;1;1]
    Assert.AreEqual(1000, GreedScore(dices))

[<TestCase(2, 200)>]
[<TestCase(3, 300)>]
[<TestCase(4, 400)>]
[<TestCase(5, 500)>]
[<TestCase(6, 600)>]
let ThreeSameDice_Should_ScoreDiceX100 (diceValue, expectedScore) =    
    let dices = [for i in 1..3 -> diceValue]
    Assert.AreEqual(expectedScore, GreedScore(dices))

[<TestCase(2, 400)>]
[<TestCase(6, 1200)>]
let FourSameDice_Should_ScoreDiceX200 (diceValue, expectedScore) =    
    let dices = [for i in 1..4 -> diceValue]
    Assert.AreEqual(expectedScore, GreedScore(dices))

[<TestCase(3, 1200)>]
[<TestCase(4, 1600)>]
let FiveSameDice_Should_ScoreDiceX400 (diceValue, expectedScore) =    
    let dices = [for i in 1..5 -> diceValue]
    Assert.AreEqual(expectedScore, GreedScore(dices))
