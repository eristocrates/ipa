namespace Swap.physicalResource.Namespace
module physicalResource =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://eulersharp.sourceforge.net/2003/03swap/physicalResource#" (Some "http://eulersharp.sourceforge.net/2003/03swap/physicalResource") (Some "swap.physicalResource") None
    let Compound = {_prefixID with _localName = "Compound"}
    let Device = {_prefixID with _localName = "Device"}
    let Product = {_prefixID with _localName = "Product"}
    let Resource = {_prefixID with _localName = "Resource"}
    let Specimen = {_prefixID with _localName = "Specimen"}
    let complexityOf = {_prefixID with _localName = "complexityOf"}
    let hasComplexity = {_prefixID with _localName = "hasComplexity"}