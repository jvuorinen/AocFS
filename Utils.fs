module Utils

let read = System.IO.File.ReadAllText
let split (sep: string) (s: string) = s.Split(sep)

let inline charToInt c = int c - int '0'

// Seq operations
let diff seq =
    seq |> Seq.windowed 2 |> Seq.map (fun s -> s[1] - s[0])

let cumMax start seq =
    seq |> Seq.scan (fun mx x -> max mx x) start


// Array ops
let row i (arr: 'T[,]) = arr.[i, *]
let col j (arr: 'T[,]) = arr.[*, j]

let getRows (arr: 'T[,]) =
    Seq.unfold
        (fun i ->
            match i with
            | x when x < arr.GetLength(0) -> Some(row i arr, i + 1)
            | _ -> None)
        0

let getCols (arr: 'T[,]) =
    Seq.unfold
        (fun i ->
            match i with
            | x when x < arr.GetLength(1) -> Some(col i arr, i + 1)
            | _ -> None)
        0
