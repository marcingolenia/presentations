open Falco
open Falco.Routing
open Microsoft.AspNetCore.Builder

let handlePost: HttpHandler = fun ctx -> task {
        let! userJson = ctx |> Request.getJson<{|Name: string; Age: int|}> 
        let message = $"%s{userJson.Name} you are %i{userJson.Age} years old."
        return Response.ofPlainText message ctx
        }

let endpoints =
    [
        get "/" (Response.ofPlainText "Hello World!")
        get "/json" (Response.ofJson {| Name="Maricn"; Age=34 |})
        post "/json" handlePost
    ]

WebApplication.Create().UseRouting().UseFalco(endpoints).Run()
    
    
 //curl -X POST http://localhost:5000/json -d '{"Name":"Whateva","Age":22}'