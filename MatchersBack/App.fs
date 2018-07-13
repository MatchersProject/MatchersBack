open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful

let game =
    choose [
        GET >=>  OK (View.index)
    ]

startWebServer defaultConfig game