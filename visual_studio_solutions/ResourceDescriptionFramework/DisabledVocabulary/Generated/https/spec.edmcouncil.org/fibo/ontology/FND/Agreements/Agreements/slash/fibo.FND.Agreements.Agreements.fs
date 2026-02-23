namespace Fibo.FND.Agreements.Agreements.Namespace
module Agreements =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Agreements/Agreements.rdf") (Some @"fibo.FND.Agreements.Agreements") None
    let Agreement = {_prefixID with _localName = "Agreement"}
    let Beneficiary = {_prefixID with _localName = "Beneficiary"}
    let BilateralAgreement = {_prefixID with _localName = "BilateralAgreement"}
    let Commitment = {_prefixID with _localName = "Commitment"}
    let CommitmentAtLarge = {_prefixID with _localName = "CommitmentAtLarge"}
    let IndividualUnilateralCommitment = {_prefixID with _localName = "IndividualUnilateralCommitment"}
    let MultilateralAgreement = {_prefixID with _localName = "MultilateralAgreement"}
    let MutualAgreement = {_prefixID with _localName = "MutualAgreement"}
    let MutualCommitment = {_prefixID with _localName = "MutualCommitment"}
    let Obligee = {_prefixID with _localName = "Obligee"}
    let Obligor = {_prefixID with _localName = "Obligor"}
    let UnilateralCommitment = {_prefixID with _localName = "UnilateralCommitment"}
    let hasObligation = {_prefixID with _localName = "hasObligation"}
    let isObligationOf = {_prefixID with _localName = "isObligationOf"}