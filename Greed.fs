module Greed

let GreedScore (dices) : int = 
    let results = dices |> Seq.countBy id |> Seq.toList 
    match results.Item(0) with
    | (1, 1) -> 100
    | (1, 3) -> 1000
    | (x, 3) -> x * 100
    | (5, 1) -> 50
    | _ -> 0