namespace http.w3id.org.vcb.fel.hash

open DoxAletheia.Rdf_Vocabulary

module fel =
    let _namespace_name = "http://w3id.org/vcb/fel#"

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#AdjectivePoS"></see>
    /// </summary>
    let AdjectivePoS =
        Namespaced_IRI.parse _namespace_name "AdjectivePoS" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#PartOfSpeechClass"></see>
    /// </summary>
    let PartOfSpeechClass =
        Namespaced_IRI.parse _namespace_name "PartOfSpeechClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#AdverbPoS"></see>
    /// </summary>
    let AdverbPoS = Namespaced_IRI.parse _namespace_name "AdverbPoS" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#AliasProperForm"></see>
    /// </summary>
    let AliasProperForm =
        Namespaced_IRI.parse _namespace_name "AliasProperForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#BaseFormClass"></see>
    /// </summary>
    let BaseFormClass =
        Namespaced_IRI.parse _namespace_name "BaseFormClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#ProperForm"></see>
    /// </summary>
    let ProperForm = Namespaced_IRI.parse _namespace_name "ProperForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#AnaphoricReference"></see>
    /// </summary>
    let AnaphoricReference =
        Namespaced_IRI.parse _namespace_name "AnaphoricReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#ReferenceClass"></see>
    /// </summary>
    let ReferenceClass =
        Namespaced_IRI.parse _namespace_name "ReferenceClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#CommonForm"></see>
    /// </summary>
    let CommonForm = Namespaced_IRI.parse _namespace_name "CommonForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#DescriptiveReference"></see>
    /// </summary>
    let DescriptiveReference =
        Namespaced_IRI.parse _namespace_name "DescriptiveReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#DirectReference"></see>
    /// </summary>
    let DirectReference =
        Namespaced_IRI.parse _namespace_name "DirectReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#ExtendedProperForm"></see>
    /// </summary>
    let ExtendedProperForm =
        Namespaced_IRI.parse _namespace_name "ExtendedProperForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#FullProperForm"></see>
    /// </summary>
    let FullProperForm =
        Namespaced_IRI.parse _namespace_name "FullProperForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#IntermediateOverlap"></see>
    /// </summary>
    let IntermediateOverlap =
        Namespaced_IRI.parse _namespace_name "IntermediateOverlap" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#OverlapClass"></see>
    /// </summary>
    let OverlapClass =
        Namespaced_IRI.parse _namespace_name "OverlapClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#MaximalOverlap"></see>
    /// </summary>
    let MaximalOverlap =
        Namespaced_IRI.parse _namespace_name "MaximalOverlap" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#MetaphoricReference"></see>
    /// </summary>
    let MetaphoricReference =
        Namespaced_IRI.parse _namespace_name "MetaphoricReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#MetonymicReference"></see>
    /// </summary>
    let MetonymicReference =
        Namespaced_IRI.parse _namespace_name "MetonymicReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#MinimalOverlap"></see>
    /// </summary>
    let MinimalOverlap =
        Namespaced_IRI.parse _namespace_name "MinimalOverlap" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#NoOverlap"></see>
    /// </summary>
    let NoOverlap = Namespaced_IRI.parse _namespace_name "NoOverlap" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#NounPhrasePoS"></see>
    /// </summary>
    let NounPhrasePoS =
        Namespaced_IRI.parse _namespace_name "NounPhrasePoS" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#NumericTemporalForm"></see>
    /// </summary>
    let NumericTemporalForm =
        Namespaced_IRI.parse _namespace_name "NumericTemporalForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#PluralNounPhrasePoS"></see>
    /// </summary>
    let PluralNounPhrasePoS =
        Namespaced_IRI.parse _namespace_name "PluralNounPhrasePoS" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#NounPhrase"></see>
    /// </summary>
    let NounPhrase = Namespaced_IRI.parse _namespace_name "NounPhrase" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#ProForm"></see>
    /// </summary>
    let ProForm = Namespaced_IRI.parse _namespace_name "ProForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#RelatedReference"></see>
    /// </summary>
    let RelatedReference =
        Namespaced_IRI.parse _namespace_name "RelatedReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#ShortProperForm"></see>
    /// </summary>
    let ShortProperForm =
        Namespaced_IRI.parse _namespace_name "ShortProperForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#SingularNounPhrasePoS"></see>
    /// </summary>
    let SingularNounPhrasePoS =
        Namespaced_IRI.parse _namespace_name "SingularNounPhrasePoS" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#VerbPoS"></see>
    /// </summary>
    let VerbPoS = Namespaced_IRI.parse _namespace_name "VerbPoS" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/vcb/fel#entityType"></see>
    /// </summary>
    let entityType = Namespaced_IRI.parse _namespace_name "entityType" |> NamespacedName
