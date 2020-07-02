// Learn more about F# at http://fsharp.org
namespace PocketWorldSim

open System


module main =
    open PocketWorldSim.Actors.Person
    open PocketWorldSim.Events.DailyEvents
    open PocketWorldSim.Simulations.BasicSimulation
    [<EntryPoint>]
    let main argv =
        let person = Personality(personality = [Grouchy 0.5; Positive 0.8])
        let events = Ritual(ritual = [BrushTeeth true; Shower true; PutOnMakeup false])
        QuickSim person events
        0 // return an integer exit code
