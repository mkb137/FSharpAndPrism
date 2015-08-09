namespace FSharpAndPrism.Modules.Alpha

open Microsoft.Practices.Unity
open Microsoft.Practices.Prism.Modularity
open Microsoft.Practices.Prism.Regions
open FSharpAndPrism.Infrastructure
open FSharpAndPrism.Modules.Alpha.Views
  
type AlphaModule( regionManager : IRegionManager, container : IUnityContainer ) =
    let logger = log4net.LogManager.GetLogger( "FSharpAndPrism.Modules.Alpha.AlphaModule" )
    interface IModule with
        member this.Initialize() =
            logger.DebugFormat "Initialize"
            //container.RegisterType<MyView>( new InjectionConstructor() ) |> ignore
            //container.RegisterType( typedefof<MyView'>, new InjectionConstructor() ) |> ignore - uncommenting will cause "FS2024: Static linking may not use assembly that targets different profile."
            regionManager.RegisterViewWithRegion( RegionNames.MainRegion, typedefof<MyView> ) |> ignore            
    

