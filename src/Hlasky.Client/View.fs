module Hlasky.Client.View

open System
open Browser.Types
open Fable.Core
open Feliz
open Feliz.DaisyUI
open Router
open Feliz.UseElmish
open Elmish

type Msg =
    | UrlChanged of Page

type State = {
    Page : Page
}

let init () =
    let nextPage = Router.currentPath() |> Page.parseFromUrlSegments
    { Page = nextPage }, Cmd.navigatePage nextPage

let update (msg:Msg) (state:State) : State * Cmd<Msg> =
    match msg with
    | UrlChanged page -> { state with Page = page }, Cmd.none

let private soundcard (currentPage:Page) (page:Page) (name:string) (logo:string) =
    let active = if currentPage = page then "bg-slate-100" else ""
    Html.a [
        yield! prop.hrefRouted page
        prop.children [
            Daisy.card [
                card.compact
                prop.className $"w-28 h-28 lg:w-36 lg:h-36 border shadow-xl hover:bg-slate-100 {active}"
                prop.children [
                    Html.figure [
                        prop.className "p-2"
                        prop.children [ Html.img [ prop.className "h-full"; prop.src logo ] ]
                    ]
                    Daisy.cardBody [
                        Html.divClassed "flex flex-col grow justify-center items-center font-medium" [
                            Html.text name
                        ]
                    ]
                ]
            ]
        ]
    ]

[<ReactComponent>]
let AppView () =
    let state,dispatch = React.useElmish(init, update)
    let year = DateTimeOffset.Now.Year

    let content =
        Html.divClassed "flex flex-col items-center gap-4 h-screen" [

            Html.divClassed "flex gap-2 my-4" [
                soundcard state.Page Page.Index "Nagano 98" "./nagano98/logo.png"
                soundcard state.Page Page.BrnoDorost "Dorost Brno" "./brno-dorost/logo.png"
                soundcard state.Page Page.BrnoMhd "MHD Brno" "./brno-mhd/logo.webp"
            ]

            Html.divClassed "grow" [
                match state.Page with
                | Index -> Pages.Nagano98.Nagano98View()
                | BrnoDorost -> Pages.BrnoDorost.BrnoDorostView()
                | BrnoMhd -> Pages.BrnoMhd.BrnoMhdView()
            ]

            Html.divClassed "flex w-full bg-neutral text-neutral-content mt-10" [
                Daisy.footer [
                    prop.className "container mx-auto p-6 lg:p-10"
                    prop.children [
                        Html.div [
                            Html.div $"{year} - Roman Provazník"
                            Html.div "F# + Fable + React + ❤"
                        ]
                        Html.div [
                            Html.span "Stahuj zdroják na"
                            Daisy.link [
                                link.accent
                                prop.href "https://github.com/Dzoukr/Hlasky"
                                prop.text "github.com/Dzoukr/Hlasky"
                            ]
                        ]
                    ]
                ]
            ]
        ]

    React.router [
        router.pathMode
        router.onUrlChanged (Page.parseFromUrlSegments >> UrlChanged >> dispatch)
        router.children [ content ]
    ]
