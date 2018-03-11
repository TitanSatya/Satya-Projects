// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System

[<EntryPoint>]
let main argv = 
    printfn "Please select math operation you want to perform"
    printfn "1. Addition"
    printfn "2. Substraction"
    printfn "3. Multipication"
    printfn "4. Division"
    let operation = Console.ReadLine()
    printfn "Please enter first number"
    let firstNumber = Console.ReadLine()
    printfn "Please enter second number"
   
    let _secondNumber = Console.ReadLine()
    printfn "Processing Result"
    printfn "----------------------------------------------------------------------"
    let _result  =
                if operation = "1" 
                then      (Convert.ToInt32( firstNumber )+ Convert.ToInt32(_secondNumber))
  
                elif operation = "2"
                then     Convert.ToInt32( firstNumber ) - Convert.ToInt32(_secondNumber)
                else 0  
    printfn "Result is %A" _result
    Console.ReadLine() |> ignore
    0 // return an integer exit code
