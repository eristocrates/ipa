#r "nuget: FSharp.UMX"

open FSharp.UMX

module UMX =
    let retag_string<[<Measure>] 'InputMeasure, [<Measure>] 'OutputMeasure>
        (input: string<'InputMeasure>)
        : string<'OutputMeasure> =
        %(UMX.untag input)
