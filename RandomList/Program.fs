open System
open System.Collections.Generic
open System.IO

type FsharpBoardMembers = { mutable Name : string }

let boardList = 
    [{Name = "Reed Copsey"}; {Name = "Franken Stine"}]    

boardList.[1].Name <- "Don Syme"
//printfn "%A" boardList

//generates a list of random numbers and takes only the first two elements

let randomList n =
    let r = Random() 
    List.init n  (fun _ -> r.Next())
randomList 5 |> List.take 2 |> printfn "\n %A"

let randomSeq n =
    let r = Random()
    Seq.init n (fun _ -> r.Next())
randomSeq 5 |> Seq.take 2 |> printfn "\n %A"

let randomArray n =
    let r = Random()
    Array.init n (fun _ -> r.Next())
randomArray 5 |> Array.take 2 |> printfn "\n %A"

printfn "\n\n\n"
//creates a list of 100 zeros and prints them out
let myNumbers n = [ for i in 2..10 -> n * (i*n * (n - 1))]
myNumbers 1
|> List.iter(printfn "%A" )

let animals = 
    [| 
        [|"cat"|]
        [|"dog"|]
        [|"mouse"|]
    |]
    |> Array.map(fun x -> 
        match x with
        | [|"dog"|] -> [|"bird"|]
        | _ -> x)
    |> Array.toList
    |> List.iter(printfn "%A")
//printfn "%A" animals

[<EntryPoint>]
let main argv = 
    //printfn "%A" argv
    0 // return an integer exit code

