namespace PocketWorldSim.Simulations

module BasicSimulation =
    open System

    //Creates a psudo-normally distributed random number with mean = `mean` and standard deviation = `stdDev`
    let RandomNormal (rand: Random) mean stdDev = 
        let u1 = rand.NextDouble()
        let u2 = rand.NextDouble()
        let randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                            Math.Cos(2.0 * Math.PI * u2)
        mean + stdDev * randStdNormal


    let QuickSim person events =
        let rand = new Random()
        let work_arrival = (RandomNormal rand 5.0 5.0)
        printf "%A" work_arrival




