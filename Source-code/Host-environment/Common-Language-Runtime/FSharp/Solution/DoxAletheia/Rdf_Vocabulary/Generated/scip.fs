namespace http.lod.taxonconcept.org.ontology.sci_people.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module scip =
    let _namespace_iri = Namespace_Iri scip |> NamespaceIRI

    /// <summary>
    ///   <para>scip:PersonPublicationListHTML</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PersonPublicationListHTML"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#PersonPublicationListHTML">http://lod.taxonconcept.org/ontology/sci_people.owl#PersonPublicationListHTML</seealso>
    let PersonPublicationListHTML =
        Prefixed_Name(scip, "PersonPublicationListHTML") |> PrefixedName

    /// <summary>
    ///   <para>scip:PersonPublicationListRDF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PersonPublicationListRDF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#PersonPublicationListRDF">http://lod.taxonconcept.org/ontology/sci_people.owl#PersonPublicationListRDF</seealso>
    let PersonPublicationListRDF =
        Prefixed_Name(scip, "PersonPublicationListRDF") |> PrefixedName

    /// <summary>
    ///   <para>scip:ScientificMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ScientificMethod"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#ScientificMethod">http://lod.taxonconcept.org/ontology/sci_people.owl#ScientificMethod</seealso>
    let ScientificMethod = Prefixed_Name(scip, "ScientificMethod") |> PrefixedName
    /// <summary>
    ///   <para>scip:citationUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"citationUse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#citationUse">http://lod.taxonconcept.org/ontology/sci_people.owl#citationUse</seealso>
    let citationUse = Prefixed_Name(scip, "citationUse") |> PrefixedName
    /// <summary>
    ///   <para>scip:hasAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAuthor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthor">http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthor</seealso>
    let hasAuthor = Prefixed_Name(scip, "hasAuthor") |> PrefixedName
    /// <summary>
    ///   <para>scip:hasAuthored</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAuthored"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthored">http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthored</seealso>
    let hasAuthored = Prefixed_Name(scip, "hasAuthored") |> PrefixedName
    /// <summary>
    ///   <para>scip:hasAuthoredArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAuthoredArticle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredArticle">http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredArticle</seealso>
    let hasAuthoredArticle = Prefixed_Name(scip, "hasAuthoredArticle") |> PrefixedName

    /// <summary>
    ///   <para>scip:hasAuthoredBinomialName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAuthoredBinomialName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredBinomialName">http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredBinomialName</seealso>
    let hasAuthoredBinomialName =
        Prefixed_Name(scip, "hasAuthoredBinomialName") |> PrefixedName

    /// <summary>
    ///   <para>scip:hasAuthoredEmail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAuthoredEmail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredEmail">http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredEmail</seealso>
    let hasAuthoredEmail = Prefixed_Name(scip, "hasAuthoredEmail") |> PrefixedName
    /// <summary>
    ///   <para>scip:hasAuthoredName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAuthoredName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredName">http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredName</seealso>
    let hasAuthoredName = Prefixed_Name(scip, "hasAuthoredName") |> PrefixedName

    /// <summary>
    ///   <para>scip:hasAuthoredScientificName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAuthoredScientificName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredScientificName">http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredScientificName</seealso>
    let hasAuthoredScientificName =
        Prefixed_Name(scip, "hasAuthoredScientificName") |> PrefixedName

    /// <summary>
    ///   <para>scip:hasAuthoredTaxonomicDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAuthoredTaxonomicDescription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredTaxonomicDescription">http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredTaxonomicDescription</seealso>
    let hasAuthoredTaxonomicDescription =
        Prefixed_Name(scip, "hasAuthoredTaxonomicDescription") |> PrefixedName

    /// <summary>
    ///   <para>scip:hasAuthoredTaxonomicOpinion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAuthoredTaxonomicComment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredTaxonomicOpinion">http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredTaxonomicOpinion</seealso>
    let hasAuthoredTaxonomicOpinion =
        Prefixed_Name(scip, "hasAuthoredTaxonomicOpinion") |> PrefixedName

    /// <summary>
    ///   <para>scip:hasAuthoredTaxonomicRevision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAuthoredTaxonomicRevision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredTaxonomicRevision">http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredTaxonomicRevision</seealso>
    let hasAuthoredTaxonomicRevision =
        Prefixed_Name(scip, "hasAuthoredTaxonomicRevision") |> PrefixedName

    /// <summary>
    ///   <para>scip:hasAuthoredWebComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAuthoredWebComment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredWebComment">http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredWebComment</seealso>
    let hasAuthoredWebComment =
        Prefixed_Name(scip, "hasAuthoredWebComment") |> PrefixedName

    /// <summary>
    ///   <para>scip:hasAuthoredWebPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasAuthoredWebPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredWebPage">http://lod.taxonconcept.org/ontology/sci_people.owl#hasAuthoredWebPage</seealso>
    let hasAuthoredWebPage = Prefixed_Name(scip, "hasAuthoredWebPage") |> PrefixedName
    /// <summary>
    ///   <para>scip:hasBlog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasBlog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasBlog">http://lod.taxonconcept.org/ontology/sci_people.owl#hasBlog</seealso>
    let hasBlog = Prefixed_Name(scip, "hasBlog") |> PrefixedName

    /// <summary>
    ///   <para>scip:hasPublicationListHTML</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasPublicationListHTML"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasPublicationListHTML">http://lod.taxonconcept.org/ontology/sci_people.owl#hasPublicationListHTML</seealso>
    let hasPublicationListHTML =
        Prefixed_Name(scip, "hasPublicationListHTML") |> PrefixedName

    /// <summary>
    ///   <para>scip:hasPublicationListRDF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasPublicationListRDF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasPublicationListRDF">http://lod.taxonconcept.org/ontology/sci_people.owl#hasPublicationListRDF</seealso>
    let hasPublicationListRDF =
        Prefixed_Name(scip, "hasPublicationListRDF") |> PrefixedName

    /// <summary>
    ///   <para>scip:hasRevisedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasRevisedName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasRevisedName">http://lod.taxonconcept.org/ontology/sci_people.owl#hasRevisedName</seealso>
    let hasRevisedName = Prefixed_Name(scip, "hasRevisedName") |> PrefixedName
    /// <summary>
    ///   <para>scip:hasTaxonomicAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasTaxonomicAuthor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasTaxonomicAuthor">http://lod.taxonconcept.org/ontology/sci_people.owl#hasTaxonomicAuthor</seealso>
    let hasTaxonomicAuthor = Prefixed_Name(scip, "hasTaxonomicAuthor") |> PrefixedName
    /// <summary>
    ///   <para>scip:hasTaxonomicRevisor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasTaxonomicRevisor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasTaxonomicRevisor">http://lod.taxonconcept.org/ontology/sci_people.owl#hasTaxonomicRevisor</seealso>
    let hasTaxonomicRevisor = Prefixed_Name(scip, "hasTaxonomicRevisor") |> PrefixedName
    /// <summary>
    ///   <para>scip:hasWorkedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasWorkedWith"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#hasWorkedWith">http://lod.taxonconcept.org/ontology/sci_people.owl#hasWorkedWith</seealso>
    let hasWorkedWith = Prefixed_Name(scip, "hasWorkedWith") |> PrefixedName

    /// <summary>
    ///   <para>scip:isOriginalAuthorOfRecGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isOriginalAuthorOfRecGroup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#isOriginalAuthorOfRecGroup">http://lod.taxonconcept.org/ontology/sci_people.owl#isOriginalAuthorOfRecGroup</seealso>
    let isOriginalAuthorOfRecGroup =
        Prefixed_Name(scip, "isOriginalAuthorOfRecGroup") |> PrefixedName

    /// <summary>
    ///   <para>scip:isOriginalAuthorOfSpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isOriginalAuthorOfSpecies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#isOriginalAuthorOfSpecies">http://lod.taxonconcept.org/ontology/sci_people.owl#isOriginalAuthorOfSpecies</seealso>
    let isOriginalAuthorOfSpecies =
        Prefixed_Name(scip, "isOriginalAuthorOfSpecies") |> PrefixedName

    /// <summary>
    ///   <para>scip:isOriginalAuthorOfTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isOriginalAuthorOfTaxon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#isOriginalAuthorOfTaxon">http://lod.taxonconcept.org/ontology/sci_people.owl#isOriginalAuthorOfTaxon</seealso>
    let isOriginalAuthorOfTaxon =
        Prefixed_Name(scip, "isOriginalAuthorOfTaxon") |> PrefixedName

    /// <summary>
    ///   <para>scip:isOriginalAuthorOfTaxonLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"isOrignalAuthorOfTaxonLiteral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#isOriginalAuthorOfTaxonLiteral">http://lod.taxonconcept.org/ontology/sci_people.owl#isOriginalAuthorOfTaxonLiteral</seealso>
    let isOriginalAuthorOfTaxonLiteral =
        Prefixed_Name(scip, "isOriginalAuthorOfTaxonLiteral") |> PrefixedName

    /// <summary>
    ///   <para>scip:isRevisionalAuthorOfRecGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isRevisionalAuthorOfRecGroup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#isRevisionalAuthorOfRecGroup">http://lod.taxonconcept.org/ontology/sci_people.owl#isRevisionalAuthorOfRecGroup</seealso>
    let isRevisionalAuthorOfRecGroup =
        Prefixed_Name(scip, "isRevisionalAuthorOfRecGroup") |> PrefixedName

    /// <summary>
    ///   <para>scip:isRevisionalAuthorOfSpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isRevisionalAuthorOfSpecies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#isRevisionalAuthorOfSpecies">http://lod.taxonconcept.org/ontology/sci_people.owl#isRevisionalAuthorOfSpecies</seealso>
    let isRevisionalAuthorOfSpecies =
        Prefixed_Name(scip, "isRevisionalAuthorOfSpecies") |> PrefixedName

    /// <summary>
    ///   <para>scip:isRevisionalAuthorOfTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isRevisionalAuthorOfTaxon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#isRevisionalAuthorOfTaxon">http://lod.taxonconcept.org/ontology/sci_people.owl#isRevisionalAuthorOfTaxon</seealso>
    let isRevisionalAuthorOfTaxon =
        Prefixed_Name(scip, "isRevisionalAuthorOfTaxon") |> PrefixedName

    /// <summary>
    ///   <para>scip:isRevisionalAuthorOfTaxonLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"isRevisionalAuthorOfTaxonLiteral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#isRevisionalAuthorOfTaxonLiteral">http://lod.taxonconcept.org/ontology/sci_people.owl#isRevisionalAuthorOfTaxonLiteral</seealso>
    let isRevisionalAuthorOfTaxonLiteral =
        Prefixed_Name(scip, "isRevisionalAuthorOfTaxonLiteral") |> PrefixedName

    /// <summary>
    ///   <para>scip:personAltPublicationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"altNameInPublication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#personAltPublicationName">http://lod.taxonconcept.org/ontology/sci_people.owl#personAltPublicationName</seealso>
    let personAltPublicationName =
        Prefixed_Name(scip, "personAltPublicationName") |> PrefixedName

    /// <summary>
    ///   <para>scip:personAuthorAbbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"personAuthorAbbreviation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#personAuthorAbbreviation">http://lod.taxonconcept.org/ontology/sci_people.owl#personAuthorAbbreviation</seealso>
    let personAuthorAbbreviation =
        Prefixed_Name(scip, "personAuthorAbbreviation") |> PrefixedName

    /// <summary>
    ///   <para>scip:personFirstname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"person_firstname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#personFirstname">http://lod.taxonconcept.org/ontology/sci_people.owl#personFirstname</seealso>
    let personFirstname = Prefixed_Name(scip, "personFirstname") |> PrefixedName
    /// <summary>
    ///   <para>scip:personFullname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"personFullName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#personFullname">http://lod.taxonconcept.org/ontology/sci_people.owl#personFullname</seealso>
    let personFullname = Prefixed_Name(scip, "personFullname") |> PrefixedName

    /// <summary>
    ///   <para>scip:personHasWikispeciesPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"personHasWikispeciesPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#personHasWikispeciesPage">http://lod.taxonconcept.org/ontology/sci_people.owl#personHasWikispeciesPage</seealso>
    let personHasWikispeciesPage =
        Prefixed_Name(scip, "personHasWikispeciesPage") |> PrefixedName

    /// <summary>
    ///   <para>scip:personLastname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"person_lastname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#personLastname">http://lod.taxonconcept.org/ontology/sci_people.owl#personLastname</seealso>
    let personLastname = Prefixed_Name(scip, "personLastname") |> PrefixedName
    /// <summary>
    ///   <para>scip:personMiddleInitial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"personMiddleInitial"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#personMiddleInitial">http://lod.taxonconcept.org/ontology/sci_people.owl#personMiddleInitial</seealso>
    let personMiddleInitial = Prefixed_Name(scip, "personMiddleInitial") |> PrefixedName
    /// <summary>
    ///   <para>scip:personMiddlename</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"person_middename"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#personMiddlename">http://lod.taxonconcept.org/ontology/sci_people.owl#personMiddlename</seealso>
    let personMiddlename = Prefixed_Name(scip, "personMiddlename") |> PrefixedName

    /// <summary>
    ///   <para>scip:personPublicationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"nameInPublication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#personPublicationName">http://lod.taxonconcept.org/ontology/sci_people.owl#personPublicationName</seealso>
    let personPublicationName =
        Prefixed_Name(scip, "personPublicationName") |> PrefixedName

    /// <summary>
    ///   <para>scip:personUsedScientificMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"personUsedScientificMethod"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#personUsedScientificMethod">http://lod.taxonconcept.org/ontology/sci_people.owl#personUsedScientificMethod</seealso>
    let personUsedScientificMethod =
        Prefixed_Name(scip, "personUsedScientificMethod") |> PrefixedName

    /// <summary>
    ///   <para>scip:personWikipediaPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"personWikipediaPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#personWikipediaPage">http://lod.taxonconcept.org/ontology/sci_people.owl#personWikipediaPage</seealso>
    let personWikipediaPage = Prefixed_Name(scip, "personWikipediaPage") |> PrefixedName

    /// <summary>
    ///   <para>scip:personWikispeciesPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"personWikispeciesPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#personWikispeciesPage">http://lod.taxonconcept.org/ontology/sci_people.owl#personWikispeciesPage</seealso>
    let personWikispeciesPage =
        Prefixed_Name(scip, "personWikispeciesPage") |> PrefixedName

    /// <summary>
    ///   <para>scip:personWorkpage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"personWorkpage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#personWorkpage">http://lod.taxonconcept.org/ontology/sci_people.owl#personWorkpage</seealso>
    let personWorkpage = Prefixed_Name(scip, "personWorkpage") |> PrefixedName
    /// <summary>
    ///   <para>scip:personWorkplacePage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"personWorkplacePage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#personWorkplacePage">http://lod.taxonconcept.org/ontology/sci_people.owl#personWorkplacePage</seealso>
    let personWorkplacePage = Prefixed_Name(scip, "personWorkplacePage") |> PrefixedName

    /// <summary>
    ///   <para>scip:personhasWikipediaPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"personhasWikipediaPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#personhasWikipediaPage">http://lod.taxonconcept.org/ontology/sci_people.owl#personhasWikipediaPage</seealso>
    let personhasWikipediaPage =
        Prefixed_Name(scip, "personhasWikipediaPage") |> PrefixedName

    /// <summary>
    ///   <para>scip:referencesScientificMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"referencesScientificMethod"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#referencesScientificMethod">http://lod.taxonconcept.org/ontology/sci_people.owl#referencesScientificMethod</seealso>
    let referencesScientificMethod =
        Prefixed_Name(scip, "referencesScientificMethod") |> PrefixedName

    /// <summary>
    ///   <para>scip:yearOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"yearOfBirth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#yearOfBirth">http://lod.taxonconcept.org/ontology/sci_people.owl#yearOfBirth</seealso>
    let yearOfBirth = Prefixed_Name(scip, "yearOfBirth") |> PrefixedName
    /// <summary>
    ///   <para>scip:yearOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"yearOfDeath"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://lod.taxonconcept.org/ontology/sci_people.owl#yearOfDeath">http://lod.taxonconcept.org/ontology/sci_people.owl#yearOfDeath</seealso>
    let yearOfDeath = Prefixed_Name(scip, "yearOfDeath") |> PrefixedName
