module Hlasky.Client.Pages.BrnoDorost

open Feliz
open Hlasky.Client
open Hlasky.Client.Components

let private tracks = [
    "./brno-dorost/brambory-zapomente.mp3", "Brambory zapomeňte!"
    "./brno-dorost/budes-bydlet-v-tvaroharne.mp3", "Budeš bydlet v tvarohárně!"
    "./brno-dorost/co-mne-je-po-tom-kurva.mp3", "Co mně je po tom?!"
    "./brno-dorost/ja-vam-na-to-seru.mp3", "Já vám na to seru!"
    "./brno-dorost/jestli-uvidim-pizzu.mp3", "Jestli uvidím pizzu...!"
    "./brno-dorost/jste-normalni-nebo-co.mp3", "Jste normální?!"
    "./brno-dorost/kdybych-foukl.mp3", "Kdybych foukl..."
    "./brno-dorost/nebudu-se-bavit-s-matkama.mp3", "Nebudu se bavit s matkama!"
    "./brno-dorost/neexistuje.mp3", "Neexistuje!"
    "./brno-dorost/nemate-energii-a-jeste-blbe-zerete.mp3", "Nemáte energii a ještě blbě žerete!"
    "./brno-dorost/nezajem.mp3", "Nezájem!"
    "./brno-dorost/nezrat-psy.mp3", "Nechci vidět, že bude žrát psy!"
    "./brno-dorost/reste-v-breclavi.mp3", "Tyhlety pičoviny!"
    "./brno-dorost/rychle-si-odletim-na-floridu.mp3", "Rychle si odletím na Floridu!"
    "./brno-dorost/se-vsema-se-bude-vyhravat.mp3", "Se všema se bude vyhrávat!"
    "./brno-dorost/si-vytreme-prdel-s-kometou.mp3", "Vytřeme si prdel s Kometou!"
    "./brno-dorost/tady-je-to-jak-lazaret.mp3", "Tady je to jak lazaret!"
    "./brno-dorost/tak-to-tady-bude.mp3", "Tak to tady bude!"
    "./brno-dorost/ti-dam-okostici.mp3", "Ti dám okostici!"
    "./brno-dorost/vsechny-uzdravim.mp3", "Všechny uzdravím!"
    "./brno-dorost/zapomente-na-to.mp3", "Zapomeňte na to!"
]

[<ReactComponent>]
let BrnoDorostView() =
    Html.divClassed "grid grid-cols-3 lg:grid-cols-7 gap-2 lg:gap-4" [
        yield! tracks |> List.map Playbox.playbox
    ]