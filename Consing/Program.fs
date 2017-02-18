open System
open System.IO

type DevTeam = { Title : string; Name : string}

let developers = [{ Title = "Senior Developer"; Name = "Reed"}; 
                  { Title = "Mid-Level Developer"; Name = "Jesse"};
                  { Title = "Mid-Level Developer"; Name = "Ethan"};
                  {Title = "Senior Developer"; Name = "Ryan"}; 
                  { Title = "Junior Developer"; Name = "Jacqueline"}]

let newDevelopers = {Title = "Architect"; Name = "Twisted Sister"} :: developers 
printfn "%A" developers
let rec findDeveloper x =
    match x with
    | {Title = "Senior Developer"; Name = x} :: tail -> x
    | _ :: tail -> findDeveloper tail
    | [] -> sprintf "No Senior Developer listed"
printfn "%A" (findDeveloper developers)
printfn "\n"
printfn "Our new list of developers includes %A" newDevelopers
printfn "\n"

let describeList newDevelopers =
    match newDevelopers with
    | [] -> "Empty list"
    | head :: tail -> 
        sprintf "List beginning %A, %i more elements" head tail.Length
printfn "%A" (describeList newDevelopers)

 


[<EntryPoint>]
let main argv = 
    //printfn "%A" argv
    0 // return an integer exit code

