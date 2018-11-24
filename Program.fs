open System

// Problem #1
let list = [
1
2
3
4
5]

let listSquare (list : int list) = 
    list |> List.map (fun x -> x * x)

printfn "The list %A squared is %A" list (listSquare list)

// Problem #2
let intList = [
1
2
3
4]

let intMap (x:int list) (z:int) =
    x |> List.map (fun x -> x + z)
printfn "Calling intMap with %A and %A yields %A" intList 10 (intMap intList 10)

// Problem #3
let squareSum (list:int list) =
    list |> List.fold(fun acc list -> acc + list * list ) 0
printfn "The sum of the squares of the list %A is %A" list (squareSum list)

// Problem #4
let cumProduct (list:int list) =
    list |> Seq.fold(fun state list -> state * list) 1
printfn "Multiplying all the integers in the list %A results with %A" list (cumProduct list)

// Problem #5
let integerPair = [
(1,3)
(4,2)
(-3,-4)]

let getMaxList (x: (int*int) list) =
    x |> List.map(fun (a,b) -> 
        if a > b then a 
        else b)
printfn "The max elements of the list %A is %A" integerPair (getMaxList integerPair)

// Problem #6
let list6 = [5; 4; 3; 9; 7]
let smallest (x:int list) = 
    List.min x
printfn "The smallest value in the list %A is %A" list6 (smallest list6)

// Problem #7
let list7 = [5; 4; 3; 9; 7]
let largest (x:int list) = 
    List.max x
printfn "The largest value in the list %A is %A" list7 (largest list6)

// Problem #8
type Person(name:string, gpa:double, age:int) = 
    member this.name  = name
    member this.gpa = gpa
    member this.age = age  


let p1 = new Person("Grant", 4.0, 21)
let p2 = new Person("Shaun", 4.0, 22)
let p3 = new Person("Dakota", 4.0, 21)
let p4 = new Person("Paul", 4.0, 21)

let personList = [
p1
p2
p3
p4
]

let avgAge (list:Person list) =
    list |> List.fold(fun acc Person -> acc + Person.age ) 0 

printfn "The average age of the list is %A" ((avgAge personList) / personList.Length)




Console.ReadKey() |> ignore