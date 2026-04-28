#r "nuget: Stellar.FastDB"
open Stellar.Collections

// create/open database
let ucd =
    FastDB(
        new FastDBOptions(
            BaseDirectory = @"C:\Repositories\eristocrates\ipa\Persistence\Database\Embedded\Document\FastDB\Unicode",
            DatabaseName = "Unicode"
        )
    )
