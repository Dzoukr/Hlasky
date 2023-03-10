[<AutoOpen>]
module Nagano98.Client.FelizExtensions

open Feliz

type Html
    with
        static member inline classed fn (cn:string) (elm:ReactElement list) =
            fn [
                prop.className cn
                prop.children elm
            ]
        static member inline divClassed (cn:string) (elm:ReactElement list) = Html.classed Html.div cn elm