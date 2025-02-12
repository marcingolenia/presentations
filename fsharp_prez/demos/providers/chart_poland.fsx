#r "nuget: XPlot.GoogleCharts"
#r "nuget: Fsharp.Data"

open FSharp.Data
open XPlot.GoogleCharts;

let data = WorldBankData.GetDataContext()

data.Countries.Poland
    .Indicators.``Carbon dioxide (CO2) emissions from Power Industry (Energy) (Mt CO2e)``
      |> Chart.Line
      |> Chart.WithTitle "CO2 emissions"
      |> Chart.WithYTitle "Metric tons"
      |> Chart.WithXTitle "Year"
      |> Chart.Show