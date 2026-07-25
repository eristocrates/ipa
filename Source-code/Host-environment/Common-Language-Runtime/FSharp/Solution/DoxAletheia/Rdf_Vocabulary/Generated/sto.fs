namespace https.w3id.org.i40.sto.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sto =
    let _namespace_iri = Namespace_Iri sto |> NamespaceIRI
    /// <summary>
    ///   <para>sto:Standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Standard</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#Standard">https://w3id.org/i40/sto#Standard</seealso>
    let Standard = Prefixed_Name(sto, "Standard") |> PrefixedName
    /// <summary>
    ///   <para>sto:hasWikipediaArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Wikipedia article</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#hasWikipediaArticle">https://w3id.org/i40/sto#hasWikipediaArticle</seealso>
    let hasWikipediaArticle = Prefixed_Name(sto, "hasWikipediaArticle") |> PrefixedName
    /// <summary>
    ///   <para>sto:published</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Published</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#published">https://w3id.org/i40/sto#published</seealso>
    let published = Prefixed_Name(sto, "published") |> PrefixedName
    /// <summary>
    ///   <para>sto:ramiHierarchyLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>RAMI Hierarchy Level</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#ramiHierarchyLevel">https://w3id.org/i40/sto#ramiHierarchyLevel</seealso>
    let ramiHierarchyLevel = Prefixed_Name(sto, "ramiHierarchyLevel") |> PrefixedName
    /// <summary>
    ///   <para>sto:SDO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Standard Developing Organization</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#SDO">https://w3id.org/i40/sto#SDO</seealso>
    let SDO = Prefixed_Name(sto, "SDO") |> PrefixedName
    /// <summary>
    ///   <para>sto:formationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Formation Date</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#formationDate">https://w3id.org/i40/sto#formationDate</seealso>
    let formationDate = Prefixed_Name(sto, "formationDate") |> PrefixedName
    /// <summary>
    ///   <para>sto:hasOfficialWebsite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Official website</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#hasOfficialWebsite">https://w3id.org/i40/sto#hasOfficialWebsite</seealso>
    let hasOfficialWebsite = Prefixed_Name(sto, "hasOfficialWebsite") |> PrefixedName
    /// <summary>
    ///   <para>sto:hasWikidataEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Wikidata entity</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#hasWikidataEntity">https://w3id.org/i40/sto#hasWikidataEntity</seealso>
    let hasWikidataEntity = Prefixed_Name(sto, "hasWikidataEntity") |> PrefixedName
    /// <summary>
    ///   <para>sto:license</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>License</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#license">https://w3id.org/i40/sto#license</seealso>
    let license = Prefixed_Name(sto, "license") |> PrefixedName
    /// <summary>
    ///   <para>sto:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Name</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#name">https://w3id.org/i40/sto#name</seealso>
    let name = Prefixed_Name(sto, "name") |> PrefixedName
    /// <summary>
    ///   <para>sto:norm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Norm</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#norm">https://w3id.org/i40/sto#norm</seealso>
    let norm = Prefixed_Name(sto, "norm") |> PrefixedName
    /// <summary>
    ///   <para>sto:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Publisher</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#publisher">https://w3id.org/i40/sto#publisher</seealso>
    let publisher = Prefixed_Name(sto, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>sto:abbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Abbreviated name</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#abbreviation">https://w3id.org/i40/sto#abbreviation</seealso>
    let abbreviation = Prefixed_Name(sto, "abbreviation") |> PrefixedName
    /// <summary>
    ///   <para>sto:hasDBpediaResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has DBpedia resource</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#hasDBpediaResource">https://w3id.org/i40/sto#hasDBpediaResource</seealso>
    let hasDBpediaResource = Prefixed_Name(sto, "hasDBpediaResource") |> PrefixedName
    /// <summary>
    ///   <para>sto:hasTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Tag</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#hasTag">https://w3id.org/i40/sto#hasTag</seealso>
    let hasTag = Prefixed_Name(sto, "hasTag") |> PrefixedName
    /// <summary>
    ///   <para>sto:motivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>motivation</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#motivation">https://w3id.org/i40/sto#motivation</seealso>
    let motivation = Prefixed_Name(sto, "motivation") |> PrefixedName
    /// <summary>
    ///   <para>sto:relatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>Related to</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#relatedTo">https://w3id.org/i40/sto#relatedTo</seealso>
    let relatedTo = Prefixed_Name(sto, "relatedTo") |> PrefixedName
    /// <summary>
    ///   <para>sto:scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Scope</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#scope">https://w3id.org/i40/sto#scope</seealso>
    let scope = Prefixed_Name(sto, "scope") |> PrefixedName
    /// <summary>
    ///   <para>sto:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/sto#">https://w3id.org/i40/sto#</seealso>
    let _prefix_iri = Prefixed_Name(sto, "") |> PrefixedName
    /// <summary>
    ///   <para>sto:IndustryDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Industry Domain</para></remarks>
    /// <seealso href="https://w3id.org/i40/sto#IndustryDomain">https://w3id.org/i40/sto#IndustryDomain</seealso>
    let IndustryDomain = Prefixed_Name(sto, "IndustryDomain") |> PrefixedName
