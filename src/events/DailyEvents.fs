namespace PocketWorldSim.Events

module DailyEvents =
    type OrdinaryEvent =
    | BrushTeeth of brushTeeth : bool
    | PutOnMakeup of putOnMakeup : bool
    | Shower of shower : bool

    type MorningRitual =
    | Ritual of ritual : List<OrdinaryEvent>


