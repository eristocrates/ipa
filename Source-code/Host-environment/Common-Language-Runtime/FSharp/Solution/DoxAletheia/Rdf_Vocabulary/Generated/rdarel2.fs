namespace http.metadataregistry.org.uri.schema.RDARelationshipsGR2.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdarel2 =
    let _namespace_iri = Namespace_Iri rdarel2 |> NamespaceIRI
    /// <summary>
    ///   <para>rdarel2:alternateIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"andere Identität"</para><para>"Alternate identity"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/alternateIdentity">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/alternateIdentity</seealso>
    let alternateIdentity = Prefixed_Name(rdarel2, "alternateIdentity") |> PrefixedName
    /// <summary>
    ///   <para>rdarel2:descendantFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Abstammende Familie"</para><para>"Descendant Family"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/descendantFamily">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/descendantFamily</seealso>
    let descendantFamily = Prefixed_Name(rdarel2, "descendantFamily") |> PrefixedName
    /// <summary>
    ///   <para>rdarel2:descendants</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Nachkommen"</para><para>"Descendants"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/descendants">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/descendants</seealso>
    let descendants = Prefixed_Name(rdarel2, "descendants") |> PrefixedName
    /// <summary>
    ///   <para>rdarel2:employee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Arbeitnehmer"</para><para>"Employee"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/employee">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/employee</seealso>
    let employee = Prefixed_Name(rdarel2, "employee") |> PrefixedName
    /// <summary>
    ///   <para>rdarel2:employer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Arbeitgeber"</para><para>"Employer"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/employer">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/employer</seealso>
    let employer = Prefixed_Name(rdarel2, "employer") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:explanationOfRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Explanation of Relationship"</para><para>"Erläuterung der Beziehung"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/explanationOfRelationship">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/explanationOfRelationship</seealso>
    let explanationOfRelationship =
        Prefixed_Name(rdarel2, "explanationOfRelationship") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:familyMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Familienmitglied"</para><para>"Family member"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/familyMember">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/familyMember</seealso>
    let familyMember = Prefixed_Name(rdarel2, "familyMember") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:foundedOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"gegründete Organisation"</para><para>"Founded organization"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/foundedOrganization">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/foundedOrganization</seealso>
    let foundedOrganization =
        Prefixed_Name(rdarel2, "foundedOrganization") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:founder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Gründer"</para><para>"Founder"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/founder">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/founder</seealso>
    let founder = Prefixed_Name(rdarel2, "founder") |> PrefixedName
    /// <summary>
    ///   <para>rdarel2:foundingFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Gründerfamilie"</para><para>"Founding Family"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/foundingFamily">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/foundingFamily</seealso>
    let foundingFamily = Prefixed_Name(rdarel2, "foundingFamily") |> PrefixedName
    /// <summary>
    ///   <para>rdarel2:groupMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Group member"</para><para>"Gruppenmitglied"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/groupMember">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/groupMember</seealso>
    let groupMember = Prefixed_Name(rdarel2, "groupMember") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:hierarchicalSubordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"untergeordnete Körperschaft"</para><para>"Hierarchical subordinate"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/hierarchicalSubordinate">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/hierarchicalSubordinate</seealso>
    let hierarchicalSubordinate =
        Prefixed_Name(rdarel2, "hierarchicalSubordinate") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:hierarchicalSuperior</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Hierarchical superior"</para><para>"übergeordnete Körperschaft"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/hierarchicalSuperior">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/hierarchicalSuperior</seealso>
    let hierarchicalSuperior =
        Prefixed_Name(rdarel2, "hierarchicalSuperior") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:incumbent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Amtsinhaber"</para><para>"Incumbent"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/incumbent">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/incumbent</seealso>
    let incumbent = Prefixed_Name(rdarel2, "incumbent") |> PrefixedName
    /// <summary>
    ///   <para>rdarel2:mergee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Mergee"</para><para>"fusionierte Körperschaft"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/mergee">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/mergee</seealso>
    let mergee = Prefixed_Name(rdarel2, "mergee") |> PrefixedName
    /// <summary>
    ///   <para>rdarel2:predecessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Vorgänger"</para><para>"Predecessor"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/predecessor">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/predecessor</seealso>
    let predecessor = Prefixed_Name(rdarel2, "predecessor") |> PrefixedName
    /// <summary>
    ///   <para>rdarel2:productOfAMerger</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Product of a merger"</para><para>"Ergebnis einer Fusion"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/productOfAMerger">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/productOfAMerger</seealso>
    let productOfAMerger = Prefixed_Name(rdarel2, "productOfAMerger") |> PrefixedName
    /// <summary>
    ///   <para>rdarel2:productOfASplit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Product of a split"</para><para>"Ergebnis einer Teilung"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/productOfASplit">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/productOfASplit</seealso>
    let productOfASplit = Prefixed_Name(rdarel2, "productOfASplit") |> PrefixedName
    /// <summary>
    ///   <para>rdarel2:progenitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Progenitor"</para><para>"Vorfahre, Stammvater"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/progenitor">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/progenitor</seealso>
    let progenitor = Prefixed_Name(rdarel2, "progenitor") |> PrefixedName
    /// <summary>
    ///   <para>rdarel2:realIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Real identity"</para><para>"wirkliche Identität"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/realIdentity">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/realIdentity</seealso>
    let realIdentity = Prefixed_Name(rdarel2, "realIdentity") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:relatedCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Related Corporate Body"</para><para>"In Beziehung stehende Körperschaft "</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedCorporateBody">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedCorporateBody</seealso>
    let relatedCorporateBody =
        Prefixed_Name(rdarel2, "relatedCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:relatedCorporateBodyCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"In Beziehung stehende Körperschaft (Körperschaft)"</para><para>"Related Corporate Body (Corporate Body)"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedCorporateBodyCorporateBody">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedCorporateBodyCorporateBody</seealso>
    let relatedCorporateBodyCorporateBody =
        Prefixed_Name(rdarel2, "relatedCorporateBodyCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:relatedCorporateBodyFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"In Beziehung stehende Körperschaft (Familie)"</para><para>"Related Corporate Body (Family)"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedCorporateBodyFamily">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedCorporateBodyFamily</seealso>
    let relatedCorporateBodyFamily =
        Prefixed_Name(rdarel2, "relatedCorporateBodyFamily") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:relatedCorporateBodyPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"In Beziehung stehende Körperschaft (Person)"</para><para>"Related Corporate Body (Person)"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedCorporateBodyPerson">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedCorporateBodyPerson</seealso>
    let relatedCorporateBodyPerson =
        Prefixed_Name(rdarel2, "relatedCorporateBodyPerson") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:relatedFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Related Family"</para><para>"in Beziehung stehende Familie"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedFamily">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedFamily</seealso>
    let relatedFamily = Prefixed_Name(rdarel2, "relatedFamily") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:relatedFamilyCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Related Family (Corporate Body)"</para><para>"in Beziehung stehende Familie"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedFamilyCorporateBody">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedFamilyCorporateBody</seealso>
    let relatedFamilyCorporateBody =
        Prefixed_Name(rdarel2, "relatedFamilyCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:relatedFamilyFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"in Beziehung stehende Familie (Familie)"</para><para>"Related Family (Family)"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedFamilyFamily">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedFamilyFamily</seealso>
    let relatedFamilyFamily =
        Prefixed_Name(rdarel2, "relatedFamilyFamily") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:relatedFamilyPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"in beziehung stehende Familie (Person)"</para><para>"Related Family (Person)"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedFamilyPerson">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedFamilyPerson</seealso>
    let relatedFamilyPerson =
        Prefixed_Name(rdarel2, "relatedFamilyPerson") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:relatedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Related Person"</para><para>"In Beziehung stehende Person"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedPerson">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedPerson</seealso>
    let relatedPerson = Prefixed_Name(rdarel2, "relatedPerson") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:relatedPersonCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Related Person (Corporate Body)"</para><para>"in Beziehung stehende Person (Körperschaft)"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedPersonCorporateBody">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedPersonCorporateBody</seealso>
    let relatedPersonCorporateBody =
        Prefixed_Name(rdarel2, "relatedPersonCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:relatedPersonFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"in Beziehung stehende Person (Familie)"</para><para>"Related Person (Family)"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedPersonFamily">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedPersonFamily</seealso>
    let relatedPersonFamily =
        Prefixed_Name(rdarel2, "relatedPersonFamily") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:relatedPersonPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Related Person (Person)"</para><para>"in Beziehung stehende Person (Person)"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedPersonPerson">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedPersonPerson</seealso>
    let relatedPersonPerson =
        Prefixed_Name(rdarel2, "relatedPersonPerson") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:sponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Sponsor"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/sponsor">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/sponsor</seealso>
    let sponsor = Prefixed_Name(rdarel2, "sponsor") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:sponsoredOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Sponsored organization"</para><para>"geförderte Organisation"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/sponsoredOrganization">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/sponsoredOrganization</seealso>
    let sponsoredOrganization =
        Prefixed_Name(rdarel2, "sponsoredOrganization") |> PrefixedName

    /// <summary>
    ///   <para>rdarel2:sponsoringFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Sponsorenfamilie"</para><para>"Sponsoring Family"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/sponsoringFamily">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/sponsoringFamily</seealso>
    let sponsoringFamily = Prefixed_Name(rdarel2, "sponsoringFamily") |> PrefixedName
    /// <summary>
    ///   <para>rdarel2:successor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Successor"</para><para>"Nachfolger"</para></remarks>
    /// <seealso href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/successor">http://metadataregistry.org/uri/schema/RDARelationshipsGR2/successor</seealso>
    let successor = Prefixed_Name(rdarel2, "successor") |> PrefixedName
