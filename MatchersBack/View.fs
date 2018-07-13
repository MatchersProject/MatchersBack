module View  
open System

open Suave.Html
open Suave.Form
open Form



let htmlMatch = Form.createHtmlView(Form.party)

let index =
    html [] [
        head [] [
            title [] "Matchers"
        ]

        body [] [
            div ["id", "header"] [
                tag "h1" [] [
                    a "/" [] [Text "Matcheeeers"]
                ]
            ]
            div ["id", "game"] [
                Text htmlMatch
            ]

            div ["id", "footer"] [
                Text "built with "
                a "http://fsharp.org" [] [Text "F#"]
                Text " and "
                a "http://suave.io" [] [Text "Suave.IO"]
            ]
        ]
    ]
    |> htmlToString