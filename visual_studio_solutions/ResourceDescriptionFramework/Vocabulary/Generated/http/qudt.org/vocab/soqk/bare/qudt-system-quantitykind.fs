namespace ``qudt-system-quantitykind``.Namespace
module ``qudt-system-quantitykind`` =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://qudt.org/vocab/soqk" (Some "http://qudt.org/3.1.10/vocab/soqk") (Some "qudt-system-quantitykind") None
    let CGS = {_prefixID with _localName = "CGS"}
    let ``CGS-EMU`` = {_prefixID with _localName = "CGS-EMU"}
    let ``CGS-ESU`` = {_prefixID with _localName = "CGS-ESU"}
    let ``CGS-Gauss`` = {_prefixID with _localName = "CGS-Gauss"}
    let IMPERIAL = {_prefixID with _localName = "IMPERIAL"}
    let ISQ = {_prefixID with _localName = "ISQ"}
    let Planck = {_prefixID with _localName = "Planck"}
    let SI = {_prefixID with _localName = "SI"}
    let USCS = {_prefixID with _localName = "USCS"}