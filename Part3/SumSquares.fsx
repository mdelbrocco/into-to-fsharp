// Take a list of integers and return the sum of squares of the even numbers.
// e.g. for 1..9 should return 2^2 + 4^2 + 6^2 + 8^2 = 4 + 16 + 36 + 64 = 120

[1..9]
|> List.filter (fun x -> x % 2 = 0)
|> List.map(fun y -> y * y)
|> List.sum

let squareEvenNumbers max =
    [1..max]
    |> List.filter (fun x -> x % 2 = 0)
    |> List.map(fun y -> y * y)
    |> List.sum