// Remember, highlight code then Alt+Enter to send it to interactive

open System

let calcVolume radius =
    Math.Pow(radius, 3) * 4.0/3.0 * Math.PI

let categorizeSphere radius =
    let volume = calcVolume radius
    if volume < 100 then "small"
    else if volume < 1000 then "medium"
    else "large"

let printTheThing radius =
        let value = categorizeSphere radius
        printfn "%s" value // string interpolation similar to C language


let categorizeSomeSpheres num =
    let values = [1..num]: float list
    List.iter printTheThing values

// can do this instead of creating that categorizeSomeSpheres and printTheThing functions!
List.iter (fun r -> printfn "%s" (categorizeSphere(r))) [1..20]