[<AutoOpen>]
module Hlasky.Client.FelizExtensions

open Router
open Feliz.Router
open Feliz

type prop
    with
        static member inline hrefRouted (p:Page) =
            [
                prop.href (p |> Page.toUrlSegments |> Router.formatPath)
                prop.onClick Router.goToUrl
            ]

type Html
    with
        static member inline a (text:string, p:Page) =
            Html.a [
                yield! prop.hrefRouted p
                prop.text text
            ]
        static member inline classed fn (cn:string) (elm:ReactElement list) =
            fn [
                prop.className cn
                prop.children elm
            ]
        static member inline divClassed (cn:string) (elm:ReactElement list) = Html.classed Html.div cn elm