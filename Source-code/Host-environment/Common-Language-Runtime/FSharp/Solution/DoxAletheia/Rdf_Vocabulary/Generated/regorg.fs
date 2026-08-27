namespace http.www.w3.org.ns.regorg.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module regorg =
    let _namespace_iri = Namespace_Iri regorg |> NamespaceIRI
    /// <summary>
    ///   <para>regorg:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/regorg#">http://www.w3.org/ns/regorg#</seealso>
    let _prefix_iri = Prefixed_Name(regorg, "") |> PrefixedName

    /// <summary>
    ///   <para>regorg:RegisteredOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"rov:RegisteredOrganization is the key class for the Registered Organization vocabulary and represents
    ///     an organization that is legally registered. In many countries there is a single registry although in others, such
    ///     as Spain and Germany, multiple registries exist. A Registered Organization is able to trade, is legally liable for
    ///     its actions, accounts, tax affairs etc. Legal entity status is conferred by the act of registration cf.
    ///     org:FormalOrganization that applies to any legal entity, including those created by other legal means.
    ///     This makes registered organizations distinct from the broader concept of organizations, groups or, in
    ///     some jurisdictions, sole traders. Many organizations exist that are not legal entities yet to the outside world
    ///     they have staff, hierarchies, locations etc. Other organizations exist that are an umbrella for several legal entities
    ///     (universities are often good examples of this). This vocabulary is concerned solely with registered organizations.
    ///     In RDF, Registered Organization is a sub class of the Organization Ontology's org:FormalOrganization which is itself a
    ///     sub class of the more general 'Agent' class found in FOAF and Dublin Core that does encompass organizations,
    ///     natural persons, groups etc. - i.e. an Agent is any entity that is able to carry out actions.&lt;/p&gt;"</para>
    ///   <para>"Inspired by the usage of the Registered Organization Vocabulary in the euBusinessGraph Ontology including links to The Organization Ontology."</para>
    /// labels<para>"Registered Organization"</para><para>"Registered Organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/regorg#RegisteredOrganization">http://www.w3.org/ns/regorg#RegisteredOrganization</seealso>
    let RegisteredOrganization =
        Prefixed_Name(regorg, "RegisteredOrganization") |> PrefixedName

    /// <summary>
    ///   <para>regorg:hasRegisteredOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The has registered organization relationship can be used to link any dcterms:Agent (equivalent class foaf:Agent) to a Registered Organization that in some way acts as a registered legal entity for it. This is useful, for example, where an organization includes one or more legal entities, or where a natural person is also registered as a legal entity. rov:hasRegisteredOrganization has a range of rov:RegisteredOrganization."</para>
    /// labels<para>"registered organization"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/regorg#hasRegisteredOrganization">http://www.w3.org/ns/regorg#hasRegisteredOrganization</seealso>
    let hasRegisteredOrganization =
        Prefixed_Name(regorg, "hasRegisteredOrganization") |> PrefixedName

    /// <summary>
    ///   <para>regorg:legalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The legal name of the business. A business might have more than one
    ///     legal name, particularly in countries with more than one official language. In such cases the
    ///     language of the string should be identified."</para>
    ///   <para>"The legal name of the business. A business might have more than one
    ///       legal name, particularly in countries with more than one official language. In such cases the
    ///       language of the string should be identified."</para>
    ///   <para>"The legal name of the business. A business might have more than one legal name, particularly in countries with more than one official language. In such cases the language of the string should be identified."</para>
    /// labels<para>"legal name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"legal name"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/regorg#legalName">http://www.w3.org/ns/regorg#legalName</seealso>
    let legalName = Prefixed_Name(regorg, "legalName") |> PrefixedName
    /// <summary>
    ///   <para>regorg:orgActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The activity of an organisation should be recorded using a controlled vocabulary expressed
    ///     as a SKOS concept scheme (see &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="#skos:Concept"&gt;Code&lt;/a&gt;. Several such
    ///     vocabularies exist, many of which map to the UN's ISIC codes. Where a particular controlled vocabulary is in use
    ///     within a given context, such as SIC codes in the UK, it is acceptable to use these, however, the preferred
    ///     choice for European interoperability is NACE."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The activity of a company should be
    ///       recorded using a controlled vocabulary expressed as a SKOS concept scheme. Several such
    ///       vocabularies exist, many of which map to the UN's ISIC codes. Where a particular controlled vocabulary is in use
    ///       within a given context, such as SIC codes in the UK, it is acceptable to use these, however, the preferred
    ///       choice for European interoperability is NACE. rov:companyActivity is a sub class of org:classification which has a range of skos:Concept."</para>
    ///   <para>"The activity of a company should be recorded using a controlled vocabulary expressed as a SKOS concept scheme. Several such vocabularies exist, many of which map to the UN's ISIC codes. Where a particular controlled vocabulary is in use within a given context, such as SIC codes in the UK, it is acceptable to use these, however, the preferred choice for European interoperability is NACE. rov:orgActivity is a sub class of org:classification which has a range of skos:Concept."</para>
    ///   <para>"Relates to the economic activity of an organization based on international classification standards such as NACE (EU) ISIC4 (US) or the UK SIC codes."</para>
    /// labels<para>"economic activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"company activity"</para><para>"org activity"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/regorg#orgActivity">http://www.w3.org/ns/regorg#orgActivity</seealso>
    let orgActivity = Prefixed_Name(regorg, "orgActivity") |> PrefixedName
    /// <summary>
    ///   <para>regorg:orgStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"rov:orgStatus provides a first attempt -used in the Registered Organization Vocabulary- to identify the status of an organization."</para>
    ///   <para>"Terms like insolvent, bankrupt and in receivership are likely to have
    ///       different legal implications in different jurisdictions. Best Practice for recording various
    ///       other status levels is to use the relevant jurisdiction's terms and to do so in a
    ///       consistent manner using a SKOS Concept Scheme. rov:orgStatcompanyus is a sub class of org:classification
    ///       which has a range of skos:Concept."</para>
    ///   <para>"Terms like insolvent, bankrupt and in receivership are likely to have different legal implications in different jurisdictions. Best Practice for recording various other status levels is to use the relevant jurisdiction's terms and to do so in a consistent manner using a SKOS Concept Scheme. rov:orgStatus is a sub class of org:classification which has a range of skos:Concept."</para>
    ///   <para>"Terms like insolvent, bankrupt and in receivership are likely to have
    ///     different legal implications in different jurisdictions. Best Practice for recording various
    ///     other status levels is to use the relevant jurisdiction's terms and to do so in a
    ///     consistent manner using a skos:Concept as described in the &lt;skos:a xmlns:skos="http://www.w3.org/2004/02/skos/core#" ="http://www.w3.org/2004/02/skos/core#Concept"&gt;Concept&lt;/skos:a&gt; Class.
    ///     The term "Normal Activity" appears to have cross-border usefulness
    ///     and this should be used in preference to terms like trading or operating."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"company status"</para><para>"status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"org status"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/regorg#orgStatus">http://www.w3.org/ns/regorg#orgStatus</seealso>
    let orgStatus = Prefixed_Name(regorg, "orgStatus") |> PrefixedName
    /// <summary>
    ///   <para>regorg:orgType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"This property records the type of organization. Familiar types are SA, PLC, LLC, GmbH etc. Each jurisdiction will have a limited set of recognized company types and these should be used in a consistent manner using a SKOS Concept Scheme. rov:orgType is a sub class of org:classification which has a range of skos:Concept."</para>
    ///   <para>"This property records the type of company. Familiar types are SA, PLC, LLC, GmbH etc. Each
    ///     jurisdiction will have a limited set of recognised company types and these should be used in a consistent manner
    ///     using a skos:Concept as described in the &lt;skos:a xmlns:skos="http://www.w3.org/2004/02/skos/core#" ="http://www.w3.org/2004/02/skos/core#Concept"&gt;Code&lt;/skos:a&gt; Class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This property records the type of company. Familiar types are SA, PLC, LLC, GmbH etc. Each
    ///       jurisdiction will have a limited set of recognized company types and these should be used in a consistent manner
    ///       using a SKOS Concept Scheme. rov:orgType is a sub class of org:classification which has a range of skos:Concept."</para>
    /// labels<para>"company type"</para><para>"organization type"</para><para>"type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/regorg#orgType">http://www.w3.org/ns/regorg#orgType</seealso>
    let orgType = Prefixed_Name(regorg, "orgType") |> PrefixedName
    /// <summary>
    ///   <para>regorg:registration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The registration is a fundamental relationship between a legal entity and the authority with which it is registered and that confers legal status upon it. rov:registration is a sub property of adms:identifier which has a range of adms:Identifier. rov:registration has a domain of rov:RegisteredOrganization."</para>
    ///   <para>"The legal status of a registered organization is conferred on it by an authority within a given
    ///       jurisdiction. The registration is therefore a fundamental relationship between a the organization and the authority with
    ///       which it is registered. The details of the registration are provided as properties of the Identifier class which is
    ///       defined by ADMS. The vocabulary sets no restriction on the type of legal identifier. In many countries, the business register's
    ///       identifier is the relevant data point. The tax number often fulfils this function in Spain and elsewhere.
    ///       Although there is no formal cardinality constraint on any property in the Registered Organization Vocabulary, it is
    ///       questionable whether a description of a registered organization without this property and an associated Identifier class will
    ///       be of any value."</para>
    /// labels<para>"registration"</para><para>"official registration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/regorg#registration">http://www.w3.org/ns/regorg#registration</seealso>
    let registration = Prefixed_Name(regorg, "registration") |> PrefixedName
