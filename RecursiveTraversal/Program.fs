open System
open System.IO
// Tail-recursive Fibonnaci function
let tailfib n =
    let rec tail n1 n2 = function
    | 0 -> n1
    | n -> tail n2 (n2 + n1) (n - 1)
    tail 0 1 n

// Recursive List traversal
let partitionList predicate input =
    let rec loop acc list =
        match list with
        | head::tail when predicate head -> acc, head::tail
        | head::tail -> loop(head::acc) tail
        | [] -> input, []
    loop [] input
[7;8;9;10;11;12;13;14;15] |> partitionList(fun x -> x > 10) |> printfn "%A"

let splitUpList predicate input =
    let rec loop acc list =
        match list with
        |head::tail when predicate head -> List.rev acc, head::tail
        |head::tail -> loop(head::acc) tail
        | []-> input, []
    loop [] input
["Jefferson Airplane"; "Creedence Clearwater Revival"; "Andy Gibb"; "Linda Ronstadt"]
|> splitUpList(fun x -> x = "Linda Ronstadt")
|> printfn "%A"
    
let list1 = [3;2;1]
let list2 = 4::list1
match list2 with
| head::tail -> printfn "%b" (obj.ReferenceEquals(tail, list1))
|_ -> ()

(*
let list = [2;1;4;3]

let rec arraySort x =
   match x with
   | [] -> []
   |[x] -> [x]
   |x0::x1 when x>x1 && (x0-x1 = 1) ->[x0] @ [x0]@(arraySort x)
   |x0::x1 -> [x0] @ (arraySort x)
*)
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code

