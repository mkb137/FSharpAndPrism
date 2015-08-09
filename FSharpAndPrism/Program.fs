
open System
open FSharpAndPrism.Views

[<EntryPoint>]
[<STAThread>]
let main argv = 
    printfn "%A" argv
    log4net.Config.XmlConfigurator.Configure() |> ignore
    let app = new App()
    app.Run()

