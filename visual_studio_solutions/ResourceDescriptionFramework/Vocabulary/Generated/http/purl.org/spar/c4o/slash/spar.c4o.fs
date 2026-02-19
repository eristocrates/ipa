namespace Spar.c4o.Namespace
module c4o =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/spar/c4o/" (Some "http://purl.org/spar/c4o.ttl") (Some "spar.c4o") None
    let ``2013-05-11`` = {_prefixID with _localName = "2013-05-11"}
    let ``2018-06-22`` = {_prefixID with _localName = "2018-06-22"}
    let BibliographicInformationSource = {_prefixID with _localName = "BibliographicInformationSource"}
    let ``CitationCounting%20module.png`` = {_prefixID with _localName = "CitationCounting%20module.png"}
    let GlobalCitationCount = {_prefixID with _localName = "GlobalCitationCount"}
    let InTextReferencePointer = {_prefixID with _localName = "InTextReferencePointer"}
    let ``InTextReferencePointer%20module.png`` = {_prefixID with _localName = "InTextReferencePointer%20module.png"}
    let InTextReferencePointerList = {_prefixID with _localName = "InTextReferencePointerList"}
    let InTextReferencePointerListItem = {_prefixID with _localName = "InTextReferencePointerListItem"}
    let SingleLocationPointerList = {_prefixID with _localName = "SingleLocationPointerList"}
    let SingleReferencePointerList = {_prefixID with _localName = "SingleReferencePointerList"}
    let denotes = {_prefixID with _localName = "denotes"}
    let hasContent = {_prefixID with _localName = "hasContent"}
    let hasContext = {_prefixID with _localName = "hasContext"}
    let hasGlobalCitationFrequency = {_prefixID with _localName = "hasGlobalCitationFrequency"}
    let hasGlobalCountDate = {_prefixID with _localName = "hasGlobalCountDate"}
    let hasGlobalCountSource = {_prefixID with _localName = "hasGlobalCountSource"}
    let hasGlobalCountValue = {_prefixID with _localName = "hasGlobalCountValue"}
    let hasInTextCitationFrequency = {_prefixID with _localName = "hasInTextCitationFrequency"}
    let isDenotedBy = {_prefixID with _localName = "isDenotedBy"}
    let isRelevantTo = {_prefixID with _localName = "isRelevantTo"}
    let pertainsTo = {_prefixID with _localName = "pertainsTo"}