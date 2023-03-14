module Hlasky.Client.Pages.BrnoMhd

open Feliz
open Hlasky.Client
open Hlasky.Client.Components

let private tracks = [
    "./brno-mhd/bezduvodne-me-vyhodil.mp3", "Bezdůvodně mě vyhodil..."
    "./brno-mhd/cestujici-mel-chovani-slusne.mp3", "Cestující měl chování slušné!"
    "./brno-mhd/chcete-takovou-populaci.mp3", "Chcete takovou populaci?!"
    "./brno-mhd/co-si-ten-hajzl-dovoluje.mp3", "Co si ten kurva..."
    "./brno-mhd/co-si-to-dovoluje.mp3", "Co si to dovoluje?!"
    "./brno-mhd/co-to-mate-za-ridice.mp3", "Co to máte za řidiče?!"
    "./brno-mhd/dobry-den.mp3", "Dobrý den."
    "./brno-mhd/ja-ho-zabiju.mp3", "Já ho zabiju!"
    "./brno-mhd/jdu-okamzite-za-johnem.mp3", "Jdu okamžitě za Johnem!"
    "./brno-mhd/ma-jednicku.mp3", "Má jedničku..."
    "./brno-mhd/me-mozna-znate.mp3", "Mě možná znáte."
    "./brno-mhd/me-nebude-mlatit.mp3", "Mě nebude mlátit!"
    "./brno-mhd/napsal-jsem-stiznost.mp3", "Napsal jsem stížnost!"
    "./brno-mhd/nevim.mp3", "Nevim."
    "./brno-mhd/potece-krev.mp3", "U Semilassu poteče krev!"
    "./brno-mhd/pouzil-fyzickeho-nasili.mp3", "Použil fyzického násilí!"
    "./brno-mhd/proc-me-neustale-napada.mp3", "Proč mě vyhodil?!"
    "./brno-mhd/tenhle-incident-bude-v-blesku.mp3", "Tenhle incident bude v Blesku!"
    "./brno-mhd/vsechny-tasky-mi-vyhodil.mp3", "Všechny tašky mi vyhodil!"
    "./brno-mhd/vyhodil-me-z-tramvaje.mp3", "Vyhodil mě z tramvaje!"
    "./brno-mhd/vystridat.mp3", "Vystřídat!"
]

[<ReactComponent>]
let BrnoMhdView() =
    Html.divClassed "grid grid-cols-3 lg:grid-cols-7 gap-2 lg:gap-4" [
        yield! tracks |> List.map Playbox.playbox
    ]