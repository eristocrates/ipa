namespace Skos.Namespace
module skos =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2004/02/skos/core#" (Some "http://www.w3.org/2004/02/skos/core#") (Some "skos") None
    let Collection = {_prefixID with _localName = "Collection"}
    let Concept = {_prefixID with _localName = "Concept"}
    let ConceptScheme = {_prefixID with _localName = "ConceptScheme"}
    let OrderedCollection = {_prefixID with _localName = "OrderedCollection"}
    let altLabel = {_prefixID with _localName = "altLabel"}
    let broadMatch = {_prefixID with _localName = "broadMatch"}
    let broader = {_prefixID with _localName = "broader"}
    let broaderTransitive = {_prefixID with _localName = "broaderTransitive"}
    let changeNote = {_prefixID with _localName = "changeNote"}
    let closeMatch = {_prefixID with _localName = "closeMatch"}
    let definition = {_prefixID with _localName = "definition"}
    let editorialNote = {_prefixID with _localName = "editorialNote"}
    let exactMatch = {_prefixID with _localName = "exactMatch"}
    let example = {_prefixID with _localName = "example"}
    let hasTopConcept = {_prefixID with _localName = "hasTopConcept"}
    let hiddenLabel = {_prefixID with _localName = "hiddenLabel"}
    let historyNote = {_prefixID with _localName = "historyNote"}
    let inScheme = {_prefixID with _localName = "inScheme"}
    let mappingRelation = {_prefixID with _localName = "mappingRelation"}
    let ``member`` = {_prefixID with _localName = "member"}
    let memberList = {_prefixID with _localName = "memberList"}
    let narrowMatch = {_prefixID with _localName = "narrowMatch"}
    let narrower = {_prefixID with _localName = "narrower"}
    let narrowerTransitive = {_prefixID with _localName = "narrowerTransitive"}
    let notation = {_prefixID with _localName = "notation"}
    let note = {_prefixID with _localName = "note"}
    let prefLabel = {_prefixID with _localName = "prefLabel"}
    let related = {_prefixID with _localName = "related"}
    let relatedMatch = {_prefixID with _localName = "relatedMatch"}
    let scopeNote = {_prefixID with _localName = "scopeNote"}
    let semanticRelation = {_prefixID with _localName = "semanticRelation"}
    let topConceptOf = {_prefixID with _localName = "topConceptOf"}