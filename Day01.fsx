#load "Utils.fs"
open Utils

let weights =
    read "inputs/d01.txt"
    |> split "\n\n"
    |> Seq.map (split "\n" >> Seq.map int >> Seq.sum)
    |> Seq.sortDescending

weights |> Seq.max |> printf "Part 1: %A\n"
weights |> Seq.take 3 |> Seq.sum |> printf "Part 2: %A\n"
