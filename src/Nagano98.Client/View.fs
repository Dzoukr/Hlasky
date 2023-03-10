module Nagano98.Client.View

open System
open Browser.Types
open Fable.Core
open Feliz
open Feliz.DaisyUI
open Feliz.UseElmish

//can't be in a method
let [<Global("Audio")>] audioType : Browser.Types.HTMLAudioElementType = jsNative

let private play (track,label:string) =

    Html.div [
        prop.className "flex w-32 h-32 lg:w-40 lg:h-40 items-center text-center justify-center p-4 border shadow cursor-pointer bg-slate-100 hover:bg-slate-300 font-medium"
        prop.children [
            Html.div label
        ]
        prop.onClick (fun _ ->
            let audio = audioType.Create()
            audio.src <- track
            audio.play()
        )
    ]

let private tracks = [
    "./beranek-dej.mp3", "Beránek - dej!"
    "./dominik-chytil-jsme-ve-finale.mp3", "Domink chytil, jsme ve finale!"
    "./dulezity-gol.mp3", "To je důležitý gól!"
    "./existuje-spravedlnost.mp3", "Tak přece jen existuje spravedlnost!"
    "./gol-vedeme-10.mp3", "Gól! Vedeme 1:0!"
    "./hasek-chyta.mp3", "Hašek chytááá!"
    "./hasek-neuveritelne.mp3", "Hašek neuvěřitelně!"
    "./jagr-stale-jagr-gol.mp3", "Jágr, stále Jágr - góoool!"
    "./jsi-pasak-albi.mp3", "Jsi pašák, Albi!"
    "./otevirame-zlatou-branu.mp3", "Otevíráme zlatou bránu!"
    "./pavle-pojd.mp3", "Pavle, pojď!"
    "./prepiste-dejiny.mp3", "Přepište dějiny!"
    "./roy-hasek-premyslive-typy.mp3", "Roy i Hašek jsou přemýšlivé typy."
    "./roy-pateru-nezna.mp3", "Pavel Patera, toho Roy vůbec nezná!"
    "./rucinsky-faulovany.mp3", "Ručinský faulovaný zezadu!"
    "./rucinsky-gol.mp3", "Martin Ručinský - góool!"
    "./shanahan-musi-dat.mp3", "Brandon Shanahan musí dát."
    "./skvele-dominiku.mp3", "Skvěle, skvěle Dominiku!"
    "./slegr-to-nema-dobre.mp3", "Jiří Šlégr to nemá dobré."
    "./takhle-pali-guma.mp3", "Takhle pálí guma!"
    "./vylucuje-pouze-nase.mp3", "Vylučuje pouze naše."
]

[<ReactComponent>]
let AppView () =
    let year = DateTimeOffset.Now.Year
    Html.divClassed "flex flex-col items-center gap-4 h-screen" [
        Html.divClassed "w-64" [
            Html.img [ prop.src "logo.webp" ]
        ]
        Html.divClassed "grid grid-cols-3 lg:grid-cols-7 gap-4" [
            yield!
                tracks
                |> List.map play
        ]

        Html.divClassed "flex w-full grow bg-neutral text-neutral-content mt-10" [
            Daisy.footer [
                prop.className "container mx-auto p-6 lg:p-10"
                prop.children [
                    Html.div [
                        Html.div $"{year} - Roman Provazník"
                        Html.div $"F# + Fable + React + ❤"
                    ]
                    Html.div [
                        Html.span "Stahuj zdroják na"
                        Daisy.link [
                            link.accent
                            prop.href "https://github.com/Dzoukr/Nagano98"
                            prop.text "github.com/Dzoukr/Nagano98"
                        ]
                    ]
                ]
            ]
        ]
    ]
