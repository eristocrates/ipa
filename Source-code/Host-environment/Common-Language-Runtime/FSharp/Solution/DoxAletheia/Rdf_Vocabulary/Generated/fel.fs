namespace http.w3id.org.vcb.fel.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fel =
    let _namespace_iri = Namespace_Iri fel |> NamespaceIRI
    /// <summary>
    ///   <para>fel:AdjectivePoS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:PartOfSpeechClass</para>
    ///
    /// labels<para>Adjective</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#AdjectivePoS">http://w3id.org/vcb/fel#AdjectivePoS</seealso>
    let AdjectivePoS = Prefixed_Name(fel, "AdjectivePoS") |> PrefixedName
    /// <summary>
    ///   <para>fel:PartOfSpeechClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Part Of Speech Class</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#PartOfSpeechClass">http://w3id.org/vcb/fel#PartOfSpeechClass</seealso>
    let PartOfSpeechClass = Prefixed_Name(fel, "PartOfSpeechClass") |> PrefixedName
    /// <summary>
    ///   <para>fel:BaseFormClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Base Form Class</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#BaseFormClass">http://w3id.org/vcb/fel#BaseFormClass</seealso>
    let BaseFormClass = Prefixed_Name(fel, "BaseFormClass") |> PrefixedName
    /// <summary>
    ///   <para>fel:CommonForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>fel:BaseFormClass</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Common Form</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#CommonForm">http://w3id.org/vcb/fel#CommonForm</seealso>
    let CommonForm = Prefixed_Name(fel, "CommonForm") |> PrefixedName

    /// <summary>
    ///   <para>fel:DescriptiveReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>fel:ReferenceClass</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Desciptive Reference</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#DescriptiveReference">http://w3id.org/vcb/fel#DescriptiveReference</seealso>
    let DescriptiveReference =
        Prefixed_Name(fel, "DescriptiveReference") |> PrefixedName

    /// <summary>
    ///   <para>fel:DirectReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:ReferenceClass</para>
    ///
    /// labels<para>Direct Reference</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#DirectReference">http://w3id.org/vcb/fel#DirectReference</seealso>
    let DirectReference = Prefixed_Name(fel, "DirectReference") |> PrefixedName
    /// <summary>
    ///   <para>fel:MaximalOverlap</para>
    /// </summary>
    /// <remarks>
    ///   <para>fel:OverlapClass</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Maximal Overlap</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#MaximalOverlap">http://w3id.org/vcb/fel#MaximalOverlap</seealso>
    let MaximalOverlap = Prefixed_Name(fel, "MaximalOverlap") |> PrefixedName
    /// <summary>
    ///   <para>fel:MinimalOverlap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:OverlapClass</para>
    ///
    /// labels<para>Minimal Overlap</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#MinimalOverlap">http://w3id.org/vcb/fel#MinimalOverlap</seealso>
    let MinimalOverlap = Prefixed_Name(fel, "MinimalOverlap") |> PrefixedName
    /// <summary>
    ///   <para>fel:NounPhrasePoS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:PartOfSpeechClass</para>
    ///
    /// labels<para>Noun Phrase PoS</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#NounPhrasePoS">http://w3id.org/vcb/fel#NounPhrasePoS</seealso>
    let NounPhrasePoS = Prefixed_Name(fel, "NounPhrasePoS") |> PrefixedName
    /// <summary>
    ///   <para>fel:PluralNounPhrasePoS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:PartOfSpeechClass</para>
    ///
    /// labels<para>Plural Noun Phrase PoS</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#PluralNounPhrasePoS">http://w3id.org/vcb/fel#PluralNounPhrasePoS</seealso>
    let PluralNounPhrasePoS = Prefixed_Name(fel, "PluralNounPhrasePoS") |> PrefixedName
    /// <summary>
    ///   <para>fel:NounPhrase</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#NounPhrase">http://w3id.org/vcb/fel#NounPhrase</seealso>
    let NounPhrase = Prefixed_Name(fel, "NounPhrase") |> PrefixedName
    /// <summary>
    ///   <para>fel:ReferenceClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Reference Class</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#ReferenceClass">http://w3id.org/vcb/fel#ReferenceClass</seealso>
    let ReferenceClass = Prefixed_Name(fel, "ReferenceClass") |> PrefixedName
    /// <summary>
    ///   <para>fel:ExtendedProperForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:BaseFormClass</para>
    ///
    /// labels<para>Extended Proper Form</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#ExtendedProperForm">http://w3id.org/vcb/fel#ExtendedProperForm</seealso>
    let ExtendedProperForm = Prefixed_Name(fel, "ExtendedProperForm") |> PrefixedName
    /// <summary>
    ///   <para>fel:IntermediateOverlap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:OverlapClass</para>
    ///
    /// labels<para>Intermediate Overlap</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#IntermediateOverlap">http://w3id.org/vcb/fel#IntermediateOverlap</seealso>
    let IntermediateOverlap = Prefixed_Name(fel, "IntermediateOverlap") |> PrefixedName
    /// <summary>
    ///   <para>fel:MetonymicReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>fel:ReferenceClass</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Metonymic Reference</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#MetonymicReference">http://w3id.org/vcb/fel#MetonymicReference</seealso>
    let MetonymicReference = Prefixed_Name(fel, "MetonymicReference") |> PrefixedName
    /// <summary>
    ///   <para>fel:NoOverlap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:OverlapClass</para>
    ///
    /// labels<para>No Overlap</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#NoOverlap">http://w3id.org/vcb/fel#NoOverlap</seealso>
    let NoOverlap = Prefixed_Name(fel, "NoOverlap") |> PrefixedName
    /// <summary>
    ///   <para>fel:ProperForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>fel:BaseFormClass</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Proper Form</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#ProperForm">http://w3id.org/vcb/fel#ProperForm</seealso>
    let ProperForm = Prefixed_Name(fel, "ProperForm") |> PrefixedName
    /// <summary>
    ///   <para>fel:NumericTemporalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:BaseFormClass</para>
    ///
    /// labels<para>Numeric and Temporal Form</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#NumericTemporalForm">http://w3id.org/vcb/fel#NumericTemporalForm</seealso>
    let NumericTemporalForm = Prefixed_Name(fel, "NumericTemporalForm") |> PrefixedName
    /// <summary>
    ///   <para>fel:ProForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:BaseFormClass</para>
    ///
    /// labels<para>Pro-Form</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#ProForm">http://w3id.org/vcb/fel#ProForm</seealso>
    let ProForm = Prefixed_Name(fel, "ProForm") |> PrefixedName
    /// <summary>
    ///   <para>fel:RelatedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>fel:ReferenceClass</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Related Reference</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#RelatedReference">http://w3id.org/vcb/fel#RelatedReference</seealso>
    let RelatedReference = Prefixed_Name(fel, "RelatedReference") |> PrefixedName
    /// <summary>
    ///   <para>fel:ShortProperForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:BaseFormClass</para>
    ///
    /// labels<para>Short Proper Form</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#ShortProperForm">http://w3id.org/vcb/fel#ShortProperForm</seealso>
    let ShortProperForm = Prefixed_Name(fel, "ShortProperForm") |> PrefixedName
    /// <summary>
    ///   <para>fel:VerbPoS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:PartOfSpeechClass</para>
    ///
    /// labels<para>Verb PoS</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#VerbPoS">http://w3id.org/vcb/fel#VerbPoS</seealso>
    let VerbPoS = Prefixed_Name(fel, "VerbPoS") |> PrefixedName
    /// <summary>
    ///   <para>fel:entityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Entity Type</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#entityType">http://w3id.org/vcb/fel#entityType</seealso>
    let entityType = Prefixed_Name(fel, "entityType") |> PrefixedName

    /// <summary>
    ///   <para>fel:SingularNounPhrasePoS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:PartOfSpeechClass</para>
    ///
    /// labels<para>Singular Noun Phrase PoS</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#SingularNounPhrasePoS">http://w3id.org/vcb/fel#SingularNounPhrasePoS</seealso>
    let SingularNounPhrasePoS =
        Prefixed_Name(fel, "SingularNounPhrasePoS") |> PrefixedName

    /// <summary>
    ///   <para>fel:</para>
    /// </summary>
    /// <remarks>
    ///   <para>void:Dataset</para>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>A Fine-grained Entity Linking vocabulary</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#">http://w3id.org/vcb/fel#</seealso>
    let _prefix_iri = Prefixed_Name(fel, "") |> PrefixedName
    /// <summary>
    ///   <para>fel:AdverbPoS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:PartOfSpeechClass</para>
    ///
    /// labels<para>Adverb</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#AdverbPoS">http://w3id.org/vcb/fel#AdverbPoS</seealso>
    let AdverbPoS = Prefixed_Name(fel, "AdverbPoS") |> PrefixedName
    /// <summary>
    ///   <para>fel:AliasProperForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:BaseFormClass</para>
    ///
    /// labels<para>Alias Proper Form</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#AliasProperForm">http://w3id.org/vcb/fel#AliasProperForm</seealso>
    let AliasProperForm = Prefixed_Name(fel, "AliasProperForm") |> PrefixedName
    /// <summary>
    ///   <para>fel:AnaphoricReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>fel:ReferenceClass</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Anaphoric Reference</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#AnaphoricReference">http://w3id.org/vcb/fel#AnaphoricReference</seealso>
    let AnaphoricReference = Prefixed_Name(fel, "AnaphoricReference") |> PrefixedName
    /// <summary>
    ///   <para>fel:FullProperForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:BaseFormClass</para>
    ///
    /// labels<para>Full Proper Form</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#FullProperForm">http://w3id.org/vcb/fel#FullProperForm</seealso>
    let FullProperForm = Prefixed_Name(fel, "FullProperForm") |> PrefixedName
    /// <summary>
    ///   <para>fel:OverlapClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Overlap Class</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#OverlapClass">http://w3id.org/vcb/fel#OverlapClass</seealso>
    let OverlapClass = Prefixed_Name(fel, "OverlapClass") |> PrefixedName
    /// <summary>
    ///   <para>fel:MetaphoricReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>fel:ReferenceClass</para>
    ///
    /// labels<para>Metaphoric Reference</para></remarks>
    /// <seealso href="http://w3id.org/vcb/fel#MetaphoricReference">http://w3id.org/vcb/fel#MetaphoricReference</seealso>
    let MetaphoricReference = Prefixed_Name(fel, "MetaphoricReference") |> PrefixedName
