namespace http.vocab.deri.ie.orca.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ieorca =
    let _namespace_iri = Namespace_Iri ieorca |> NamespaceIRI
    /// <summary>
    ///   <para>ieorca:AuthorExplicitly</para>
    /// </summary>
    /// <remarks>
    ///   <para>ieorca:Source</para>
    ///   <para>"Indicates knowledge explicitly attributed to the author."</para>
    /// labels<para>"author, explicitly"</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#AuthorExplicitly">http://vocab.deri.ie/orca#AuthorExplicitly</seealso>
    let AuthorExplicitly = Prefixed_Name(ieorca, "AuthorExplicitly") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:AuthorImplicitly</para>
    /// </summary>
    /// <remarks>
    ///   <para>ieorca:Source</para>
    ///   <para>"Indicates knowledge implicitly attributed to the author."</para>
    /// labels<para>"author, implicitly"</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#AuthorImplicitly">http://vocab.deri.ie/orca#AuthorImplicitly</seealso>
    let AuthorImplicitly = Prefixed_Name(ieorca, "AuthorImplicitly") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:Basis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Indicates the basis of the knowledge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Basis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#Basis">http://vocab.deri.ie/orca#Basis</seealso>
    let Basis = Prefixed_Name(ieorca, "Basis") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:ConfidenceLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates how certain the knowledge is"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ConfidenceLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#ConfidenceLevel">http://vocab.deri.ie/orca#ConfidenceLevel</seealso>
    let ConfidenceLevel = Prefixed_Name(ieorca, "ConfidenceLevel") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:DERI</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/orca#DERI">http://vocab.deri.ie/orca#DERI</seealso>
    let DERI = Prefixed_Name(ieorca, "DERI") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>ieorca:Basis</para>
    ///   <para>"Indicates knowledge known by data."</para>
    /// labels<para>"data"</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#Data">http://vocab.deri.ie/orca#Data</seealso>
    let Data = Prefixed_Name(ieorca, "Data") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:DoxasticKnowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>ieorca:ConfidenceLevel</para>
    ///   <para>"Indicates duoxastic knowledge: complete certainty, reflecting an accepted, known and/or proven fact."</para>
    /// labels<para>"doxastic knowledge: complete certainty, reflecting an accepted, known and/or proven fact"</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#DoxasticKnowledge">http://vocab.deri.ie/orca#DoxasticKnowledge</seealso>
    let DoxasticKnowledge = Prefixed_Name(ieorca, "DoxasticKnowledge") |> PrefixedName

    /// <summary>
    ///   <para>ieorca:DubitativeKnowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>ieorca:ConfidenceLevel</para>
    ///   <para>"Indicates dubitative knowledge: higher likelihood but short of complete certainty."</para>
    /// labels<para>"dubitative knowledge: higher likelihood but short of complete certainty"</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#DubitativeKnowledge">http://vocab.deri.ie/orca#DubitativeKnowledge</seealso>
    let DubitativeKnowledge =
        Prefixed_Name(ieorca, "DubitativeKnowledge") |> PrefixedName

    /// <summary>
    ///   <para>ieorca:HypotheticalKnowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>ieorca:ConfidenceLevel</para>
    ///   <para>"Indicates hypothetical knowledge: low certainty."</para>
    /// labels<para>"hypothetical knowledge: low certainty"</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#HypotheticalKnowledge">http://vocab.deri.ie/orca#HypotheticalKnowledge</seealso>
    let HypotheticalKnowledge =
        Prefixed_Name(ieorca, "HypotheticalKnowledge") |> PrefixedName

    /// <summary>
    ///   <para>ieorca:Jodi%20Schneider</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/orca#Jodi%20Schneider">http://vocab.deri.ie/orca#Jodi%20Schneider</seealso>
    let ``Jodi%20Schneider`` = Prefixed_Name(ieorca, "Jodi%20Schneider") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:LackOfKnowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>ieorca:ConfidenceLevel</para>
    ///   <para>"Indicates lack of knowledge."</para>
    /// labels<para>"lack of knowledge"</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#LackOfKnowledge">http://vocab.deri.ie/orca#LackOfKnowledge</seealso>
    let LackOfKnowledge = Prefixed_Name(ieorca, "LackOfKnowledge") |> PrefixedName

    /// <summary>
    ///   <para>ieorca:NamedExternalSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>ieorca:Source</para>
    ///   <para>"Indicates knowledge attributed to a named external source (either explicitly or as a reference)."</para>
    /// labels<para>"named external source"</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#NamedExternalSource">http://vocab.deri.ie/orca#NamedExternalSource</seealso>
    let NamedExternalSource =
        Prefixed_Name(ieorca, "NamedExternalSource") |> PrefixedName

    /// <summary>
    ///   <para>ieorca:NamelessExternalSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>ieorca:Source</para>
    ///   <para>"Indicates knowledge attributed to a nameless external source."</para>
    /// labels<para>"nameless external source"</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#NamelessExternalSource">http://vocab.deri.ie/orca#NamelessExternalSource</seealso>
    let NamelessExternalSource =
        Prefixed_Name(ieorca, "NamelessExternalSource") |> PrefixedName

    /// <summary>
    ///   <para>ieorca:NoSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>ieorca:Source</para>
    ///   <para>"Indicates knowledge not attributed to any source."</para>
    /// labels<para>"no source"</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#NoSource">http://vocab.deri.ie/orca#NoSource</seealso>
    let NoSource = Prefixed_Name(ieorca, "NoSource") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:Reasoning</para>
    /// </summary>
    /// <remarks>
    ///   <para>ieorca:Basis</para>
    ///   <para>"Indicates knowledge known by reasoning."</para>
    /// labels<para>"reasoning"</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#Reasoning">http://vocab.deri.ie/orca#Reasoning</seealso>
    let Reasoning = Prefixed_Name(ieorca, "Reasoning") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the source of the knowledge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#Source">http://vocab.deri.ie/orca#Source</seealso>
    let Source = Prefixed_Name(ieorca, "Source") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:Unidentified</para>
    /// </summary>
    /// <remarks>
    ///   <para>ieorca:Basis</para>
    ///   <para>"Indicates knowledge whose basis is unidentified."</para>
    /// labels<para>"unidentified"</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#Unidentified">http://vocab.deri.ie/orca#Unidentified</seealso>
    let Unidentified = Prefixed_Name(ieorca, "Unidentified") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:ahogan</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/orca#ahogan">http://vocab.deri.ie/orca#ahogan</seealso>
    let ahogan = Prefixed_Name(ieorca, "ahogan") |> PrefixedName

    /// <summary>
    ///   <para>ieorca:directlyLessCertainThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"directlyLessCertainThan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#directlyLessCertainThan">http://vocab.deri.ie/orca#directlyLessCertainThan</seealso>
    let directlyLessCertainThan =
        Prefixed_Name(ieorca, "directlyLessCertainThan") |> PrefixedName

    /// <summary>
    ///   <para>ieorca:directlyMoreCertainThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"directlyMoreCertainThan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#directlyMoreCertainThan">http://vocab.deri.ie/orca#directlyMoreCertainThan</seealso>
    let directlyMoreCertainThan =
        Prefixed_Name(ieorca, "directlyMoreCertainThan") |> PrefixedName

    /// <summary>
    ///   <para>ieorca:hasBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the basis of the knowledge."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasBasis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#hasBasis">http://vocab.deri.ie/orca#hasBasis</seealso>
    let hasBasis = Prefixed_Name(ieorca, "hasBasis") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:hasConfidenceLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the confidence/certainty level of the knowledge."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasConfidenceLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#hasConfidenceLevel">http://vocab.deri.ie/orca#hasConfidenceLevel</seealso>
    let hasConfidenceLevel = Prefixed_Name(ieorca, "hasConfidenceLevel") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the source of the knowledge."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#hasSource">http://vocab.deri.ie/orca#hasSource</seealso>
    let hasSource = Prefixed_Name(ieorca, "hasSource") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:lessCertain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"lessCertain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#lessCertain">http://vocab.deri.ie/orca#lessCertain</seealso>
    let lessCertain = Prefixed_Name(ieorca, "lessCertain") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:moreCertain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"moreCertain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/orca#moreCertain">http://vocab.deri.ie/orca#moreCertain</seealso>
    let moreCertain = Prefixed_Name(ieorca, "moreCertain") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/orca#rdf">http://vocab.deri.ie/orca#rdf</seealso>
    let rdf = Prefixed_Name(ieorca, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>ieorca:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/orca#ttl">http://vocab.deri.ie/orca#ttl</seealso>
    let ttl = Prefixed_Name(ieorca, "ttl") |> PrefixedName
