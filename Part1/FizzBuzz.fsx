
let GetFizzBuzzValue num =
    if num % 15 = 0 then
        "fizzbuzz"
    else if num % 3 = 0 then
        "fizz"
    else if num % 5 = 0 then
        "buzz"
    else
        num.ToString()

let PrintFizzBuzzValues num =
    let value = GetFizzBuzzValue num
    printfn "%s" value // string interpolation similar to C language

let GetFizzBuzzValues _ =
    let values = [1..20]
    List.iter PrintFizzBuzzValues values

