namespace http.purl.org.xapi.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module xapi =
    let _namespace_iri = Namespace_Iri xapi |> NamespaceIRI
    /// <summary>
    ///   <para>xapi:ActivityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Activity Type is the identifier of the Activity Definition in an xAPI statement and when dereferenced can provide more information (metadata) about the activity type.</para>
    /// labels<para>ActivityType</para></remarks>
    /// <seealso href="http://purl.org/xapi/ontology#ActivityType">http://purl.org/xapi/ontology#ActivityType</seealso>
    let ActivityType = Prefixed_Name(xapi, "ActivityType") |> PrefixedName
    /// <summary>
    ///   <para>xapi:Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class for xAPI Statements, mainly for use with Statements in vocabulary examples.</para>
    /// labels<para>Statement</para></remarks>
    /// <seealso href="http://purl.org/xapi/ontology#Statement">http://purl.org/xapi/ontology#Statement</seealso>
    let Statement = Prefixed_Name(xapi, "Statement") |> PrefixedName

    /// <summary>
    ///   <para>xapi:closelyRelatedNaturalLanguageTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property used to connect the xAPI term to a specific sense, or meaning, in natural language that is very closely related. The sense will be identified with Wordnet, a carefully constructed ontology that aids in word sense disambiguation, which has been used with many different languages.</para>
    /// labels<para>closelyRelatedNaturalLanguageTerm</para></remarks>
    /// <seealso href="http://purl.org/xapi/ontology#closelyRelatedNaturalLanguageTerm">http://purl.org/xapi/ontology#closelyRelatedNaturalLanguageTerm</seealso>
    let closelyRelatedNaturalLanguageTerm =
        Prefixed_Name(xapi, "closelyRelatedNaturalLanguageTerm") |> PrefixedName

    /// <summary>
    ///   <para>xapi:Verb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Class for a Verb in a controlled vocabulary.</para>
    /// labels<para>Verb</para></remarks>
    /// <seealso href="http://purl.org/xapi/ontology#Verb">http://purl.org/xapi/ontology#Verb</seealso>
    let Verb = Prefixed_Name(xapi, "Verb") |> PrefixedName
    /// <summary>
    ///   <para>xapi:referenced</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property used to connects an xapi:Verb or other xAPI term not directly maintained by the vocabulary author to the skos:ConceptScheme that is the xAPI vocabulary referencing the term.</para>
    /// labels<para>referenced</para></remarks>
    /// <seealso href="http://purl.org/xapi/ontology#referenced">http://purl.org/xapi/ontology#referenced</seealso>
    let referenced = Prefixed_Name(xapi, "referenced") |> PrefixedName
    /// <summary>
    ///   <para>xapi:thirdPartyLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A property used by people who did not create the original verb, but would like to offer an alternative label for it.</para>
    /// labels<para>thirdPartyLabel</para></remarks>
    /// <seealso href="http://purl.org/xapi/ontology#thirdPartyLabel">http://purl.org/xapi/ontology#thirdPartyLabel</seealso>
    let thirdPartyLabel = Prefixed_Name(xapi, "thirdPartyLabel") |> PrefixedName
    /// <summary>
    ///   <para>xapi:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This ontology contains a list of the classes and properties that can be used when for creating and publishing a controlled vocabulary dataset for xAPI communities of practice.</para>
    /// labels<para>xAPI Controlled Vocabulary Ontology</para></remarks>
    /// <seealso href="http://purl.org/xapi/ontology#">http://purl.org/xapi/ontology#</seealso>
    let _prefix_iri = Prefixed_Name(xapi, "") |> PrefixedName
