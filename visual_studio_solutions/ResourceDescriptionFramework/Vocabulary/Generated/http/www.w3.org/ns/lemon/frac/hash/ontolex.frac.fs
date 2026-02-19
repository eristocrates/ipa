namespace Ontolex.frac.Namespace

module frac =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "http://www.w3.org/ns/lemon/frac#"
            (Some
                @"C:\Repositories\Modernization\ConsoleFsharp\ResourceDescriptionFramework\Vocabulary\Generated\http\www.w3.org\ns\lemon\frac\hash\frac.ttl")
            (Some @"ontolex.frac")
            None

    let Attestation = { _prefixID with _localName = "Attestation" }
    let Collocation = { _prefixID with _localName = "Collocation" }
    let Frequency = { _prefixID with _localName = "Frequency" }
    let Observable = { _prefixID with _localName = "Observable" }
    let Observation = { _prefixID with _localName = "Observation" }
    let attestation = { _prefixID with _localName = "attestation" }
    let cScore = { _prefixID with _localName = "cScore" }
    let citation = { _prefixID with _localName = "citation" }
    let frequency = { _prefixID with _localName = "frequency" }
    let gloss = { _prefixID with _localName = "gloss" }
    let head = { _prefixID with _localName = "head" }
    let locus = { _prefixID with _localName = "locus" }
    let observedIn = { _prefixID with _localName = "observedIn" }
    let total = { _prefixID with _localName = "total" }
