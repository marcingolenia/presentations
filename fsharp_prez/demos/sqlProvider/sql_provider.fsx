#r "nuget: Npgsql"
#r "nuget: Fsharp.Data"
#r "nuget: System.Data.SqlClient"
#r "nuget: SQLProvider"

open FSharp.Data.Sql
open System.Data.SqlClient

type sql = SqlDataProvider< 
            ConnectionString = "Host=localhost;User Id=postgres;Password=Secret!Passw0rd;Database=foosball;Port=5432",
            DatabaseVendor = Common.DatabaseProviderTypes.POSTGRESQL,
            UseOptionTypes = Common.NullableColumnType.OPTION>

let db = sql.GetDataContext().Dbo
let students =
    query {
        for student in db.Student do
        where (student.Age >= 10 && student.Age < 25)
        select student // strongly typed
    }
(students |> Seq.head).Name |> printf "First student name is %s"
