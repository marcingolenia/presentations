type Person = { 
    Name: string; 
    Surname: string;
    Age: int
    }

type CompanyHierarchy = Worker of Person | Manager of Person | Cto of Person

let manager = { Name = "Marcin"; Surname = "Golenia"; Age = 30} |> Manager
let cto = { Name = "Stefan"; Surname = "Podolsky"; Age = 30} |> Cto

// Test equality and compare
cto > manager |> printfn "%A is greater than %A: %b" cto manager 
cto = manager |> printfn "%A is equal to %A: %b" cto manager