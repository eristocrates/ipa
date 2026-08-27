namespace http.purl.org.vocab.cpsv.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cpsv =
    let _namespace_iri = Namespace_Iri cpsv |> NamespaceIRI
    /// <summary>
    ///   <para>cpsv:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/vocab/cpsv#">http://purl.org/vocab/cpsv#</seealso>
    let _prefix_iri = Prefixed_Name(cpsv, "") |> PrefixedName
    /// <summary>
    ///   <para>cpsv:Input</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Inputs can by any resource - document, artefact - anything. In a specific context it is likely to be useful to either define a sub class or declare the particular resource to also be of another type as well. A general case might be a foaf:Document but where possible, it is better to refer to a controlled vocabulary of types. dcterms:type should be used to use to provide this information linking to a SKOS Concept."</para>
    /// labels<para>"Input"</para></remarks>
    /// <seealso href="http://purl.org/vocab/cpsv#Input">http://purl.org/vocab/cpsv#Input</seealso>
    let Input = Prefixed_Name(cpsv, "Input") |> PrefixedName
    /// <summary>
    ///   <para>cpsv:Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Outputs can by any resource - document, artefact - anything. In a specific context it is likely to be useful to either define a sub class or declare the particular resource to also be of another type as well. A general case might be a foaf:Document but where possible, it is better to refer to a controlled vocabulary of types. dcterms:type should be used to use to provide this information linking to a SKOS Concept."</para>
    /// labels<para>"Output"</para></remarks>
    /// <seealso href="http://purl.org/vocab/cpsv#Output">http://purl.org/vocab/cpsv#Output</seealso>
    let Output = Prefixed_Name(cpsv, "Output") |> PrefixedName
    /// <summary>
    ///   <para>cpsv:PublicService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the service itself. A public service is the capacity to carry out a procedure and exists whether it is used or not. It is a set of deeds and acts performed by or on behalf of a public agency for the benefit of a citizen, a business or another public agency."</para>
    ///   <para>"This class represents the service itself. As noted in the scope (section 1.4), a public service is the capacity to carry out a procedure and exists whether it is used or not. It is a set of deeds and acts performed by or on behalf of a public agency for the benefit of a citizen, a business or another public agency."</para>
    /// labels<para>"Public Service"</para></remarks>
    /// <seealso href="http://purl.org/vocab/cpsv#PublicService">http://purl.org/vocab/cpsv#PublicService</seealso>
    let PublicService = Prefixed_Name(cpsv, "PublicService") |> PrefixedName
    /// <summary>
    ///   <para>cpsv:Rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The Rule class represents the specific rules, guidelines or procedures that the Public Service follows. Instances of the Rule class are FRBR Expressions, that is, a concrete expression, such as a document, of the more abstract concept of the rules themselves."</para>
    /// labels<para>"Rule"</para></remarks>
    /// <seealso href="http://purl.org/vocab/cpsv#Rule">http://purl.org/vocab/cpsv#Rule</seealso>
    let Rule = Prefixed_Name(cpsv, "Rule") |> PrefixedName
    /// <summary>
    ///   <para>cpsv:follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The follows property links a service to the Rule(s) under which it operates."</para>
    /// labels<para>"follows"</para></remarks>
    /// <seealso href="http://purl.org/vocab/cpsv#follows">http://purl.org/vocab/cpsv#follows</seealso>
    let follows = Prefixed_Name(cpsv, "follows") |> PrefixedName
    /// <summary>
    ///   <para>cpsv:hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The hasInput property links a Public Service to one or more instances of the Input class (see below). A specific service may require the presence of certain inputs or combinations of inputs in order to operate. These should be described in an application profile for a given service."</para>
    /// labels<para>"has input"</para></remarks>
    /// <seealso href="http://purl.org/vocab/cpsv#hasInput">http://purl.org/vocab/cpsv#hasInput</seealso>
    let hasInput = Prefixed_Name(cpsv, "hasInput") |> PrefixedName

    /// <summary>
    ///   <para>cpsv:physicallyAvailableAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A physical location at which a user may interact with the Public Service."</para>
    /// labels<para>"physically available at"</para></remarks>
    /// <seealso href="http://purl.org/vocab/cpsv#physicallyAvailableAt">http://purl.org/vocab/cpsv#physicallyAvailableAt</seealso>
    let physicallyAvailableAt =
        Prefixed_Name(cpsv, "physicallyAvailableAt") |> PrefixedName

    /// <summary>
    ///   <para>cpsv:produces</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The produces property links a Public Service to one or more instances of the Output class which is its range."</para>
    /// labels<para>"produces"</para></remarks>
    /// <seealso href="http://purl.org/vocab/cpsv#produces">http://purl.org/vocab/cpsv#produces</seealso>
    let produces = Prefixed_Name(cpsv, "produces") |> PrefixedName
    /// <summary>
    ///   <para>cpsv:provides</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The provides property links an Agent to a Public Service for which it is responsible. Whether it provides the service directly or outsources it is not relevant, the Agent that provides the service is the one that is ultimately responsible for its provision."</para>
    /// labels<para>"provides"</para></remarks>
    /// <seealso href="http://purl.org/vocab/cpsv#provides">http://purl.org/vocab/cpsv#provides</seealso>
    let provides = Prefixed_Name(cpsv, "provides") |> PrefixedName
    /// <summary>
    ///   <para>cpsv:uses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The uses property links an Agent to a Public Service in which it plays the specific role of user, meaning that it provides the input and receives the output but does not play any direct role in providing the service. This will typically be an individual citizen or an outside organisation."</para>
    /// labels<para>"uses"</para></remarks>
    /// <seealso href="http://purl.org/vocab/cpsv#uses">http://purl.org/vocab/cpsv#uses</seealso>
    let uses = Prefixed_Name(cpsv, "uses") |> PrefixedName
