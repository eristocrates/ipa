namespace Fibo.FND.OwnershipAndControl.Control.Namespace
module Control =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/OwnershipAndControl/Control.rdf") (Some @"fibo.FND.OwnershipAndControl.Control") None
    let Control = {_prefixID with _localName = "Control"}
    let ControlledThing = {_prefixID with _localName = "ControlledThing"}
    let ControllingParty = {_prefixID with _localName = "ControllingParty"}
    let DeFactoControl = {_prefixID with _localName = "DeFactoControl"}
    let DeJureControl = {_prefixID with _localName = "DeJureControl"}
    let hasControllingParty = {_prefixID with _localName = "hasControllingParty"}
    let hasPartyInControl = {_prefixID with _localName = "hasPartyInControl"}
    let involvesControlledThing = {_prefixID with _localName = "involvesControlledThing"}
    let isControlledPartyOf = {_prefixID with _localName = "isControlledPartyOf"}
    let isControlledThingIn = {_prefixID with _localName = "isControlledThingIn"}
    let isControllingPartyIn = {_prefixID with _localName = "isControllingPartyIn"}
    let isControllingPartyOf = {_prefixID with _localName = "isControllingPartyOf"}
    let isInitiallyControlledOn = {_prefixID with _localName = "isInitiallyControlledOn"}
    let isPartyControlling = {_prefixID with _localName = "isPartyControlling"}