module Greed

let GreedScore (dices) : int = 
    let diceCountBy = dices |> Seq.countBy id |> Seq.toList 
    match diceCountBy.Item(0) with
    | (1, 1) -> 100
    | (5, 1) -> 50
    | (1, 3) -> 1000
    | (x, 3) -> x * 100
    | (x, 4) -> 2 * x * 100
    | (x, 5) -> 3 * x * 100
    | _ -> 0