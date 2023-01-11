// |> is super useful: the "pipe forward operator"
//   customer
//   |> upgradeCustomer
//   |> should equal unexpected
// F# |> I <3

// Pure functions

type Person = { Name: string; Age: int }

let Paul = { Name = "Paul"; Age = 28 }
let David = {Paul with Name = "David" }
