namespace Swap.sparql.Namespace
module sparql =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://eulersharp.sourceforge.net/2003/03swap/sparql#" (Some "http://eulersharp.sourceforge.net/2003/03swap/sparql") (Some "swap.sparql") None
    let Endpoint = {_prefixID with _localName = "Endpoint"}
    let Query = {_prefixID with _localName = "Query"}
    let Querying = {_prefixID with _localName = "Querying"}
    let Result = {_prefixID with _localName = "Result"}
    let SPARQL = {_prefixID with _localName = "SPARQL"}
    let Template = {_prefixID with _localName = "Template"}
    let TemplateBinding = {_prefixID with _localName = "TemplateBinding"}
    let executedOn = {_prefixID with _localName = "executedOn"}
    let hasBinding = {_prefixID with _localName = "hasBinding"}
    let hasQuery = {_prefixID with _localName = "hasQuery"}
    let hasTemplate = {_prefixID with _localName = "hasTemplate"}