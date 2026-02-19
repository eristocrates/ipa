namespace Swan.discourse.elements.Namespace
module elements =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/swan/2.0/discourse-elements/" (Some "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/discourse-elements.owl") (Some "swan.discourse.elements") None
    let Claim = {_prefixID with _localName = "Claim"}
    let DiscourseElement = {_prefixID with _localName = "DiscourseElement"}
    let Hypothesis = {_prefixID with _localName = "Hypothesis"}
    let Question = {_prefixID with _localName = "Question"}
    let ResearchStatement = {_prefixID with _localName = "ResearchStatement"}