// Assignment 3
// Dakota, Andrew, Nathan

open System

printfn "Enter names seperated by spaces: "
let stringOfNames = Console.ReadLine()
printfn "The string entered is: %A" stringOfNames

// Convert string to array
let listOfNames = stringOfNames.Split(" ")

printfn "The list is %A" listOfNames

// Convert array to list and sort
let listOfNamesSorted = List.ofArray(Array.sort(listOfNames))
printfn "The sorted list is %A" listOfNamesSorted

// Write to file
// https://docs.microsoft.com/en-us/dotnet/fsharp/
System.IO.File.WriteAllLines("SortedNames.txt", listOfNamesSorted)

printfn "Press any key to exit: "

Console.ReadKey() |> ignore


