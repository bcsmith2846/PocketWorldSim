namespace PocketWorldSim.Actors

module Person =

    type PersonalityTraits =
        | Grouchy   of grouchPercent        : float
        | Positive  of positivityPercent    : float

    type SimplePerson =
        | Personality of personality : List<PersonalityTraits>

    