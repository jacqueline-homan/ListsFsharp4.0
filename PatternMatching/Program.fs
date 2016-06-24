open System
open System.IO

let underrated (x:int) =
    match x with
    | 3 -> "Steve Buscemi"
    | 2 -> "Sissy Spacek"
    | 1 -> "John Malkovich"
    | x -> x.ToString()

printfn "Enter a number from 1 to 3 to see the top under-rated actors:"
let user = Console.ReadLine() |> int |> underrated |> printfn "%s" 



["Reed Copsey"; "Jacqueline Homan"]
|> List.iter(fun s -> printfn "Has length %d" s.Length)





[<EntryPoint>]
let main argv = 
    //printfn "%A" argv
    0 // return an integer exit code

