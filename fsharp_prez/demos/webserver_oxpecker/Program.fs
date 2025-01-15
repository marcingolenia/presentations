open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.DependencyInjection
open Oxpecker

type PersonDto = {Name: string; Age: int}

let handlePost person : EndpointHandler =
    fun (ctx: HttpContext) ->
        let message = $"%s{person.Name} you are %i{person.Age} years old."
        ctx.Write <| TypedResults.Ok person

let endpoints = [
    GET [
        route "/" <| text "Hello World!"
        route "/json" <| json {| Name="Marcin"; Age=34 |}
    ]
    POST [
       route "/json" (bindJson<PersonDto> handlePost)
    ]
]

let builder = WebApplication.CreateBuilder()
builder.Services.AddRouting().AddOxpecker() |> ignore
let app = builder.Build()
app.UseRouting().UseOxpecker(endpoints) |> ignore
app.Run()