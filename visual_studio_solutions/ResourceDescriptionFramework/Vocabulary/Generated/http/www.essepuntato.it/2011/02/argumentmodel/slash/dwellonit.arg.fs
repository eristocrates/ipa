namespace Dwellonit.arg.Namespace
module arg =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.essepuntato.it/2011/02/argumentmodel/" (Some "https://sourceforge.net/p/dwellonit/code/HEAD/tree/ArgumentModel/argumentmodel.owl?format=raw") (Some "dwellonit.arg") None
    let Argument = {_prefixID with _localName = "Argument"}
    let ArgumentationEntity = {_prefixID with _localName = "ArgumentationEntity"}
    let Backing = {_prefixID with _localName = "Backing"}
    let Claim = {_prefixID with _localName = "Claim"}
    let Evidence = {_prefixID with _localName = "Evidence"}
    let Qualifier = {_prefixID with _localName = "Qualifier"}
    let Rebuttal = {_prefixID with _localName = "Rebuttal"}
    let Warrant = {_prefixID with _localName = "Warrant"}
    let backs = {_prefixID with _localName = "backs"}
    let forces = {_prefixID with _localName = "forces"}
    let hasBacking = {_prefixID with _localName = "hasBacking"}
    let hasClaim = {_prefixID with _localName = "hasClaim"}
    let hasEvidence = {_prefixID with _localName = "hasEvidence"}
    let hasQualifier = {_prefixID with _localName = "hasQualifier"}
    let hasRebuttal = {_prefixID with _localName = "hasRebuttal"}
    let hasWarrant = {_prefixID with _localName = "hasWarrant"}
    let involves = {_prefixID with _localName = "involves"}
    let isBackingIn = {_prefixID with _localName = "isBackingIn"}
    let isClaimIn = {_prefixID with _localName = "isClaimIn"}
    let isEvidenceIn = {_prefixID with _localName = "isEvidenceIn"}
    let isInvolvedIn = {_prefixID with _localName = "isInvolvedIn"}
    let isQualifierIn = {_prefixID with _localName = "isQualifierIn"}
    let isRebuttalIn = {_prefixID with _localName = "isRebuttalIn"}
    let isValidUnless = {_prefixID with _localName = "isValidUnless"}
    let isWarrantIn = {_prefixID with _localName = "isWarrantIn"}
    let leadsTo = {_prefixID with _localName = "leadsTo"}
    let proves = {_prefixID with _localName = "proves"}
    let relatesTo = {_prefixID with _localName = "relatesTo"}
    let supports = {_prefixID with _localName = "supports"}