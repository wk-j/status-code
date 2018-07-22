// Learn more about F# at http://fsharp.org
open System
open Newtonsoft.Json

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    JsonConvert.SerializeObject("aaa") |> printfn "%A"
    0 // return an integer exit code
