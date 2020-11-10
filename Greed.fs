module Greed

open System.Runtime

let GreedScore (dices) : int = 
    let diceCountBy = dices |> Seq.countBy id |> Seq.toList 
    match diceCountBy.Item(0) with
    | (1, 1) -> 100
    | (5, 1) -> 50
    | (1, 3) -> 1000
    | (x, y) when y>2 & y<7 -> x * 100 * pown 2 (y-3)
    | _ -> 0