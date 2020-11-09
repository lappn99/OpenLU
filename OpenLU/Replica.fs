namespace OpenLU

open System
open OpenLU.Extensions.RandomExtensions
open RakDotNet.RakNet
module Replica = 
    let random = new Random()
    let objectId()  = random.LongRandom(100000000000000000L, 999999999999999999L)
        

