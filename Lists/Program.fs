open System
open System.IO 

let rec safeFileSearch startDir =
    let tryEnumerateFiles dir =
        try 
            Directory.EnumerateFiles(startDir)
        with _ -> Seq.empty 
    let tryEnumerateDirs dir =
        try 
            Directory.EnumerateDirectories(startDir) 
        with _ -> Seq.empty 
    [
        yield! tryEnumerateFiles startDir 
        for dir in tryEnumerateDirs startDir do 
            yield! (safeFileSearch dir) 
    ]
let myDocuments startDir=
    startDir
    |> safeFileSearch
    |> List.filter(fun path -> Path.GetExtension(path) = ".odt")

myDocuments @"/home/jacque/Documents" |> Seq.iter(printfn "%A")

let mutable myMutableList = ["Oscar the Grouch"; "Big Bird"; "Snuffalupagus"]
myMutableList <- ["Bert"; "Ernie"; "Cookie Monster"]
printfn "%A" myMutableList


[<EntryPoint>]
let main argv = 
    //printfn "%A" argv
    0 // return an integer exit code

