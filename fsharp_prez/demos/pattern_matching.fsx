module SpaceAge

type Planet = Earth | Mercury | Venus | Mars | Jupiter | Saturn | Uranus | Neptune

let earthAgeInYears seconds = 
    float seconds / float 31557600

let age planet (seconds: int64) = 
    let earthAges = earthAgeInYears seconds
    match planet with
    | Earth -> earthAges
    | Mercury -> earthAges / 0.2408467
    | Venus -> earthAges / 0.61519726
    | Mars -> earthAges / 1.8808158
    | Jupiter -> earthAges / 11.862615
    | Saturn -> earthAges / 29.447498
    | Uranus -> earthAges / 84.016846
    | Neptune -> earthAges / 164.79132 


let (|Odd|Even|) number = 
  if number % 2 = 0 then Even else Odd

match 5 with
| Even -> "Even"
| Odd -> "Odd"
|> printf "%s"



// Pattern matching on collections
let list = ["a1"; "b1"; "c1"]
match list with
| [] -> printf "empty"
| [a] -> printf "just %A" a
| [a; b] -> printf "two elements beginning with %A" a
| a::tail -> printf "many elements beginning with %A" a

// Pattern matching on records
type Person = { FirstName: string; LastName: string; Age: int }
let person = { FirstName="Marcin"; LastName="Golenia"; Age = 30 }
match person with 
| { FirstName="Marcin" }  -> printfn "Matched Marcin" 
| _  -> printfn "Other guy" 