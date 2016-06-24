open System
open System.IO

let dirSizePiped dir =
    let getFiles dirr =
        Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories)
    dir
    |> getFiles
    |> Array.map (fun file -> new FileInfo(file))
    |> Array.map (fun info -> info.Length)
    |> Array.sum
dirSizePiped @"/home/jacque/Documents"|> printfn "%A"


let dirSizeComposed = (*No Parameters!*) 
    let getFiles dir =
        Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories)
    getFiles
    >> Array.map (fun file -> new FileInfo(file))
    >> Array.map (fun info -> info.Length)
    >> Array.sum
dirSizeComposed @"/home/jacque/Documents"|> printfn "%A"


let square x = x * x
let toString (x : int) = x.ToString()
let strLen (x : string) = x.Length
let lenOfSquare = square >> toString >> strLen
lenOfSquare 4 |> printfn "%i" 

let cubes x = x * x * x
let to_String (x:int) = x.ToString()
let strgLen (x:string) = x.Length
let lenOfCubes = cubes >> to_String >> strgLen
cubes 4 |> printfn "%i"
lenOfCubes 4 |> printfn "%i"



let homesForSale() =
    let threeMonths = [ 10.0; 22.0; 19.0]
    threeMonths
    |> List.average
    |> printfn "First quarter average: %f"
    printfn "Three month average: %f" <| List.average threeMonths

homesForSale() 



[<EntryPoint>]
let main argv = 
    //printfn "%A" argv
    0 // return an integer exit code

