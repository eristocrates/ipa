namespace Fibo.FND.OwnershipAndControl.Ownership.Namespace
module Ownership =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/OwnershipAndControl/Ownership.rdf") (Some @"fibo.FND.OwnershipAndControl.Ownership") None
    let Asset = {_prefixID with _localName = "Asset"}
    let IntangibleAsset = {_prefixID with _localName = "IntangibleAsset"}
    let Owner = {_prefixID with _localName = "Owner"}
    let Ownership = {_prefixID with _localName = "Ownership"}
    let TangibleAsset = {_prefixID with _localName = "TangibleAsset"}
    let hasOwnedAsset = {_prefixID with _localName = "hasOwnedAsset"}
    let hasOwningParty = {_prefixID with _localName = "hasOwningParty"}
    let isAssetOf = {_prefixID with _localName = "isAssetOf"}
    let isOwnedAsset = {_prefixID with _localName = "isOwnedAsset"}
    let isOwnedBy = {_prefixID with _localName = "isOwnedBy"}
    let isOwningParty = {_prefixID with _localName = "isOwningParty"}
    let owns = {_prefixID with _localName = "owns"}
    let ownsAsset = {_prefixID with _localName = "ownsAsset"}