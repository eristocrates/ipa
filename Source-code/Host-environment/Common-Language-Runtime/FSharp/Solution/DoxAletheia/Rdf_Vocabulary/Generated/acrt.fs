namespace http.privatealpha.com.ontology.certification._1.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module acrt =
    let _namespace_iri = Namespace_Iri acrt |> NamespaceIRI
    /// <summary>
    ///   <para>acrt:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>bibo:Webpage</para>
    ///   <para>"This document specifies a vocabulary for asserting the existence of official endorsements or certifications of &lt;em xmlns="http://www.w3.org/1999/xhtml" xmlns:acrt="http://privatealpha.com/ontology/certification/1#" xmlns:bibo="http://purl.org/ontology/bibo/" xmlns:dct="http://purl.org/dc/terms/" xmlns:foaf="http://xmlns.com/foaf/0.1/" xmlns:owl="http://www.w3.org/2002/07/owl#" xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" xmlns:rdfs="http://www.w3.org/2000/01/rdf-schema#" xmlns:skos="http://www.w3.org/2004/02/skos/core#" xmlns:vann="http://purl.org/vocab/vann/" xmlns:xsd="http://www.w3.org/2001/XMLSchema#"&gt;agents&lt;/em&gt;, such as people and organizations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://privatealpha.com/ontology/certification/1#">http://privatealpha.com/ontology/certification/1#</seealso>
    let _prefix_iri = Prefixed_Name(acrt, "") |> PrefixedName
    /// <summary>
    ///   <para>acrt:Certification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the abstract notion of certification, of an agent, by another agent, that the first agent possesses some property or set of properties implied by the certification, potentially within some spatiotemporal scope, and which may or may not be designated by some identifier."</para>
    /// labels<para>"Certification"</para></remarks>
    /// <seealso href="http://privatealpha.com/ontology/certification/1#Certification">http://privatealpha.com/ontology/certification/1#Certification</seealso>
    let Certification = Prefixed_Name(acrt, "Certification") |> PrefixedName
    /// <summary>
    ///   <para>acrt:authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies who (or what) is doing the certifying."</para>
    /// labels<para>"authority"</para></remarks>
    /// <seealso href="http://privatealpha.com/ontology/certification/1#authority">http://privatealpha.com/ontology/certification/1#authority</seealso>
    let authority = Prefixed_Name(acrt, "authority") |> PrefixedName
    /// <summary>
    ///   <para>acrt:certifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"This property specifies that its subject, an agent, has issued a certification."</para>
    /// labels<para>"certifies"</para></remarks>
    /// <seealso href="http://privatealpha.com/ontology/certification/1#certifies">http://privatealpha.com/ontology/certification/1#certifies</seealso>
    let certifies = Prefixed_Name(acrt, "certifies") |> PrefixedName
    /// <summary>
    ///   <para>acrt:has-certification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies that an agent possesses a given certification."</para>
    /// labels<para>"has-certification"</para></remarks>
    /// <seealso href="http://privatealpha.com/ontology/certification/1#has-certification">http://privatealpha.com/ontology/certification/1#has-certification</seealso>
    let has_certification = Prefixed_Name(acrt, "has-certification") |> PrefixedName
    /// <summary>
    ///   <para>acrt:principal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies who or what agent is being certified."</para>
    /// labels<para>"principal"</para></remarks>
    /// <seealso href="http://privatealpha.com/ontology/certification/1#principal">http://privatealpha.com/ontology/certification/1#principal</seealso>
    let principal = Prefixed_Name(acrt, "principal") |> PrefixedName
    /// <summary>
    ///   <para>acrt:proof</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property points to some proof of the certification, like a scan of an official document or a page on the issuing authority's website that corroborates the certification."</para>
    /// labels<para>"proof"</para></remarks>
    /// <seealso href="http://privatealpha.com/ontology/certification/1#proof">http://privatealpha.com/ontology/certification/1#proof</seealso>
    let proof = Prefixed_Name(acrt, "proof") |> PrefixedName
    /// <summary>
    ///   <para>acrt:proves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property asserts that its subject is somehow proof of a given certification."</para>
    /// labels<para>"proves"</para></remarks>
    /// <seealso href="http://privatealpha.com/ontology/certification/1#proves">http://privatealpha.com/ontology/certification/1#proves</seealso>
    let proves = Prefixed_Name(acrt, "proves") |> PrefixedName
    /// <summary>
    ///   <para>acrt:qualification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies what achievement, skill, or fact is being certified."</para>
    /// labels<para>"qualification"</para></remarks>
    /// <seealso href="http://privatealpha.com/ontology/certification/1#qualification">http://privatealpha.com/ontology/certification/1#qualification</seealso>
    let qualification = Prefixed_Name(acrt, "qualification") |> PrefixedName
