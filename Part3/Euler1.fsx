// https://projecteuler.net/problem=1
// Find all multiples of 3 and 5 below 1000

[1..999]
|> List.filter (fun x -> x % 3 = 0 || x % 5 = 0)
|> List.sum

// alt + enter to load into interpreter, should see a result: 233168.