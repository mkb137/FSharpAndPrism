namespace FSharpAndPrism.Modules.Alpha.Views

open FsXaml
open FSharpAndPrism.Modules.Alpha.ViewModels

type MyView' = XAML<"MyView.xaml",true>

type MyView() =
    inherit MyView'()
    new( viewModel : MyViewModel ) as this =
        MyView()
        then
            this.DataContext <- viewModel
