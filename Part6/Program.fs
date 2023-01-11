// Print the list of users that completed courses
// Note: I worked out other examples in VSCode, but this one in VS.

open FSharp.Data

type courseData = CsvProvider< @"Data/Courses.csv" >

let printOptionalCourse(courseUser : courseData.Row option) =
    match courseUser with
    | Some(u) -> u.FirstName
    | None -> "not found"

let printUser (courseUser : courseData.Row) = 
    printfn $"%s{courseUser.LastName}, %s{courseUser.FirstName}"

let printFirstUser (myCourses : courseData) =
    myCourses.Rows 
    |> Seq.head
    |> printUser

let printUsersThatCompletedCourses (myCourses : courseData) =
    myCourses.Rows
    |> Seq.filter (fun u -> u.CompletionPercentage > 0.95M) // 95% is basically complete, right?
    |> Seq.distinctBy (fun u -> u.FirstName + u.LastName)
    |> Seq.sortBy (fun u -> u.LastName)
    |> Seq.iter (fun u -> printUser u)

let myUsers = courseData.GetSample()

//printFirstUser myCourses
printUsersThatCompletedCourses myUsers

//System.Console.ReadKey() |> ignore
