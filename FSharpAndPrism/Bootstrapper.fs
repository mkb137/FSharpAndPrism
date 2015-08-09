namespace FSharpAndPrism.Views

open System.Windows
open Microsoft.Practices.Prism.Modularity
open Microsoft.Practices.Prism.UnityExtensions
open Microsoft.Practices.Unity
open Microsoft.Practices.Unity.Configuration
open FSharpAndPrism.Infrastructure
open FSharpAndPrism.Modules.Alpha

type Bootstrapper() =
    inherit UnityBootstrapper()
    let logger = log4net.LogManager.GetLogger "FSharpAndPrism.Program.Bootstrapper"
    override this.CreateShell() = 
        logger.DebugFormat "CreateShell"
        WindowUtils.loadComponent "/FSharpAndPrism;component/Shell.xaml"
    override this.InitializeShell() =
        logger.DebugFormat "InitializeShell"
        base.InitializeShell()
        Application.Current.MainWindow <- ( this.Shell :?> Window )
        Application.Current.MainWindow.Show()
    override this.ConfigureContainer() =
        logger.DebugFormat "ConfigureContainer"
        base.ConfigureContainer()
        this.Container.LoadConfiguration() |> ignore
        this.Container.RegisterInstance( this.Container ) |> ignore
    override this.ConfigureModuleCatalog() =
        logger.DebugFormat "ConfigureModuleCatalog"
        base.ConfigureModuleCatalog()
        let moduleCatalog = this.ModuleCatalog :?> ModuleCatalog
        moduleCatalog.AddModule typedefof<AlphaModule> |> ignore