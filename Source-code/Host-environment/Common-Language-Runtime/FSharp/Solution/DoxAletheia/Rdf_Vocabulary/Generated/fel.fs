namespace http.w3id.org.vcb.fel.hash

open DoxAletheia

module fel =
    let _namespace_name = "http://w3id.org/vcb/fel#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#AdjectivePoS"></see>
    /// </summary>
    let AdjectivePoS = _prefix "AdjectivePoS"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#PartOfSpeechClass"></see>
    /// </summary>
    let PartOfSpeechClass = _prefix "PartOfSpeechClass"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#AdverbPoS"></see>
    /// </summary>
    let AdverbPoS = _prefix "AdverbPoS"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#AliasProperForm"></see>
    /// </summary>
    let AliasProperForm = _prefix "AliasProperForm"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#BaseFormClass"></see>
    /// </summary>
    let BaseFormClass = _prefix "BaseFormClass"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#ProperForm"></see>
    /// </summary>
    let ProperForm = _prefix "ProperForm"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#AnaphoricReference"></see>
    /// </summary>
    let AnaphoricReference = _prefix "AnaphoricReference"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#ReferenceClass"></see>
    /// </summary>
    let ReferenceClass = _prefix "ReferenceClass"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#CommonForm"></see>
    /// </summary>
    let CommonForm = _prefix "CommonForm"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#DescriptiveReference"></see>
    /// </summary>
    let DescriptiveReference = _prefix "DescriptiveReference"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#DirectReference"></see>
    /// </summary>
    let DirectReference = _prefix "DirectReference"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#ExtendedProperForm"></see>
    /// </summary>
    let ExtendedProperForm = _prefix "ExtendedProperForm"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#FullProperForm"></see>
    /// </summary>
    let FullProperForm = _prefix "FullProperForm"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#IntermediateOverlap"></see>
    /// </summary>
    let IntermediateOverlap = _prefix "IntermediateOverlap"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#OverlapClass"></see>
    /// </summary>
    let OverlapClass = _prefix "OverlapClass"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#MaximalOverlap"></see>
    /// </summary>
    let MaximalOverlap = _prefix "MaximalOverlap"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#MetaphoricReference"></see>
    /// </summary>
    let MetaphoricReference = _prefix "MetaphoricReference"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#MetonymicReference"></see>
    /// </summary>
    let MetonymicReference = _prefix "MetonymicReference"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#MinimalOverlap"></see>
    /// </summary>
    let MinimalOverlap = _prefix "MinimalOverlap"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#NoOverlap"></see>
    /// </summary>
    let NoOverlap = _prefix "NoOverlap"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#NounPhrasePoS"></see>
    /// </summary>
    let NounPhrasePoS = _prefix "NounPhrasePoS"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#NumericTemporalForm"></see>
    /// </summary>
    let NumericTemporalForm = _prefix "NumericTemporalForm"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#PluralNounPhrasePoS"></see>
    /// </summary>
    let PluralNounPhrasePoS = _prefix "PluralNounPhrasePoS"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#NounPhrase"></see>
    /// </summary>
    let NounPhrase = _prefix "NounPhrase"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#ProForm"></see>
    /// </summary>
    let ProForm = _prefix "ProForm"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#RelatedReference"></see>
    /// </summary>
    let RelatedReference = _prefix "RelatedReference"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#ShortProperForm"></see>
    /// </summary>
    let ShortProperForm = _prefix "ShortProperForm"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#SingularNounPhrasePoS"></see>
    /// </summary>
    let SingularNounPhrasePoS = _prefix "SingularNounPhrasePoS"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#VerbPoS"></see>
    /// </summary>
    let VerbPoS = _prefix "VerbPoS"
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#entityType"></see>
    /// </summary>
    let entityType = _prefix "entityType"
