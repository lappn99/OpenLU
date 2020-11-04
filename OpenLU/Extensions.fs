namespace OpenLU
open System
module Extensions =
    module RandomExtensions =
        type Random with
            member this.LongRandom (min:int64, max : int64) =    
                let buf = Array.init<uint8> 8 (fun i -> byte (this.Next()))
                BitConverter.ToInt64(buf,0) % (max - min) + min



