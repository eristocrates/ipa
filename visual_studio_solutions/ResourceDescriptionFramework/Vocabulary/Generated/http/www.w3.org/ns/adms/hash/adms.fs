namespace Adms.Namespace
module adms =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/ns/adms#" (Some "http://www.w3.org/ns/adms#") (Some "adms") None
    let Asset = {_prefixID with _localName = "Asset"}
    let AssetDistribution = {_prefixID with _localName = "AssetDistribution"}
    let AssetRepository = {_prefixID with _localName = "AssetRepository"}
    let Identifier = {_prefixID with _localName = "Identifier"}
    let identifier = {_prefixID with _localName = "identifier"}
    let includedAsset = {_prefixID with _localName = "includedAsset"}
    let interoperabilityLevel = {_prefixID with _localName = "interoperabilityLevel"}
    let last = {_prefixID with _localName = "last"}
    let next = {_prefixID with _localName = "next"}
    let prev = {_prefixID with _localName = "prev"}
    let representationTechnique = {_prefixID with _localName = "representationTechnique"}
    let sample = {_prefixID with _localName = "sample"}
    let schemeAgency = {_prefixID with _localName = "schemeAgency"}
    let status = {_prefixID with _localName = "status"}
    let supportedSchema = {_prefixID with _localName = "supportedSchema"}
    let translation = {_prefixID with _localName = "translation"}
    let versionNotes = {_prefixID with _localName = "versionNotes"}