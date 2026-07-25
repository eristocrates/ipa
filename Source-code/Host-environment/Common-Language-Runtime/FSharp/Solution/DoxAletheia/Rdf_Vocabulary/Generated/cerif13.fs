namespace http.www.eurocris.org.ontologies.cerif._1._3.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cerif13 =
    let _namespace_iri = Namespace_Iri cerif13 |> NamespaceIRI
    /// <summary>
    ///   <para>cerif13:keith</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#keith">http://www.eurocris.org/ontologies/cerif/1.3#keith</seealso>
    let keith = Prefixed_Name(cerif13, "keith") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:geert</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#geert">http://www.eurocris.org/ontologies/cerif/1.3#geert</seealso>
    let geert = Prefixed_Name(cerif13, "geert") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:Cite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Cite</para>
    /// labels<para>Cite</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#Cite">http://www.eurocris.org/ontologies/cerif/1.3#Cite</seealso>
    let Cite = Prefixed_Name(cerif13, "Cite") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:fundingCurrencyCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Currency code used to denote the funding amount</para>
    /// labels<para>Funding Currency Code</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#fundingCurrencyCode">http://www.eurocris.org/ontologies/cerif/1.3#fundingCurrencyCode</seealso>
    let fundingCurrencyCode =
        Prefixed_Name(cerif13, "fundingCurrencyCode") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:internalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Internal Identifier for a research entity. It fits with the primary key in the corresponding table from the internal database</para>
    /// labels<para>Internal Identifier</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#internalIdentifier">http://www.eurocris.org/ontologies/cerif/1.3#internalIdentifier</seealso>
    let internalIdentifier =
        Prefixed_Name(cerif13, "internalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:isClassifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A entity is classified within a time interval according to CERIF Semantic Vocabulary.</para>
    /// labels<para>Is Classified By</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#isClassifiedBy">http://www.eurocris.org/ontologies/cerif/1.3#isClassifiedBy</seealso>
    let isClassifiedBy = Prefixed_Name(cerif13, "isClassifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:isLinkedByFunding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A given Funding is related with a entity through a time-stamped link.</para>
    /// labels<para>Is Linked By Funding</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByFunding">http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByFunding</seealso>
    let isLinkedByFunding = Prefixed_Name(cerif13, "isLinkedByFunding") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:brigitte</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#brigitte">http://www.eurocris.org/ontologies/cerif/1.3#brigitte</seealso>
    let brigitte = Prefixed_Name(cerif13, "brigitte") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:BaseEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>This abstract class brings together the main entities of the CERIF model.</para>
    /// labels<para>Base Entity</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#BaseEntity">http://www.eurocris.org/ontologies/cerif/1.3#BaseEntity</seealso>
    let BaseEntity = Prefixed_Name(cerif13, "BaseEntity") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:cityTown</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>City Town of an physical localisation</para>
    /// labels<para>City Town</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#cityTown">http://www.eurocris.org/ontologies/cerif/1.3#cityTown</seealso>
    let cityTown = Prefixed_Name(cerif13, "cityTown") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:link</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>It is a generalisation for relationship and classification properties</para>
    /// labels<para>Link</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#link">http://www.eurocris.org/ontologies/cerif/1.3#link</seealso>
    let link = Prefixed_Name(cerif13, "link") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:countryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>International code of a given country </para>
    /// labels<para>Country Code</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#countryCode">http://www.eurocris.org/ontologies/cerif/1.3#countryCode</seealso>
    let countryCode = Prefixed_Name(cerif13, "countryCode") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Common superclass of all non-link entities, as an aid in querying.</para>
    /// labels<para>Entity</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#Entity">http://www.eurocris.org/ontologies/cerif/1.3#Entity</seealso>
    let Entity = Prefixed_Name(cerif13, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Event</para>
    /// labels<para>Event</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#Event">http://www.eurocris.org/ontologies/cerif/1.3#Event</seealso>
    let Event = Prefixed_Name(cerif13, "Event") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:Facility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Facility</para>
    /// labels<para>Facility</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#Facility">http://www.eurocris.org/ontologies/cerif/1.3#Facility</seealso>
    let Facility = Prefixed_Name(cerif13, "Facility") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:postCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Postal Code of a given Address</para>
    /// labels<para>Post Code</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#postCode">http://www.eurocris.org/ontologies/cerif/1.3#postCode</seealso>
    let postCode = Prefixed_Name(cerif13, "postCode") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:priceCurrencyCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Price Currency Code</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#priceCurrencyCode">http://www.eurocris.org/ontologies/cerif/1.3#priceCurrencyCode</seealso>
    let priceCurrencyCode = Prefixed_Name(cerif13, "priceCurrencyCode") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:productNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Number of a Product</para>
    /// labels<para>Product Number</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#productNumber">http://www.eurocris.org/ontologies/cerif/1.3#productNumber</seealso>
    let productNumber = Prefixed_Name(cerif13, "productNumber") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:languageCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>International code of a given language</para>
    /// labels<para>Language Code</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#languageCode">http://www.eurocris.org/ontologies/cerif/1.3#languageCode</seealso>
    let languageCode = Prefixed_Name(cerif13, "languageCode") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:manufacturerIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The equipment manufacturer's ID.</para>
    /// labels<para>Manufacturer Identifier</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#manufacturerIdentifier">http://www.eurocris.org/ontologies/cerif/1.3#manufacturerIdentifier</seealso>
    let manufacturerIdentifier =
        Prefixed_Name(cerif13, "manufacturerIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:patentNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Number of a Registered Patent</para>
    /// labels<para>Patent Number</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#patentNumber">http://www.eurocris.org/ontologies/cerif/1.3#patentNumber</seealso>
    let patentNumber = Prefixed_Name(cerif13, "patentNumber") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:price</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Quantity of payment or compensation given by one party to another in return for goods or service (measured in a specific currency)</para>
    /// labels<para>Price</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#price">http://www.eurocris.org/ontologies/cerif/1.3#price</seealso>
    let price = Prefixed_Name(cerif13, "price") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:registrationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Registration Date of a patent</para>
    /// labels<para>Registration Date</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#registrationDate">http://www.eurocris.org/ontologies/cerif/1.3#registrationDate</seealso>
    let registrationDate = Prefixed_Name(cerif13, "registrationDate") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:researchInterests</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Research Interests</para>
    /// labels<para>Research Interests</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#researchInterests">http://www.eurocris.org/ontologies/cerif/1.3#researchInterests</seealso>
    let researchInterests = Prefixed_Name(cerif13, "researchInterests") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Beginning of a period of time</para>
    /// labels<para>Start Date</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#startDate">http://www.eurocris.org/ontologies/cerif/1.3#startDate</seealso>
    let startDate = Prefixed_Name(cerif13, "startDate") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Uniform Resource Identifier related with a given CERIF entity</para>
    /// labels<para>URI</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#uri">http://www.eurocris.org/ontologies/cerif/1.3#uri</seealso>
    let uri = Prefixed_Name(cerif13, "uri") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:InfrastructureEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Abstract entity for representing infrastructures</para>
    /// labels<para>Infrastructure Entity</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#InfrastructureEntity">http://www.eurocris.org/ontologies/cerif/1.3#InfrastructureEntity</seealso>
    let InfrastructureEntity =
        Prefixed_Name(cerif13, "InfrastructureEntity") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:Funding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Funding</para>
    /// labels<para>Funding</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#Funding">http://www.eurocris.org/ontologies/cerif/1.3#Funding</seealso>
    let Funding = Prefixed_Name(cerif13, "Funding") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:OrganizationalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A given organizational unit</para>
    /// labels<para>Organizational Unit (cfOrgUnit)</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#OrganizationalUnit">http://www.eurocris.org/ontologies/cerif/1.3#OrganizationalUnit</seealso>
    let OrganizationalUnit =
        Prefixed_Name(cerif13, "OrganizationalUnit") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A given person</para>
    /// labels<para>Person (cfPers)</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#Person">http://www.eurocris.org/ontologies/cerif/1.3#Person</seealso>
    let Person = Prefixed_Name(cerif13, "Person") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:PostalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Postal Address</para>
    /// labels<para>Postal Address</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#PostalAddress">http://www.eurocris.org/ontologies/cerif/1.3#PostalAddress</seealso>
    let PostalAddress = Prefixed_Name(cerif13, "PostalAddress") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A research result that is classified neither as a patent nor as a publication.</para>
    /// labels<para>Product</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#Product">http://www.eurocris.org/ontologies/cerif/1.3#Product</seealso>
    let Product = Prefixed_Name(cerif13, "Product") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:Qualification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Qualification</para>
    /// labels<para>Qualification</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#Qualification">http://www.eurocris.org/ontologies/cerif/1.3#Qualification</seealso>
    let Qualification = Prefixed_Name(cerif13, "Qualification") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>intermediate entity between two entities.</para>
    /// labels<para>Relationship</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#Relationship">http://www.eurocris.org/ontologies/cerif/1.3#Relationship</seealso>
    let Relationship = Prefixed_Name(cerif13, "Relationship") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Abstract of a given Project</para>
    /// labels<para>Abstract</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#abstract">http://www.eurocris.org/ontologies/cerif/1.3#abstract</seealso>
    let abstract_ = Prefixed_Name(cerif13, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:addressLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Numbered line of a given postal address</para>
    /// labels<para>Address Line</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#addressLine">http://www.eurocris.org/ontologies/cerif/1.3#addressLine</seealso>
    let addressLine = Prefixed_Name(cerif13, "addressLine") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:ExpSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Expertise and skills</para>
    /// labels<para>Expertise and skills</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#ExpSkill">http://www.eurocris.org/ontologies/cerif/1.3#ExpSkill</seealso>
    let ExpSkill = Prefixed_Name(cerif13, "ExpSkill") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:Metrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Metrics</para>
    /// labels<para>Metrics</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#Metrics">http://www.eurocris.org/ontologies/cerif/1.3#Metrics</seealso>
    let Metrics = Prefixed_Name(cerif13, "Metrics") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:Patent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A registered patent as a research result</para>
    /// labels<para>Patent</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#Patent">http://www.eurocris.org/ontologies/cerif/1.3#Patent</seealso>
    let Patent = Prefixed_Name(cerif13, "Patent") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:ResultEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a research result</para>
    /// labels<para>Result Entity</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#ResultEntity">http://www.eurocris.org/ontologies/cerif/1.3#ResultEntity</seealso>
    let ResultEntity = Prefixed_Name(cerif13, "ResultEntity") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:PriceAward</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Price Award</para>
    /// labels<para>Price Award</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#PriceAward">http://www.eurocris.org/ontologies/cerif/1.3#PriceAward</seealso>
    let PriceAward = Prefixed_Name(cerif13, "PriceAward") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A research project</para>
    /// labels<para>Project</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#Project">http://www.eurocris.org/ontologies/cerif/1.3#Project</seealso>
    let Project = Prefixed_Name(cerif13, "Project") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:turnover</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Turnover of a Organisation Unit (measured in a specific currency)</para>
    /// labels<para>Turnover</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#turnover">http://www.eurocris.org/ontologies/cerif/1.3#turnover</seealso>
    let turnover = Prefixed_Name(cerif13, "turnover") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a scientific or academic publication </para>
    /// labels<para>Publication</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#Publication">http://www.eurocris.org/ontologies/cerif/1.3#Publication</seealso>
    let Publication = Prefixed_Name(cerif13, "Publication") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Service</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#Service">http://www.eurocris.org/ontologies/cerif/1.3#Service</seealso>
    let Service = Prefixed_Name(cerif13, "Service") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:acronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Acronym of a given Project or an Organisation Unit</para>
    /// labels<para>Acronym</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#acronym">http://www.eurocris.org/ontologies/cerif/1.3#acronym</seealso>
    let acronym = Prefixed_Name(cerif13, "acronym") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:agrovoc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>External Classification Scheme according to Agrovoc Vocabulary</para>
    /// labels<para>Agrovoc Classification</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#agrovoc">http://www.eurocris.org/ontologies/cerif/1.3#agrovoc</seealso>
    let agrovoc = Prefixed_Name(cerif13, "agrovoc") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:approvalDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Approval Date of a patent</para>
    /// labels<para>Approval Date</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#approvalDate">http://www.eurocris.org/ontologies/cerif/1.3#approvalDate</seealso>
    let approvalDate = Prefixed_Name(cerif13, "approvalDate") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:birthdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>BirthDate of a Person</para>
    /// labels<para>Birthdate</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#birthdate">http://www.eurocris.org/ontologies/cerif/1.3#birthdate</seealso>
    let birthdate = Prefixed_Name(cerif13, "birthdate") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Generic property for represent international and shared codes</para>
    /// labels<para>Code</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#code">http://www.eurocris.org/ontologies/cerif/1.3#code</seealso>
    let code = Prefixed_Name(cerif13, "code") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specific currency used for denote amounts, prices and turnovers. Linking with http://dbpedia.org/ontology/Language</para>
    /// labels<para>Currency</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#currency">http://www.eurocris.org/ontologies/cerif/1.3#currency</seealso>
    let currency = Prefixed_Name(cerif13, "currency") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>End of a period of time</para>
    /// labels<para>End Date</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#endDate">http://www.eurocris.org/ontologies/cerif/1.3#endDate</seealso>
    let endDate = Prefixed_Name(cerif13, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:digitalCV</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Digital CV</para>
    /// labels<para>Digital CV</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#digitalCV">http://www.eurocris.org/ontologies/cerif/1.3#digitalCV</seealso>
    let digitalCV = Prefixed_Name(cerif13, "digitalCV") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a classification for a entity according to a suitable external vocabulary</para>
    /// labels<para>Classification</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#classification">http://www.eurocris.org/ontologies/cerif/1.3#classification</seealso>
    let classification = Prefixed_Name(cerif13, "classification") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A given country - http://dbpedia.org/ontology/Country</para>
    /// labels<para>Country </para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#country">http://www.eurocris.org/ontologies/cerif/1.3#country</seealso>
    let country = Prefixed_Name(cerif13, "country") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:currencyCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Code of a specific currency used for denote amounts, prices and turnovers.</para>
    /// labels<para>Currency Code</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#currencyCode">http://www.eurocris.org/ontologies/cerif/1.3#currencyCode</seealso>
    let currencyCode = Prefixed_Name(cerif13, "currencyCode") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:feeOrFree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Flag indicating if the event is fee or free</para>
    /// labels<para>Fee Or Free</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#feeOrFree">http://www.eurocris.org/ontologies/cerif/1.3#feeOrFree</seealso>
    let feeOrFree = Prefixed_Name(cerif13, "feeOrFree") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:funding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Amount of a given Funding (measured in a specific currency)</para>
    /// labels<para>Funding</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#funding">http://www.eurocris.org/ontologies/cerif/1.3#funding</seealso>
    let funding = Prefixed_Name(cerif13, "funding") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:fraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Fractional value to indicate a classification reference or a % allocation in the relationship between entities.</para>
    /// labels<para>Fraction</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#fraction">http://www.eurocris.org/ontologies/cerif/1.3#fraction</seealso>
    let fraction = Prefixed_Name(cerif13, "fraction") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:money</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This property embraces all Currency-dependent properties </para>
    /// labels<para>Money</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#money">http://www.eurocris.org/ontologies/cerif/1.3#money</seealso>
    let money = Prefixed_Name(cerif13, "money") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:headcount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Number of persons enrolled in a Organisation Unit</para>
    /// labels<para>Headcount</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#headcount">http://www.eurocris.org/ontologies/cerif/1.3#headcount</seealso>
    let headcount = Prefixed_Name(cerif13, "headcount") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Gender of a CERIF person</para>
    /// labels<para>Gender</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#gender">http://www.eurocris.org/ontologies/cerif/1.3#gender</seealso>
    let gender = Prefixed_Name(cerif13, "gender") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:inventoryIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The equipment owner's inventory identifier.</para>
    /// labels<para>Inventory Identifier</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#inventoryIdentifier">http://www.eurocris.org/ontologies/cerif/1.3#inventoryIdentifier</seealso>
    let inventoryIdentifier =
        Prefixed_Name(cerif13, "inventoryIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:isLinkedByEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This is an abstract property to group all properties that inversely relate a entity with other through a time-stamped link.</para>
    /// labels<para>Is Linked by Entity</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByEntity">http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByEntity</seealso>
    let isLinkedByEntity = Prefixed_Name(cerif13, "isLinkedByEntity") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:isLinkedByOrganisationUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A given Organisation Unit is related with a entity through a time-stamped link.</para>
    /// labels<para>Is Linked By a Organisation Unit</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByOrganisationUnit">http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByOrganisationUnit</seealso>
    let isLinkedByOrganisationUnit =
        Prefixed_Name(cerif13, "isLinkedByOrganisationUnit") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:isLinkedByProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A given Project is related with a entity through a time-stamped link.</para>
    /// labels<para>is Linked By Project</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByProject">http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByProject</seealso>
    let isLinkedByProject = Prefixed_Name(cerif13, "isLinkedByProject") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:isLinkedByPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A given Person is related with a entity through a time-stamped link. </para>
    /// labels<para>Is Linked By a Person</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByPerson">http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByPerson</seealso>
    let isLinkedByPerson = Prefixed_Name(cerif13, "isLinkedByPerson") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:isLinkedByPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A given Publication is related with a entity through a time-stamped link.</para>
    /// labels<para>is Linked By Publication</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByPublication">http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByPublication</seealso>
    let isLinkedByPublication =
        Prefixed_Name(cerif13, "isLinkedByPublication") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:linksToEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This is an abstract property to group all properties that directly relate a entity with other through a time-stamped link.</para>
    /// labels<para>Links to Entity</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#linksToEntity">http://www.eurocris.org/ontologies/cerif/1.3#linksToEntity</seealso>
    let linksToEntity = Prefixed_Name(cerif13, "linksToEntity") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:linksToPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>It relates a entity with a given Person through a time-stamped link.</para>
    /// labels<para>Is Linked By a Person</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#linksToPerson">http://www.eurocris.org/ontologies/cerif/1.3#linksToPerson</seealso>
    let linksToPerson = Prefixed_Name(cerif13, "linksToPerson") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:linksToProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>It relates a  entity with a given Project through a time-stamped link.</para>
    /// labels<para>Links To a Project</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#linksToProject">http://www.eurocris.org/ontologies/cerif/1.3#linksToProject</seealso>
    let linksToProject = Prefixed_Name(cerif13, "linksToProject") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Keywords of a given entity</para>
    /// labels<para>Keyword</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#keyword">http://www.eurocris.org/ontologies/cerif/1.3#keyword</seealso>
    let keyword = Prefixed_Name(cerif13, "keyword") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:linksToOrganisationUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>It relates a entity with a given Organisation Unit through a time-stamped link.</para>
    /// labels<para>Links To a Organisation Unit</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#linksToOrganisationUnit">http://www.eurocris.org/ontologies/cerif/1.3#linksToOrganisationUnit</seealso>
    let linksToOrganisationUnit =
        Prefixed_Name(cerif13, "linksToOrganisationUnit") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A given language. Linking to http://dbpedia.org/ontology/Language</para>
    /// labels<para>Language</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#language">http://www.eurocris.org/ontologies/cerif/1.3#language</seealso>
    let language = Prefixed_Name(cerif13, "language") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:linksToFunding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>It relates a entity with a given Funding entity through a time-stamped link.</para>
    /// labels<para>Links to Funding</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#linksToFunding">http://www.eurocris.org/ontologies/cerif/1.3#linksToFunding</seealso>
    let linksToFunding = Prefixed_Name(cerif13, "linksToFunding") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:linksToPostalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>It relates a entity with a given Postal Address through a time-stamped link. Used, for example, in Persons and Organisation Units</para>
    /// labels<para>Links to a Postal Address</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#linksToPostalAddress">http://www.eurocris.org/ontologies/cerif/1.3#linksToPostalAddress</seealso>
    let linksToPostalAddress =
        Prefixed_Name(cerif13, "linksToPostalAddress") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:linksToPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>It relates a entity with a given Publication through a time-stamped link.</para>
    /// labels<para>Links To a Publication</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#linksToPublication">http://www.eurocris.org/ontologies/cerif/1.3#linksToPublication</seealso>
    let linksToPublication =
        Prefixed_Name(cerif13, "linksToPublication") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Name of a CERIF entity, e.g.: Person, or Organization Unit</para>
    /// labels<para>Name</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#name">http://www.eurocris.org/ontologies/cerif/1.3#name</seealso>
    let name = Prefixed_Name(cerif13, "name") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:msicilia</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#msicilia">http://www.eurocris.org/ontologies/cerif/1.3#msicilia</seealso>
    let msicilia = Prefixed_Name(cerif13, "msicilia") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:jan</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#jan">http://www.eurocris.org/ontologies/cerif/1.3#jan</seealso>
    let jan = Prefixed_Name(cerif13, "jan") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:ruizrube</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#ruizrube">http://www.eurocris.org/ontologies/cerif/1.3#ruizrube</seealso>
    let ruizrube = Prefixed_Name(cerif13, "ruizrube") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:SecondLevelEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The 2nd level entities allow for the representation of the research context by linking to them from the base and result entities.</para>
    /// labels<para>Second-level Entity</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#SecondLevelEntity">http://www.eurocris.org/ontologies/cerif/1.3#SecondLevelEntity</seealso>
    let SecondLevelEntity = Prefixed_Name(cerif13, "SecondLevelEntity") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents the classification of a given entity</para>
    /// labels<para>Classification</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#Classification">http://www.eurocris.org/ontologies/cerif/1.3#Classification</seealso>
    let Classification = Prefixed_Name(cerif13, "Classification") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:CurriculumVitae</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Curriculum Vitae</para>
    /// labels<para>Curriculum Vitae</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#CurriculumVitae">http://www.eurocris.org/ontologies/cerif/1.3#CurriculumVitae</seealso>
    let CurriculumVitae = Prefixed_Name(cerif13, "CurriculumVitae") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:ElectronicAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>ElectronicAddress</para>
    /// labels<para>Electronic Address</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#ElectronicAddress">http://www.eurocris.org/ontologies/cerif/1.3#ElectronicAddress</seealso>
    let ElectronicAddress = Prefixed_Name(cerif13, "ElectronicAddress") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:Equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Equipment</para>
    /// labels<para>Equipment</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#Equipment">http://www.eurocris.org/ontologies/cerif/1.3#Equipment</seealso>
    let Equipment = Prefixed_Name(cerif13, "Equipment") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:researchActivities</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Research Activities</para>
    /// labels<para>Research Activities</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#researchActivities">http://www.eurocris.org/ontologies/cerif/1.3#researchActivities</seealso>
    let researchActivities =
        Prefixed_Name(cerif13, "researchActivities") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a role for the association or composition between two CERIF entities indicated by a term from a suitable external vocabulary</para>
    /// labels<para>Role</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#role">http://www.eurocris.org/ontologies/cerif/1.3#role</seealso>
    let role = Prefixed_Name(cerif13, "role") |> PrefixedName
    /// <summary>
    ///   <para>cerif13:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Title of a given CERIF entity</para>
    /// labels<para>Title</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#title">http://www.eurocris.org/ontologies/cerif/1.3#title</seealso>
    let title = Prefixed_Name(cerif13, "title") |> PrefixedName

    /// <summary>
    ///   <para>cerif13:turnoverCurrencyCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Currency Code used to denote turnovers</para>
    /// labels<para>Turnover Currency Code</para></remarks>
    /// <seealso href="http://www.eurocris.org/ontologies/cerif/1.3#turnoverCurrencyCode">http://www.eurocris.org/ontologies/cerif/1.3#turnoverCurrencyCode</seealso>
    let turnoverCurrencyCode =
        Prefixed_Name(cerif13, "turnoverCurrencyCode") |> PrefixedName
