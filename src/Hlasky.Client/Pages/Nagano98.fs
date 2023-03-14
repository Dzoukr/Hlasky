module Hlasky.Client.Pages.Nagano98

open Feliz
open Hlasky.Client
open Hlasky.Client.Components

let private tracks = [
    "./nagano98/beranek-dej.mp3", "Beránek - dej!"
    "./nagano98/dominik-chytil-jsme-ve-finale.mp3", "Dominik chytil, jsme ve finale!"
    "./nagano98/dulezity-gol.mp3", "To je důležitý gól!"
    "./nagano98/existuje-spravedlnost.mp3", "Tak přece jen existuje spravedlnost!"
    "./nagano98/gol-vedeme-10.mp3", "Gól! Vedeme 1:0!"
    "./nagano98/hasek-chyta.mp3", "Hašek chytááá!"
    "./nagano98/hasek-neuveritelne.mp3", "Hašek neuvěřitelně!"
    "./nagano98/jagr-stale-jagr-gol.mp3", "Jágr, stále Jágr - góoool!"
    "./nagano98/jsi-pasak-albi.mp3", "Jsi pašák, Albi!"
    "./nagano98/otevirame-zlatou-branu.mp3", "Otevíráme zlatou bránu!"
    "./nagano98/pavle-pojd.mp3", "Pavle, pojď!"
    "./nagano98/prepiste-dejiny.mp3", "Přepište dějiny!"
    "./nagano98/roy-hasek-premyslive-typy.mp3", "Roy i Hašek jsou přemýšlivé typy."
    "./nagano98/roy-pateru-nezna.mp3", "Patera, toho Roy vůbec nezná!"
    "./nagano98/rucinsky-faulovany.mp3", "Ručinský faulovaný zezadu!"
    "./nagano98/rucinsky-gol.mp3", "Martin Ručinský - góool!"
    "./nagano98/shanahan-musi-dat-long.mp3", "Brandon Shanahan musí dát."
    "./nagano98/skvele-dominiku.mp3", "Skvěle, skvěle Dominiku!"
    "./nagano98/slegr-to-nema-dobre.mp3", "Jiří Šlégr to nemá dobré."
    "./nagano98/takhle-pali-guma.mp3", "Takhle pálí guma!"
    "./nagano98/vylucuje-pouze-nase.mp3", "Vylučuje pouze naše."
]

[<ReactComponent>]
let Nagano98View() =
    Html.divClassed "grid grid-cols-3 lg:grid-cols-7 gap-2 lg:gap-4" [
        yield! tracks |> List.map Playbox.playbox
    ]