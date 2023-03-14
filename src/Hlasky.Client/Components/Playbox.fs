namespace Hlasky.Client.Components

open Fable.Core
open Feliz

[<RequireQualifiedAccess>]
module Playbox =
    let [<Global("Audio")>] audioType : Browser.Types.HTMLAudioElementType = jsNative

    let playbox (track,label:string) =

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
