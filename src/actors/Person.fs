namespace PocketWorldSim.Actors

module Person =

    type PersonalityType =
        | Grouchy   of grouchPercent        : float
        | Positive  of positivityPercent    : float

    type SimplePerson =
        | Personality of personality : List<PersonalityType>

    