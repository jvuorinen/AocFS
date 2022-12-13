#load "Utils.fs"
open Utils

let halve (str: string) = Seq.chunkBySize (str.Length / 2) str
let getCommon (seq) = Seq.map Set seq |> Seq.reduce Set.intersect |> Seq.item 0
let getValue (c: char) = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(c)

// Entrypoint
let sacks = read "inputs/d03.txt" |> split "\n"

sacks
|> Seq.map (halve >> getCommon >> getValue)
|> Seq.sum
|> printf "Part 1: %A\n"

sacks
|> Seq.chunkBySize 3
|> Seq.map (getCommon >> getValue)
|> Seq.sum
|> printf "Part 2: %A\n"
