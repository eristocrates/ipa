namespace http.www.wsmo.org.ns.wsmo_lite.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wsl =
    let _namespace_iri = Namespace_Iri wsl |> NamespaceIRI
    /// <summary>
    ///   <para>wsl:Effect</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Effect</para></remarks>
    /// <seealso href="http://www.wsmo.org/ns/wsmo-lite#Effect">http://www.wsmo.org/ns/wsmo-lite#Effect</seealso>
    let Effect = Prefixed_Name(wsl, "Effect") |> PrefixedName
    /// <summary>
    ///   <para>wsl:usesOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Property</para>
    ///
    /// labels<para>uses Ontology</para></remarks>
    /// <seealso href="http://www.wsmo.org/ns/wsmo-lite#usesOntology">http://www.wsmo.org/ns/wsmo-lite#usesOntology</seealso>
    let usesOntology = Prefixed_Name(wsl, "usesOntology") |> PrefixedName
    /// <summary>
    ///   <para>wsl:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>WSMO-Lite</para></remarks>
    /// <seealso href="http://www.wsmo.org/ns/wsmo-lite#">http://www.wsmo.org/ns/wsmo-lite#</seealso>
    let _prefix_iri = Prefixed_Name(wsl, "") |> PrefixedName

    /// <summary>
    ///   <para>wsl:FunctionalClassificationRoot</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Functional Classification Root</para></remarks>
    /// <seealso href="http://www.wsmo.org/ns/wsmo-lite#FunctionalClassificationRoot">http://www.wsmo.org/ns/wsmo-lite#FunctionalClassificationRoot</seealso>
    let FunctionalClassificationRoot =
        Prefixed_Name(wsl, "FunctionalClassificationRoot") |> PrefixedName

    /// <summary>
    ///   <para>wsl:Service</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.wsmo.org/ns/wsmo-lite#Service">http://www.wsmo.org/ns/wsmo-lite#Service</seealso>
    let Service = Prefixed_Name(wsl, "Service") |> PrefixedName
    /// <summary>
    ///   <para>wsl:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Condition</para></remarks>
    /// <seealso href="http://www.wsmo.org/ns/wsmo-lite#Condition">http://www.wsmo.org/ns/wsmo-lite#Condition</seealso>
    let Condition = Prefixed_Name(wsl, "Condition") |> PrefixedName

    /// <summary>
    ///   <para>wsl:NonfunctionalParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Nonfunctional Parameter</para></remarks>
    /// <seealso href="http://www.wsmo.org/ns/wsmo-lite#NonfunctionalParameter">http://www.wsmo.org/ns/wsmo-lite#NonfunctionalParameter</seealso>
    let NonfunctionalParameter =
        Prefixed_Name(wsl, "NonfunctionalParameter") |> PrefixedName

    /// <summary>
    ///   <para>wsl:Ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Ontology</para></remarks>
    /// <seealso href="http://www.wsmo.org/ns/wsmo-lite#Ontology">http://www.wsmo.org/ns/wsmo-lite#Ontology</seealso>
    let Ontology = Prefixed_Name(wsl, "Ontology") |> PrefixedName
