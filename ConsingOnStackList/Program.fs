open System
open System.IO

type SimpleStack<'T>()= 
    let mutable _stack : List<'T> = []
    member this.Push value =
        lock _stack (fun() ->
            _stack <- value::_stack)

    member this.Pop() =
        lock _stack (fun() -> 
            match _stack with
            | result :: remainder -> 
                _stack <- remainder
                result
            | [] -> failwith "Empty stack"
        )
(*
    member this.TryPop() =
        match _stack with
        | result :: newStack ->
            _stack <- newStack
            result |> Some
        | [] -> None 
*)
    member this.Swap() =
        lock _stack (fun() -> 
            match _stack with
            | a :: b :: tail -> _stack <- b :: a :: tail
            |_ -> failwith "Stack does not have enough elements" 
        )


[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code

