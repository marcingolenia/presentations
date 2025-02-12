type Planet = Earth | Mercury | Venus | Mars | Jupiter | Saturn | Uranus | Neptune

let earthAgeInYears seconds = 
    float seconds / float 31_557_600

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

printf "Age is:%.2f" (age Venus 31_557_600)


let (|Odd|Even|) number = 
  if number % 2 = 0 then Even else Odd

match 5 with
| Even -> "Even"
| Odd -> "Odd"
|> printf "%s\n"



// Pattern matching on collections
let list = ["a1"; "b1"; "c1"]
match list with
| [] -> printf "empty"
| [a] -> printf "just %A" a
| [a; b] -> printf "two elements beginning with %A\n" a
| a::tail -> printf "many elements beginning with %A\n" a

// Pattern matching on records
type Person = { FirstName: string; LastName: string; Age: int }
let person = { FirstName="Marcin"; LastName="Golenia"; Age = 30 }
match person with 
| { FirstName="Marcin" }  -> printfn "Matched Marcin\n" 
| _  -> printfn "Other guy" 

// Pattern matchin on list with records
let listWithRecords = [person; { FirstName="Adam"; LastName="Test"; Age = 22 }]
match listWithRecords with 
| [{ Age = 30 }; _] -> printf "There is a guy 30 years old in the 1st place!\n"
| _ -> printf "There is no guy 30 years old\n"