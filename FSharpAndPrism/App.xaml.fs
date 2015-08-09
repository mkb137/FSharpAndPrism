namespace FSharpAndPrism.Views

open System
open System.Windows
open System.Windows.Controls
open log4net.Config
open FsXaml

type App' = XAML<"App.xaml", true>

type App() =
    inherit App'()
    let logger = log4net.LogManager.GetLogger( "FSharpAndPrism.Views.App" )
    do
        let onStartup( args ) =
            logger.Debug "onStartup"
            let bootstrapper = new Bootstrapper()
            bootstrapper.Run()
        base.Root.Startup.Add( onStartup )
    member this.OnStartup( args ) =
        logger.Debug "OnStartup"
        let bootstrapper = new Bootstrapper()
        bootstrapper.Run()
    member this.Run() =
        this.Root.Run()