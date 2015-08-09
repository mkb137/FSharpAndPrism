namespace FSharpAndPrism.Modules.Alpha.ViewModels

type MyViewModel() =
    let mutable name: string = null
    member this.Name
        with public get() = name
        and public set value = name <- value
