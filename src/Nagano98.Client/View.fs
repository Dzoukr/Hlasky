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
        prop.className "flex w-28 h-28 lg:w-40 lg:h-40 items-center text-center justify-center p-4 border shadow cursor-pointer bg-slate-100 hover:bg-slate-300 font-medium"
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
    "./dominik-chytil-jsme-ve-finale.mp3", "Dominik chytil, jsme ve finale!"
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
    "./roy-pateru-nezna.mp3", "Patera, toho Roy vůbec nezná!"
    "./rucinsky-faulovany.mp3", "Ručinský faulovaný zezadu!"
    "./rucinsky-gol.mp3", "Martin Ručinský - góool!"
    "./shanahan-musi-dat-long.mp3", "Brandon Shanahan musí dát."
    "./skvele-dominiku.mp3", "Skvěle, skvěle Dominiku!"
    "./slegr-to-nema-dobre.mp3", "Jiří Šlégr to nemá dobré."
    "./takhle-pali-guma.mp3", "Takhle pálí guma!"
    "./vylucuje-pouze-nase.mp3", "Vylučuje pouze naše."
]

let private bonuses = [
    "./bonus/brambory-zapomente.mp3", "Brambory zapomeňte!"
    "./bonus/budes-bydlet-v-tvaroharne.mp3", "Budeš bydlet v tvarohárně!"
    "./bonus/co-mne-je-po-tom-kurva.mp3", "Co mně je po tom?!"
    "./bonus/ja-vam-na-to-seru.mp3", "Já vám na to seru!"
    "./bonus/jestli-uvidim-pizzu.mp3", "Jestli uvidím pizzu...!"
    "./bonus/jste-normalni-nebo-co.mp3", "Jste normální?!"
    "./bonus/kdybych-foukl.mp3", "Kdybych foukl..."
    "./bonus/nebudu-se-bavit-s-matkama.mp3", "Nebudu se bavit s matkama!"
    "./bonus/neexistuje.mp3", "Neexistuje!"
    "./bonus/nemate-energii-a-jeste-blbe-zerete.mp3", "Nemáte energii a ještě blbě žerete!"
    "./bonus/nezajem.mp3", "Nezájem!"
    "./bonus/nezrat-psy.mp3", "Nechci vidět, že bude žrát psy!"
    "./bonus/reste-v-breclavi.mp3", "Tyhlety pičoviny!"
    "./bonus/rychle-si-odletim-na-floridu.mp3", "Rychle si odletím na Floridu!"
    "./bonus/se-vsema-se-bude-vyhravat.mp3", "Se všema se bude vyhrávat!"
    "./bonus/si-vytreme-prdel-s-kometou.mp3", "Vytřeme si prdel s Kometou!"
    "./bonus/tady-je-to-jak-lazaret.mp3", "Tady je to jak lazaret!"
    "./bonus/tak-to-tady-bude.mp3", "Tak to tady bude!"
    "./bonus/ti-dam-okostici.mp3", "Ti dám okostici!"
    "./bonus/vsechny-uzdravim.mp3", "Všechny uzdravím!"
    "./bonus/zapomente-na-to.mp3", "Zapomeňte na to!"
]

[<ReactComponent>]
let AppView () =
    let year = DateTimeOffset.Now.Year

    let isBonus,setBonus = React.useState(false)

    let logo = if isBonus then "brno-logo.jfif" else "logo.webp"
    let srcTracks = if isBonus then bonuses else tracks
    let textForTooltip = if isBonus then "Já bych radši zase zpátky do Nagana..." else "Chceš do Brna? Tak na mě klikni!"

    Html.divClassed "flex flex-col items-center gap-4 h-screen" [
        Html.divClassed "w-64 mt-4 flex flex-col items-center cursor-pointer" [
            Daisy.tooltip [
                tooltip.text textForTooltip
                tooltip.bottom
                prop.children [
                    Html.img [
                        prop.src logo
                        prop.onClick (fun _ -> isBonus |> not |> setBonus)
                    ]
                ]
            ]
        ]
        Html.divClassed "grow" [
            Html.divClassed "grid grid-cols-3 lg:grid-cols-7 gap-2 lg:gap-4" [
                yield!
                    srcTracks
                    |> List.map play
            ]
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
                            prop.href "https://github.com/Dzoukr/Nagano98"
                            prop.text "github.com/Dzoukr/Nagano98"
                        ]
                    ]
                ]
            ]
        ]
    ]
