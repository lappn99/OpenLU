namespace OpenLU

open System
open OpenLU.Extensions.RandomExtensions
module Replica = 
    let random = new Random()
    let objectId  = random.LongRandom(1000000000000000000L, 1999999999999999999L)
        

