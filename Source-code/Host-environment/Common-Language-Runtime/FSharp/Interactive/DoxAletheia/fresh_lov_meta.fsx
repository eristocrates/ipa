open System
#r "nuget: FSharp.Json"
open FSharp.Json

// Your record type
type Registry_Meta = { last_meta: DateTimeOffset }

let data: Registry_Meta = { last_meta = DateTimeOffset.Now }

// serialize record into JSON
let json = Json.serialize data
printfn "%s" json
// json is """{ "stringMember": "The string", "intMember": 123 }"""

// deserialize from JSON to record
let deserialized = Json.deserialize<Registry_Meta> json
printfn "%A" deserialized
// deserialized is {stringMember = "some value"; intMember = 123;}
