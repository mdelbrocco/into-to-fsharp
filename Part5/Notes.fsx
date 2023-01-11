// Type Providers
// - dotnet add package FSharp.Data
// Pattern Matching - more idomatic to use this than if statements
// e.g.
//  let printOptionalUser(user: userData.Row option) =
//      match user with 
//      | Some(u) -> u.FirstName
//      | None -> "not found"

