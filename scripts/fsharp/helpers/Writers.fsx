#if INTERACTIVE


#endif

open Iride
open Iride.Extensions
open System
open System.IO

let writeTtlToFile (path: string) (g: VDS.RDF.IGraph) =
    let w =
        new VDS.RDF.Writing.CompressingTurtleWriter(10, VDS.RDF.Parsing.TurtleSyntax.W3C)

    w.HighSpeedModePermitted <- false // critical for small graphs
    w.Save(g, path)
