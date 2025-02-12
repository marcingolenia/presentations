#r "nuget: Npgsql"
#r "nuget: Fsharp.Data"
#r "nuget: System.Data.SqlClient"
#r "nuget: SQLProvider"

open FSharp.Data.Sql

type sql = SqlDataProvider< 
            ConnectionString = "Host=localhost;User Id=postgres;Password=Strong!Passw0rd;Database=db;Port=5432",
            DatabaseVendor = Common.DatabaseProviderTypes.POSTGRESQL,
            UseOptionTypes = Common.NullableColumnType.OPTION>

let ctx = sql.GetDataContext()
let row = ctx.Public.Students.Create()
row.Age <- 13
row.Id <- 1
row.Name <- "Teodor"
row.Surname <- "idk"
ctx.SubmitUpdates()
let students =
    query {
        for student in ctx.Public.Students do
        where (student.Age > 12)
        select student 
    }
(students |> Seq.head).Name |> printf "First student name is %s"