// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp


// Define a function to construct a message to print
let from whom =
                sprintf "from %s" whom

/// <summary>
/// foo 
/// </summary>
let foo (a: int) (b: double): decimal = decimal a + decimal b


/// <summary>
/// foo2 
/// </summary>
let foo2 (a: double) (b: double): decimal = decimal a + decimal b

let print tuple1 =
   match tuple1 with
    | (a, b) -> printfn "Pair %A %A" a b
    
let mb = MailboxProcessor.Start(fun (_: MailboxProcessor<string>) -> async.Return ())
mb.PostAndReply
printfn "Hello from F#"

[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    printfn "Hello world %s" message
    foo
    foo
  
    
    0 // return an integer exit code