#r "nuget: XPlot.GoogleCharts"
#r "nuget: Fsharp.Data"

open FSharp.Data
open XPlot.GoogleCharts;

type WorldBank = WorldBankDataProvider<"World Development Indicators", Asynchronous=true>
let data = WorldBank.GetDataContext()

type Chart = 
 static member EntitleCo2 =  
    Chart.WithTitle "CO2 emissions" >> Chart.WithYTitle "Metric tons" >> Chart.WithXTitle "Year"

let countries = [data.Countries.``Poland``; data.Countries.``Germany``]
countries
  |> Seq.map(fun country -> country.Indicators.``Carbon dioxide (CO2) emissions from Power Industry (Energy) (Mt CO2e)``) 
  |> Async.Parallel 
  |> Async.RunSynchronously
  |> Chart.Line
  |> Chart.WithLabels (countries |> Seq.map(fun country -> country.Name))
  |> Chart.EntitleCo2
  |> Chart.Show
