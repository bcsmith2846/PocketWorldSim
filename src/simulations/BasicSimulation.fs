namespace PocketWorldSim.Simulations

module BasicSimulation =
    open System

    //Creates a psudo-normally distributed random number with mean = `mean` and standard deviation = `stdDev`
    let RandomNormal (rand: Random) mean stdDev = 
        let u1 = 1.0 - rand.NextDouble()
        let u2 = 1.0 - rand.NextDouble()
        let randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                            Math.Sin(2.0 * Math.PI * u2)
        mean + stdDev * randStdNormal

    let QuickSim person events =
        let rand = new Random()
        let work_arrival = (RandomNormal rand 20.0 10.0) - 10.0
        printf "%A" work_arrival

