namespace Fibo.FND.OwnershipAndControl.OwnershipAndControl.Namespace
module OwnershipAndControl =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/OwnershipAndControl/OwnershipAndControl.rdf") (Some @"fibo.FND.OwnershipAndControl.OwnershipAndControl") None
    let OwnershipControlSituation = {_prefixID with _localName = "OwnershipControlSituation"}
    let isOwnedAndControlledBy = {_prefixID with _localName = "isOwnedAndControlledBy"}
    let ownsAndControls = {_prefixID with _localName = "ownsAndControls"}