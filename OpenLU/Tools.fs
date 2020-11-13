namespace OpenLU
open System.IO.Compression
open System.IO
open System
module Tools =
    module Compression =
        module Zlib =
            let compress (buffer : byte[]) =
                using(new MemoryStream()) (fun compressSteam ->
                    using(new DeflateStream(compressSteam,CompressionLevel.Optimal)) (fun deflateStream ->
                        deflateStream.Write(buffer,0,Array.length buffer)
                        deflateStream.Close()
                        compressSteam.Close()
                        compressSteam.ToArray()
                        )
                    )
            let adler32Checksum (buffer: byte[]) =
                let adlerMod = 65521
                let len = Array.length buffer
                
                let rec calculate a b (data: byte[]) maxiter current =
                    let _a = (a + int data.[current]) % adlerMod
                    let _b = (b + _a) % adlerMod
                    let nextIter= current + 1
                    if nextIter < maxiter then calculate _a _b data maxiter nextIter else (_a,_b)
                let (a,b) = calculate 1 0 buffer len 0
                b * 65536 + a
                

            


                


