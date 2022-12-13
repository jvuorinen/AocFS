#load "Utils.fs"
open Utils


let countVisible start seq = 
    seq |> Seq.scan max start |> diff |> Seq.takeWhile (fun x -> x > 0) |> Seq.length

// Entrypoint
let arr = read "inputs/d08a.txt" |> split "\n" |> array2D |> Array2D.map charToInt




arr |> getCols |> Seq.map (countVisible 0)
arr |> getCols |> Seq.map (Seq.rev >> countVisible 0)
