namespace FSharpAndPrism.Infrastructure

open System
open System.Windows
open System.Windows.Controls

module WindowUtils =

    let loadComponent( path ) =
        let resourceLocator = new Uri( path, UriKind.Relative )
        Application.LoadComponent( resourceLocator ) :?> DependencyObject
        