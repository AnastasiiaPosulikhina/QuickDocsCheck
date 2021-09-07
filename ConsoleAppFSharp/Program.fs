// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
                sprintf "from %s" whom

let foo (a: int) (b: double): decimal = decimal a + decimal b

[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    printfn "Hello world %s" message
    foo
    foo
    foo
    foo
    0 // return an integer exit code