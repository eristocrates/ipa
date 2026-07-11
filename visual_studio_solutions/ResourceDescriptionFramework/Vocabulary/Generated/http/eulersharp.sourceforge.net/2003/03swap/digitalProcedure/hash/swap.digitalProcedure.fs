namespace Swap.digitalProcedure.Namespace
module digitalProcedure =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#" (Some "http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure") (Some "swap.digitalProcedure") None
    let Input = {_prefixID with _localName = "Input"}
    let LoggingIn = {_prefixID with _localName = "LoggingIn"}
    let Output = {_prefixID with _localName = "Output"}
    let Procedure = {_prefixID with _localName = "Procedure"}
    let Query = {_prefixID with _localName = "Query"}
    let QueryLanguage = {_prefixID with _localName = "QueryLanguage"}
    let QueryPlan = {_prefixID with _localName = "QueryPlan"}
    let Querying = {_prefixID with _localName = "Querying"}
    let Request = {_prefixID with _localName = "Request"}
    let Result = {_prefixID with _localName = "Result"}
    let SearchRequest = {_prefixID with _localName = "SearchRequest"}
    let SearchResult = {_prefixID with _localName = "SearchResult"}
    let Searching = {_prefixID with _localName = "Searching"}
    let Template = {_prefixID with _localName = "Template"}
    let hasResult = {_prefixID with _localName = "hasResult"}
    let hasSearchingDateTime = {_prefixID with _localName = "hasSearchingDateTime"}
    let hasSearchingPeriod = {_prefixID with _localName = "hasSearchingPeriod"}
    let hasSelected = {_prefixID with _localName = "hasSelected"}
    let matchesExpression = {_prefixID with _localName = "matchesExpression"}
    let resultOf = {_prefixID with _localName = "resultOf"}
    let searchingDuring = {_prefixID with _localName = "searchingDuring"}