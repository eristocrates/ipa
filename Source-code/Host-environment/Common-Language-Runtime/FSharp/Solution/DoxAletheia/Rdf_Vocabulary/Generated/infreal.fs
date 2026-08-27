namespace http.www.ontologydesignpatterns.org.cp.owl.informationrealization.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module infreal =
    let _namespace_iri = Namespace_Iri infreal |> NamespaceIRI
    /// <summary>
    ///   <para>infreal:InformationObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A piece of information, such as a musical composition, a text, a word, a picture, independently from how it is concretely realized."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Information object"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#InformationObject">http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#InformationObject</seealso>
    let InformationObject = Prefixed_Name(infreal, "InformationObject") |> PrefixedName

    /// <summary>
    ///   <para>infreal:InformationRealization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A concrete realization of an information object, e.g. the written document containing the text of a law."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Information realization"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#InformationRealization">http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#InformationRealization</seealso>
    let InformationRealization =
        Prefixed_Name(infreal, "InformationRealization") |> PrefixedName

    /// <summary>
    ///   <para>infreal:isRealizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an information realization and an information object, e.g. the paper copy of the Italian Constitution realizes the text of the Constitution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is realized by"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#isRealizedBy">http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#isRealizedBy</seealso>
    let isRealizedBy = Prefixed_Name(infreal, "isRealizedBy") |> PrefixedName
    /// <summary>
    ///   <para>infreal:realizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an information realization and an information object, e.g. the paper copy of the Italian Constitution realizes the text of the Constitution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"realizes"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#realizes">http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#realizes</seealso>
    let realizes = Prefixed_Name(infreal, "realizes") |> PrefixedName
