// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System

[<EntryPoint>]
let main argv = 
    printfn "Please enter first number"
    let firstNumber = Console.ReadLine()
    printfn "Please enter second number"
    let secondNumber = Console.ReadLine()
    let sum = Convert.ToInt32( firstNumber )+ Convert.ToInt32(secondNumber)
    printfn("Sum is %A") sum
    Console.ReadLine() |> ignore
    0 // return an integer exit code
