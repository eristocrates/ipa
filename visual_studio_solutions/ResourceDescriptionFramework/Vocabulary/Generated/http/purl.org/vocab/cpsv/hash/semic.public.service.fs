namespace Semic.``public``.service.Namespace
module service =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/vocab/cpsv#" (Some "https://github.com/SEMICeu/CPSV-AP/raw/refs/heads/master/releases/3.2.0/rdf/cpsv-ap.ttl") (Some "semic.public.service") None
    let PublicService = {_prefixID with _localName = "PublicService"}
    let Rule = {_prefixID with _localName = "Rule"}
    let follows = {_prefixID with _localName = "follows"}
    let hasInput = {_prefixID with _localName = "hasInput"}
    let implements = {_prefixID with _localName = "implements"}
    let produces = {_prefixID with _localName = "produces"}