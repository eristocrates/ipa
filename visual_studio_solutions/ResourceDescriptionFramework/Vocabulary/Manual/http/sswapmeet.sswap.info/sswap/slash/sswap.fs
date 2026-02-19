namespace Sswap.Namespace

module sswap =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "http://sswapmeet.sswap.info/sswap/"
            None
            (Some "sswap")
            None

    let Graph = { _prefixID with _localName = "Graph" }
    let Object = { _prefixID with _localName = "Object" }
    let Provider = { _prefixID with _localName = "Provider" }
    let Resource = { _prefixID with _localName = "Resource" }
    let SSWAP = { _prefixID with _localName = "SSWAP" }
    let Subject = { _prefixID with _localName = "Subject" }
    let aboutURI = { _prefixID with _localName = "aboutURI" }
    let hasMapping = { _prefixID with _localName = "hasMapping" }
    let icon = { _prefixID with _localName = "icon" }
    let inputURI = { _prefixID with _localName = "inputURI" }
    let mapsTo = { _prefixID with _localName = "mapsTo" }
    let metadata = { _prefixID with _localName = "metadata" }
    let name = { _prefixID with _localName = "name" }
    let oneLineDescription = { _prefixID with _localName = "oneLineDescription" }
    let operatesOn = { _prefixID with _localName = "operatesOn" }
    let outputURI = { _prefixID with _localName = "outputURI" }
    let providedBy = { _prefixID with _localName = "providedBy" }
    let providesResource = { _prefixID with _localName = "providesResource" }
