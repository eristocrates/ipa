namespace Swap.bioSKOSSchemes.Namespace
module bioSKOSSchemes =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#" (Some "http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes") (Some "swap.bioSKOSSchemes") None
    let uniProtTaxonomy = {_prefixID with _localName = "uniProtTaxonomy"}
    let uniProtTaxonomyDT = {_prefixID with _localName = "uniProtTaxonomyDT"}