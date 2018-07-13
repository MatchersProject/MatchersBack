module Form

type MatchersParty (matchNumber: int, player1Name: string, player2Name: string, actualPlayer :int) = 
    member val matchNumber = matchNumber with get, set
    member x.player1Name = player1Name
    member x.player2Name = player2Name
    member x.actualPlayer = actualPlayer



let playTurn (party:MatchersParty) = fun n ->   
    match n with 
    | n > 3 or n < 1 -> None
    | n 


 
let createHtmlView (party:MatchersParty) =
    let mutable result = ""
    for i = 0 to party.matchNumber do
        result <- result + " |"
    result

let party = new MatchersParty(matchNumber=10, player1Name="Toto", player2Name="Tata", actualPlayer=1)


// A partir de là ça marche pas
// Retourne le MatchersParty avec n allumettes en moins
let playTurn (party:MatchersParty) = fun n -> 
    let playTurn' (party:MatchersParty) = fun n -> 
        match n with
        | r when r  >3 || r < 0 ->  None
        | _ -> 
            party.matchNumber <- (party.matchNumber - n)
            party
    playTurn' party
        

p1 = playTurn p1 2

htmlMatch = createHtmlView(p1)

