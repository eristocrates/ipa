namespace http.www.w3.org.ns.prov.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nsprov =
    let _namespace_iri = Namespace_Iri nsprov |> NamespaceIRI
    /// <summary>
    ///   <para>nsprov:wasInfluencedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Because prov:wasInfluencedBy is a broad relation, its more specific subproperties (e.g. prov:wasInformedBy, prov:actedOnBehalfOf, prov:wasEndedBy, etc.) should be used when applicable.</para>
    ///   <para>This property has multiple RDFS domains to suit multiple OWL Profiles. See &lt;a href="#owl-profile"&gt;PROV-O OWL Profile&lt;/a&gt;.</para>
    /// labels<para>wasInfluencedBy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasInfluencedBy">http://www.w3.org/ns/prov#wasInfluencedBy</seealso>
    let wasInfluencedBy = Prefixed_Name(nsprov, "wasInfluencedBy") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:dm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A reference to the principal section of the PROV-DM document that describes this concept.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#dm">http://www.w3.org/ns/prov#dm</seealso>
    let dm = Prefixed_Name(nsprov, "dm") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasRevisionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A revision is a derivation that revises an entity into a revised version.</para>
    /// labels<para>wasRevisionOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasRevisionOf">http://www.w3.org/ns/prov#wasRevisionOf</seealso>
    let wasRevisionOf = Prefixed_Name(nsprov, "wasRevisionOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:SoftwareAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>SoftwareAgent</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#SoftwareAgent">http://www.w3.org/ns/prov#SoftwareAgent</seealso>
    let SoftwareAgent = Prefixed_Name(nsprov, "SoftwareAgent") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:EmptyCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>EmptyCollection</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#EmptyCollection">http://www.w3.org/ns/prov#EmptyCollection</seealso>
    let EmptyCollection = Prefixed_Name(nsprov, "EmptyCollection") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Activity</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Activity">http://www.w3.org/ns/prov#Activity</seealso>
    let Activity = Prefixed_Name(nsprov, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Entity</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Entity">http://www.w3.org/ns/prov#Entity</seealso>
    let Entity = Prefixed_Name(nsprov, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A definition quoted from PROV-DM or PROV-CONSTRAINTS that describes the concept expressed with this OWL term.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#definition">http://www.w3.org/ns/prov#definition</seealso>
    let definition = Prefixed_Name(nsprov, "definition") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Accept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Accept</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Accept">http://www.w3.org/ns/prov#Accept</seealso>
    let Accept = Prefixed_Name(nsprov, "Accept") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:constraints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A reference to the principal section of the PROV-CONSTRAINTS document that describes this concept.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#constraints">http://www.w3.org/ns/prov#constraints</seealso>
    let constraints = Prefixed_Name(nsprov, "constraints") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:End</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of prov:End provides additional descriptions about the binary prov:wasEndedBy relation from some ended prov:Activity to an prov:Entity that ended it. For example, :ball_game prov:wasEndedBy :buzzer; prov:qualifiedEnd [ a prov:End; prov:entity :buzzer; :foo :bar; prov:atTime '2012-03-09T08:05:08-05:00'^^xsd:dateTime ].</para>
    /// labels<para>End</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#End">http://www.w3.org/ns/prov#End</seealso>
    let End = Prefixed_Name(nsprov, "End") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasEndedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>End is when an activity is deemed to have ended. An end may refer to an entity, known as trigger, that terminated the activity.</para>
    /// labels<para>wasEndedBy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasEndedBy">http://www.w3.org/ns/prov#wasEndedBy</seealso>
    let wasEndedBy = Prefixed_Name(nsprov, "wasEndedBy") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>entity</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#entity">http://www.w3.org/ns/prov#entity</seealso>
    let entity = Prefixed_Name(nsprov, "entity") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Insertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Insertion</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Insertion">http://www.w3.org/ns/prov#Insertion</seealso>
    let Insertion = Prefixed_Name(nsprov, "Insertion") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:dictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>dictionary</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#dictionary">http://www.w3.org/ns/prov#dictionary</seealso>
    let dictionary = Prefixed_Name(nsprov, "dictionary") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:derivedByInsertionFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>derivedByInsertionFrom</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#derivedByInsertionFrom">http://www.w3.org/ns/prov#derivedByInsertionFrom</seealso>
    let derivedByInsertionFrom =
        Prefixed_Name(nsprov, "derivedByInsertionFrom") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:pairKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>pairKey</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#pairKey">http://www.w3.org/ns/prov#pairKey</seealso>
    let pairKey = Prefixed_Name(nsprov, "pairKey") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:atLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property has multiple RDFS domains to suit multiple OWL Profiles. See &lt;a href="#owl-profile"&gt;PROV-O OWL Profile&lt;/a&gt;.</para>
    ///   <para>The Location of any resource.</para>
    /// labels<para>atLocation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#atLocation">http://www.w3.org/ns/prov#atLocation</seealso>
    let atLocation = Prefixed_Name(nsprov, "atLocation") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Person</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Person">http://www.w3.org/ns/prov#Person</seealso>
    let Person = Prefixed_Name(nsprov, "Person") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>There exist no prescriptive requirement on the nature of plans, their representation, the actions or steps they consist of, or their intended goals. Since plans may evolve over time, it may become necessary to track their provenance, so plans themselves are entities. Representing the plan explicitly in the provenance can be useful for various tasks: for example, to validate the execution as represented in the provenance record, to manage expectation failures, or to provide explanations.</para>
    /// labels<para>Plan</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Plan">http://www.w3.org/ns/prov#Plan</seealso>
    let Plan = Prefixed_Name(nsprov, "Plan") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:PrimarySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of prov:PrimarySource provides additional descriptions about the binary prov:hadPrimarySource relation from some secondary prov:Entity to an earlier, primary prov:Entity. For example, :blog prov:hadPrimarySource :newsArticle; prov:qualifiedPrimarySource [ a prov:PrimarySource; prov:entity :newsArticle; :foo :bar ] .</para>
    /// labels<para>PrimarySource</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#PrimarySource">http://www.w3.org/ns/prov#PrimarySource</seealso>
    let PrimarySource = Prefixed_Name(nsprov, "PrimarySource") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Publish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Publish</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Publish">http://www.w3.org/ns/prov#Publish</seealso>
    let Publish = Prefixed_Name(nsprov, "Publish") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Classify prov-o terms into six components according to prov-dm, including 'agents-responsibility', 'alternate', 'annotations', 'collections', 'derivations', and 'entities-activities'. This classification is used so that readers of prov-o specification can find its correspondence with the prov-dm specification.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#component">http://www.w3.org/ns/prov#component</seealso>
    let component_ = Prefixed_Name(nsprov, "component") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasDerivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The more specific subproperties of prov:wasDerivedFrom (i.e., prov:wasQuotedFrom, prov:wasRevisionOf, prov:hadPrimarySource) should be used when applicable.</para>
    /// labels<para>wasDerivedFrom</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasDerivedFrom">http://www.w3.org/ns/prov#wasDerivedFrom</seealso>
    let wasDerivedFrom = Prefixed_Name(nsprov, "wasDerivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Invalidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of prov:Invalidation provides additional descriptions about the binary prov:wasInvalidatedBy relation from an invalidated prov:Entity to the prov:Activity that invalidated it. For example, :uncracked_egg prov:wasInvalidatedBy :baking; prov:qualifiedInvalidation [ a prov:Invalidation; prov:activity :baking; :foo :bar ].</para>
    /// labels<para>Invalidation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Invalidation">http://www.w3.org/ns/prov#Invalidation</seealso>
    let Invalidation = Prefixed_Name(nsprov, "Invalidation") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasInvalidatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>wasInvalidatedBy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasInvalidatedBy">http://www.w3.org/ns/prov#wasInvalidatedBy</seealso>
    let wasInvalidatedBy = Prefixed_Name(nsprov, "wasInvalidatedBy") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:KeyEntityPair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Key-Entity Pair</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#KeyEntityPair">http://www.w3.org/ns/prov#KeyEntityPair</seealso>
    let KeyEntityPair = Prefixed_Name(nsprov, "KeyEntityPair") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Location</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Location">http://www.w3.org/ns/prov#Location</seealso>
    let Location = Prefixed_Name(nsprov, "Location") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Modify</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Modify</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Modify">http://www.w3.org/ns/prov#Modify</seealso>
    let Modify = Prefixed_Name(nsprov, "Modify") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasPlanOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>wasPlanOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasPlanOf">http://www.w3.org/ns/prov#wasPlanOf</seealso>
    let wasPlanOf = Prefixed_Name(nsprov, "wasPlanOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasPrimarySourceOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>wasPrimarySourceOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasPrimarySourceOf">http://www.w3.org/ns/prov#wasPrimarySourceOf</seealso>
    let wasPrimarySourceOf = Prefixed_Name(nsprov, "wasPrimarySourceOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasMemberOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>wasMemberOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasMemberOf">http://www.w3.org/ns/prov#wasMemberOf</seealso>
    let wasMemberOf = Prefixed_Name(nsprov, "wasMemberOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:wasUsedInDerivation</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>wasUsedInDerivation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasUsedInDerivation">http://www.w3.org/ns/prov#wasUsedInDerivation</seealso>
    let wasUsedInDerivation =
        Prefixed_Name(nsprov, "wasUsedInDerivation") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:wasAttributedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Attribution is the ascribing of an entity to an agent.</para>
    /// labels<para>wasAttributedTo</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasAttributedTo">http://www.w3.org/ns/prov#wasAttributedTo</seealso>
    let wasAttributedTo = Prefixed_Name(nsprov, "wasAttributedTo") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hadMember</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadMember">http://www.w3.org/ns/prov#hadMember</seealso>
    let hadMember = Prefixed_Name(nsprov, "hadMember") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasRoleIn</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>wasRoleIn</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasRoleIn">http://www.w3.org/ns/prov#wasRoleIn</seealso>
    let wasRoleIn = Prefixed_Name(nsprov, "wasRoleIn") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasUsedBy</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>wasUsedBy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasUsedBy">http://www.w3.org/ns/prov#wasUsedBy</seealso>
    let wasUsedBy = Prefixed_Name(nsprov, "wasUsedBy") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Classify prov-o terms into three categories, including 'starting-point', 'qualifed', and 'extended'. This classification is used by the prov-o html document to gently introduce prov-o terms to its users. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#category">http://www.w3.org/ns/prov#category</seealso>
    let category = Prefixed_Name(nsprov, "category") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:invalidatedAtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time at which an entity was invalidated (i.e., no longer usable).</para>
    /// labels<para>invalidatedAtTime</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#invalidatedAtTime">http://www.w3.org/ns/prov#invalidatedAtTime</seealso>
    let invalidatedAtTime = Prefixed_Name(nsprov, "invalidatedAtTime") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:endedAtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time at which an activity ended. See also prov:startedAtTime.</para>
    /// labels<para>endedAtTime</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#endedAtTime">http://www.w3.org/ns/prov#endedAtTime</seealso>
    let endedAtTime = Prefixed_Name(nsprov, "endedAtTime") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:describesService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>relates a generic provenance query service resource (type prov:ServiceDescription) to a specific query service description (e.g. a prov:DirectQueryService or a sd:Service).</para>
    /// labels<para>describesService</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#describesService">http://www.w3.org/ns/prov#describesService</seealso>
    let describesService = Prefixed_Name(nsprov, "describesService") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:ended</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>ended</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#ended">http://www.w3.org/ns/prov#ended</seealso>
    let ended = Prefixed_Name(nsprov, "ended") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:entityOfInfluence</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>entityOfInfluence</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#entityOfInfluence">http://www.w3.org/ns/prov#entityOfInfluence</seealso>
    let entityOfInfluence = Prefixed_Name(nsprov, "entityOfInfluence") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:generalizationOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>generalizationOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#generalizationOf">http://www.w3.org/ns/prov#generalizationOf</seealso>
    let generalizationOf = Prefixed_Name(nsprov, "generalizationOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:influenced</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>influenced</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#influenced">http://www.w3.org/ns/prov#influenced</seealso>
    let influenced = Prefixed_Name(nsprov, "influenced") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadGeneration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The _optional_ Generation involved in an Entity's Derivation.</para>
    /// labels<para>hadGeneration</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadGeneration">http://www.w3.org/ns/prov#hadGeneration</seealso>
    let hadGeneration = Prefixed_Name(nsprov, "hadGeneration") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:pairEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>pairKey</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#pairEntity">http://www.w3.org/ns/prov#pairEntity</seealso>
    let pairEntity = Prefixed_Name(nsprov, "pairEntity") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Organization</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Organization">http://www.w3.org/ns/prov#Organization</seealso>
    let Organization = Prefixed_Name(nsprov, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Publisher</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Publisher">http://www.w3.org/ns/prov#Publisher</seealso>
    let Publisher = Prefixed_Name(nsprov, "Publisher") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Removal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Removal</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Removal">http://www.w3.org/ns/prov#Removal</seealso>
    let Removal = Prefixed_Name(nsprov, "Removal") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:removedKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>removedKey</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#removedKey">http://www.w3.org/ns/prov#removedKey</seealso>
    let removedKey = Prefixed_Name(nsprov, "removedKey") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Replace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Replace</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Replace">http://www.w3.org/ns/prov#Replace</seealso>
    let Replace = Prefixed_Name(nsprov, "Replace") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Revision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of prov:Revision provides additional descriptions about the binary prov:wasRevisionOf relation from some newer prov:Entity to an earlier prov:Entity. For example, :draft_2 prov:wasRevisionOf :draft_1; prov:qualifiedRevision [ a prov:Revision; prov:entity :draft_1; :foo :bar ].</para>
    /// labels<para>Revision</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Revision">http://www.w3.org/ns/prov#Revision</seealso>
    let Revision = Prefixed_Name(nsprov, "Revision") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:RightsAssignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>RightsAssignment</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#RightsAssignment">http://www.w3.org/ns/prov#RightsAssignment</seealso>
    let RightsAssignment = Prefixed_Name(nsprov, "RightsAssignment") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The _optional_ Role that an Entity assumed in the context of an Activity. For example, :baking prov:used :spoon; prov:qualified [ a prov:Usage; prov:entity :spoon; prov:hadRole roles:mixing_implement ].</para>
    ///   <para>This property has multiple RDFS domains to suit multiple OWL Profiles. See &lt;a href="#owl-profile"&gt;PROV-O OWL Profile&lt;/a&gt;.</para>
    /// labels<para>hadRole</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadRole">http://www.w3.org/ns/prov#hadRole</seealso>
    let hadRole = Prefixed_Name(nsprov, "hadRole") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Start</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of prov:Start provides additional descriptions about the binary prov:wasStartedBy relation from some started prov:Activity to an prov:Entity that started it. For example, :foot_race prov:wasStartedBy :bang; prov:qualifiedStart [ a prov:Start; prov:entity :bang; :foo :bar; prov:atTime '2012-03-09T08:05:08-05:00'^^xsd:dateTime ] .</para>
    /// labels<para>Start</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Start">http://www.w3.org/ns/prov#Start</seealso>
    let Start = Prefixed_Name(nsprov, "Start") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of prov:Usage provides additional descriptions about the binary prov:used relation from some prov:Activity to an prov:Entity that it used. For example, :keynote prov:used :podium; prov:qualifiedUsage [ a prov:Usage; prov:entity :podium; :foo :bar ].</para>
    /// labels<para>Usage</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Usage">http://www.w3.org/ns/prov#Usage</seealso>
    let Usage = Prefixed_Name(nsprov, "Usage") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:inverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>PROV-O does not define all property inverses. The directionalities defined in PROV-O should be given preference over those not defined. However, if users wish to name the inverse of a PROV-O property, the local name given by prov:inverse should be used.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#inverse">http://www.w3.org/ns/prov#inverse</seealso>
    let inverse = Prefixed_Name(nsprov, "inverse") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:qualifiedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>This annotation property links a subproperty of prov:wasInfluencedBy with the subclass of prov:Influence and the qualifying property that are used to qualify it.
    ///
    /// Example annotation:
    ///
    ///     prov:wasGeneratedBy prov:qualifiedForm prov:qualifiedGeneration, prov:Generation .
    ///
    /// Then this unqualified assertion:
    ///
    ///     :entity1 prov:wasGeneratedBy :activity1 .
    ///
    /// can be qualified by adding:
    ///
    ///    :entity1 prov:qualifiedGeneration :entity1Gen .
    ///    :entity1Gen
    ///        a prov:Generation, prov:Influence;
    ///        prov:activity :activity1;
    ///        :customValue 1337 .
    ///
    /// Note how the value of the unqualified influence (prov:wasGeneratedBy :activity1) is mirrored as the value of the prov:activity (or prov:entity, or prov:agent) property on the influence class.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedForm">http://www.w3.org/ns/prov#qualifiedForm</seealso>
    let qualifiedForm = Prefixed_Name(nsprov, "qualifiedForm") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:agentOfInfluence</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>agentOfInfluence</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#agentOfInfluence">http://www.w3.org/ns/prov#agentOfInfluence</seealso>
    let agentOfInfluence = Prefixed_Name(nsprov, "agentOfInfluence") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:alternateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>alternateOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#alternateOf">http://www.w3.org/ns/prov#alternateOf</seealso>
    let alternateOf = Prefixed_Name(nsprov, "alternateOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Quotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of prov:Quotation provides additional descriptions about the binary prov:wasQuotedFrom relation from some taken prov:Entity from an earlier, larger prov:Entity. For example, :here_is_looking_at_you_kid prov:wasQuotedFrom :casablanca_script; prov:qualifiedQuotation [ a prov:Quotation; prov:entity :casablanca_script; :foo :bar ].</para>
    /// labels<para>Quotation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Quotation">http://www.w3.org/ns/prov#Quotation</seealso>
    let Quotation = Prefixed_Name(nsprov, "Quotation") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:derivedByRemovalFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>derivedByRemovalFrom</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#derivedByRemovalFrom">http://www.w3.org/ns/prov#derivedByRemovalFrom</seealso>
    let derivedByRemovalFrom =
        Prefixed_Name(nsprov, "derivedByRemovalFrom") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:sharesDefinitionWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#sharesDefinitionWith">http://www.w3.org/ns/prov#sharesDefinitionWith</seealso>
    let sharesDefinitionWith =
        Prefixed_Name(nsprov, "sharesDefinitionWith") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:asInBundle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>prov:asInBundle is used to specify which bundle the general entity of a prov:mentionOf property is described.
    ///
    /// When :x prov:mentionOf :y and :y is described in Bundle :b, the triple :x prov:asInBundle :b is also asserted to cite the Bundle in which :y was described.</para>
    /// labels<para>asInBundle</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#asInBundle">http://www.w3.org/ns/prov#asInBundle</seealso>
    let asInBundle = Prefixed_Name(nsprov, "asInBundle") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:mentionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>prov:mentionOf is used to specialize an entity as described in another bundle. It is to be used in conjuction with prov:asInBundle.
    ///
    /// prov:asInBundle is used to cite the Bundle in which the generalization was mentioned.</para>
    /// labels<para>mentionOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#mentionOf">http://www.w3.org/ns/prov#mentionOf</seealso>
    let mentionOf = Prefixed_Name(nsprov, "mentionOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:atTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time at which an InstantaneousEvent occurred, in the form of xsd:dateTime.</para>
    /// labels<para>atTime</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#atTime">http://www.w3.org/ns/prov#atTime</seealso>
    let atTime = Prefixed_Name(nsprov, "atTime") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:startedAtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time at which an activity started. See also prov:endedAtTime.</para>
    /// labels<para>startedAtTime</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#startedAtTime">http://www.w3.org/ns/prov#startedAtTime</seealso>
    let startedAtTime = Prefixed_Name(nsprov, "startedAtTime") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:generatedAtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time at which an entity was completely created and is available for use.</para>
    /// labels<para>generatedAtTime</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#generatedAtTime">http://www.w3.org/ns/prov#generatedAtTime</seealso>
    let generatedAtTime = Prefixed_Name(nsprov, "generatedAtTime") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:contributed</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>contributed</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#contributed">http://www.w3.org/ns/prov#contributed</seealso>
    let contributed = Prefixed_Name(nsprov, "contributed") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:n</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A reference to the principal section of the PROV-DM document that describes this concept.</para>
    ///   <para>A reference to the principal section of the PROV-M document that describes this concept.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#n">http://www.w3.org/ns/prov#n</seealso>
    let n = Prefixed_Name(nsprov, "n") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>activity</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#activity">http://www.w3.org/ns/prov#activity</seealso>
    let activity = Prefixed_Name(nsprov, "activity") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:EntityInfluence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>EntityInfluence provides additional descriptions of an Entity's binary influence upon any other kind of resource. Instances of EntityInfluence use the prov:entity property to cite the influencing Entity.</para>
    ///   <para>It is not recommended that the type EntityInfluence be asserted without also asserting one of its more specific subclasses.</para>
    /// labels<para>EntityInfluence</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#EntityInfluence">http://www.w3.org/ns/prov#EntityInfluence</seealso>
    let EntityInfluence = Prefixed_Name(nsprov, "EntityInfluence") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:InstantaneousEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instantaneous event, or event for short, happens in the world and marks a change in the world, in its activities and in its entities. The term 'event' is commonly used in process algebra with a similar meaning. Events represent communications or interactions; they are assumed to be atomic and instantaneous.</para>
    /// labels<para>InstantaneousEvent</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#InstantaneousEvent">http://www.w3.org/ns/prov#InstantaneousEvent</seealso>
    let InstantaneousEvent = Prefixed_Name(nsprov, "InstantaneousEvent") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>agent</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#agent">http://www.w3.org/ns/prov#agent</seealso>
    let agent = Prefixed_Name(nsprov, "agent") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Association</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of prov:Association provides additional descriptions about the binary prov:wasAssociatedWith relation from an prov:Activity to some prov:Agent that had some responsiblity for it. For example, :baking prov:wasAssociatedWith :baker; prov:qualifiedAssociation [ a prov:Association; prov:agent :baker; :foo :bar ].</para>
    /// labels<para>Association</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Association">http://www.w3.org/ns/prov#Association</seealso>
    let Association = Prefixed_Name(nsprov, "Association") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasAssociatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An prov:Agent that had some (unspecified) responsibility for the occurrence of this prov:Activity.</para>
    /// labels<para>wasAssociatedWith</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasAssociatedWith">http://www.w3.org/ns/prov#wasAssociatedWith</seealso>
    let wasAssociatedWith = Prefixed_Name(nsprov, "wasAssociatedWith") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Attribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of prov:Attribution provides additional descriptions about the binary prov:wasAttributedTo relation from an prov:Entity to some prov:Agent that had some responsible for it. For example, :cake prov:wasAttributedTo :baker; prov:qualifiedAttribution [ a prov:Attribution; prov:entity :baker; :foo :bar ].</para>
    /// labels<para>Attribution</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Attribution">http://www.w3.org/ns/prov#Attribution</seealso>
    let Attribution = Prefixed_Name(nsprov, "Attribution") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Collection</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Collection">http://www.w3.org/ns/prov#Collection</seealso>
    let Collection = Prefixed_Name(nsprov, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The position that this OWL term should be listed within documentation. The scope of the documentation (e.g., among all terms, among terms within a prov:category, among properties applying to a particular class, etc.) is unspecified.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#order">http://www.w3.org/ns/prov#order</seealso>
    let order = Prefixed_Name(nsprov, "order") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:provenanceUriTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relates a provenance service to a URI template string for constructing provenance-URIs.</para>
    /// labels<para>provenanceUriTemplate</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#provenanceUriTemplate">http://www.w3.org/ns/prov#provenanceUriTemplate</seealso>
    let provenanceUriTemplate =
        Prefixed_Name(nsprov, "provenanceUriTemplate") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedInfluence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Because prov:qualifiedInfluence is a broad relation, the more specific relations (qualifiedCommunication, qualifiedDelegation, qualifiedEnd, etc.) should be used when applicable.</para>
    /// labels<para>qualifiedInfluence</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedInfluence">http://www.w3.org/ns/prov#qualifiedInfluence</seealso>
    let qualifiedInfluence = Prefixed_Name(nsprov, "qualifiedInfluence") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedAttribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If this Entity prov:wasAttributedTo Agent :ag, then it can qualify how it was influenced using prov:qualifiedAttribution [ a prov:Attribution;  prov:agent :ag; :foo :bar ].</para>
    /// labels<para>qualifiedAttribution</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedAttribution">http://www.w3.org/ns/prov#qualifiedAttribution</seealso>
    let qualifiedAttribution =
        Prefixed_Name(nsprov, "qualifiedAttribution") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If this Activity prov:wasInformedBy Activity :a, then it can qualify how it was influenced using prov:qualifiedCommunication [ a prov:Communication;  prov:activity :a; :foo :bar ].</para>
    /// labels<para>qualifiedCommunication</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedCommunication">http://www.w3.org/ns/prov#qualifiedCommunication</seealso>
    let qualifiedCommunication =
        Prefixed_Name(nsprov, "qualifiedCommunication") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedCommunicationOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>qualifiedCommunicationOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedCommunicationOf">http://www.w3.org/ns/prov#qualifiedCommunicationOf</seealso>
    let qualifiedCommunicationOf =
        Prefixed_Name(nsprov, "qualifiedCommunicationOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedDerivationOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>qualifiedDerivationOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedDerivationOf">http://www.w3.org/ns/prov#qualifiedDerivationOf</seealso>
    let qualifiedDerivationOf =
        Prefixed_Name(nsprov, "qualifiedDerivationOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If this Activity prov:wasEndedBy Entity :e1, then it can qualify how it was ended using prov:qualifiedEnd [ a prov:End;  prov:entity :e1; :foo :bar ].</para>
    /// labels<para>qualifiedEnd</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedEnd">http://www.w3.org/ns/prov#qualifiedEnd</seealso>
    let qualifiedEnd = Prefixed_Name(nsprov, "qualifiedEnd") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedGeneration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If this Activity prov:generated Entity :e, then it can qualify how it performed the Generation using prov:qualifiedGeneration [ a prov:Generation;  prov:entity :e; :foo :bar ].</para>
    /// labels<para>qualifiedGeneration</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedGeneration">http://www.w3.org/ns/prov#qualifiedGeneration</seealso>
    let qualifiedGeneration =
        Prefixed_Name(nsprov, "qualifiedGeneration") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedGenerationOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>qualifiedGenerationOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedGenerationOf">http://www.w3.org/ns/prov#qualifiedGenerationOf</seealso>
    let qualifiedGenerationOf =
        Prefixed_Name(nsprov, "qualifiedGenerationOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedInfluenceOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>qualifiedInfluenceOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedInfluenceOf">http://www.w3.org/ns/prov#qualifiedInfluenceOf</seealso>
    let qualifiedInfluenceOf =
        Prefixed_Name(nsprov, "qualifiedInfluenceOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedInsertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>qualifiedInsertion</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedInsertion">http://www.w3.org/ns/prov#qualifiedInsertion</seealso>
    let qualifiedInsertion = Prefixed_Name(nsprov, "qualifiedInsertion") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedInvalidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If this Entity prov:wasInvalidatedBy Activity :a, then it can qualify how it was invalidated using prov:qualifiedInvalidation [ a prov:Invalidation;  prov:activity :a; :foo :bar ].</para>
    /// labels<para>qualifiedInvalidation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedInvalidation">http://www.w3.org/ns/prov#qualifiedInvalidation</seealso>
    let qualifiedInvalidation =
        Prefixed_Name(nsprov, "qualifiedInvalidation") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedQuotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If this Entity prov:wasQuotedFrom Entity :e, then it can qualify how using prov:qualifiedQuotation [ a prov:Quotation;  prov:entity :e; :foo :bar ].</para>
    /// labels<para>qualifiedQuotation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedQuotation">http://www.w3.org/ns/prov#qualifiedQuotation</seealso>
    let qualifiedQuotation = Prefixed_Name(nsprov, "qualifiedQuotation") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedQuotationOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>qualifiedQuotationOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedQuotationOf">http://www.w3.org/ns/prov#qualifiedQuotationOf</seealso>
    let qualifiedQuotationOf =
        Prefixed_Name(nsprov, "qualifiedQuotationOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedRevision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If this Entity prov:wasRevisionOf Entity :e, then it can qualify how it was revised using prov:qualifiedRevision [ a prov:Revision;  prov:entity :e; :foo :bar ].</para>
    /// labels<para>qualifiedRevision</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedRevision">http://www.w3.org/ns/prov#qualifiedRevision</seealso>
    let qualifiedRevision = Prefixed_Name(nsprov, "qualifiedRevision") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:qualifiedSourceOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>qualifiedSourceOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedSourceOf">http://www.w3.org/ns/prov#qualifiedSourceOf</seealso>
    let qualifiedSourceOf = Prefixed_Name(nsprov, "qualifiedSourceOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:qualifiedStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If this Activity prov:wasStartedBy Entity :e1, then it can qualify how it was started using prov:qualifiedStart [ a prov:Start;  prov:entity :e1; :foo :bar ].</para>
    /// labels<para>qualifiedStart</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedStart">http://www.w3.org/ns/prov#qualifiedStart</seealso>
    let qualifiedStart = Prefixed_Name(nsprov, "qualifiedStart") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:qualifiedStartOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>qualifiedStartOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedStartOf">http://www.w3.org/ns/prov#qualifiedStartOf</seealso>
    let qualifiedStartOf = Prefixed_Name(nsprov, "qualifiedStartOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:qualifiedUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If this Activity prov:used Entity :e, then it can qualify how it used it using prov:qualifiedUsage [ a prov:Usage; prov:entity :e; :foo :bar ].</para>
    /// labels<para>qualifiedUsage</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedUsage">http://www.w3.org/ns/prov#qualifiedUsage</seealso>
    let qualifiedUsage = Prefixed_Name(nsprov, "qualifiedUsage") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedUsingActivity</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>qualifiedUsingActivity</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedUsingActivity">http://www.w3.org/ns/prov#qualifiedUsingActivity</seealso>
    let qualifiedUsingActivity =
        Prefixed_Name(nsprov, "qualifiedUsingActivity") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:quotedAs</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>quotedAs</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#quotedAs">http://www.w3.org/ns/prov#quotedAs</seealso>
    let quotedAs = Prefixed_Name(nsprov, "quotedAs") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:ActivityInfluence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is not recommended that the type ActivityInfluence be asserted without also asserting one of its more specific subclasses.</para>
    ///   <para>ActivityInfluence provides additional descriptions of an Activity's binary influence upon any other kind of resource. Instances of ActivityInfluence use the prov:activity property to cite the influencing Activity.</para>
    /// labels<para>ActivityInfluence</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#ActivityInfluence">http://www.w3.org/ns/prov#ActivityInfluence</seealso>
    let ActivityInfluence = Prefixed_Name(nsprov, "ActivityInfluence") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Influence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of prov:Influence provides additional descriptions about the binary prov:wasInfluencedBy relation from some influenced Activity, Entity, or Agent to the influencing Activity, Entity, or Agent. For example, :stomach_ache prov:wasInfluencedBy :spoon; prov:qualifiedInfluence [ a prov:Influence; prov:entity :spoon; :foo :bar ] . Because prov:Influence is a broad relation, the more specific relations (Communication, Delegation, End, etc.) should be used when applicable.</para>
    ///   <para>Because prov:Influence is a broad relation, its most specific subclasses (e.g. prov:Communication, prov:Delegation, prov:End, prov:Revision, etc.) should be used when applicable.</para>
    /// labels<para>Influence</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Influence">http://www.w3.org/ns/prov#Influence</seealso>
    let Influence = Prefixed_Name(nsprov, "Influence") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:generatedAsDerivation</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>generatedAsDerivation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#generatedAsDerivation">http://www.w3.org/ns/prov#generatedAsDerivation</seealso>
    let generatedAsDerivation =
        Prefixed_Name(nsprov, "generatedAsDerivation") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:hadDelegate</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>hadDelegate</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadDelegate">http://www.w3.org/ns/prov#hadDelegate</seealso>
    let hadDelegate = Prefixed_Name(nsprov, "hadDelegate") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:hadDictionaryMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hadDictionaryMember</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadDictionaryMember">http://www.w3.org/ns/prov#hadDictionaryMember</seealso>
    let hadDictionaryMember =
        Prefixed_Name(nsprov, "hadDictionaryMember") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:hadPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The _optional_ Plan adopted by an Agent in Association with some Activity. Plan specifications are out of the scope of this specification.</para>
    /// labels<para>hadPlan</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadPlan">http://www.w3.org/ns/prov#hadPlan</seealso>
    let hadPlan = Prefixed_Name(nsprov, "hadPlan") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedPrimarySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If this Entity prov:hadPrimarySource Entity :e, then it can qualify how using prov:qualifiedPrimarySource [ a prov:PrimarySource; prov:entity :e; :foo :bar ].</para>
    /// labels<para>qualifiedPrimarySource</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedPrimarySource">http://www.w3.org/ns/prov#qualifiedPrimarySource</seealso>
    let qualifiedPrimarySource =
        Prefixed_Name(nsprov, "qualifiedPrimarySource") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:hadActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property has multiple RDFS domains to suit multiple OWL Profiles. See &lt;a href="#owl-profile"&gt;PROV-O OWL Profile&lt;/a&gt;.</para>
    ///   <para>The _optional_ Activity of an Influence, which used, generated, invalidated, or was the responsibility of some Entity. This property is _not_ used by ActivityInfluence (use prov:activity instead).</para>
    /// labels<para>hadActivity</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadActivity">http://www.w3.org/ns/prov#hadActivity</seealso>
    let hadActivity = Prefixed_Name(nsprov, "hadActivity") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:editorsDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>When the prov-o term does not have a definition drawn from prov-dm, and the prov-o editor provides one.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#editorsDefinition">http://www.w3.org/ns/prov#editorsDefinition</seealso>
    let editorsDefinition = Prefixed_Name(nsprov, "editorsDefinition") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadDerivation</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>hadDerivation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadDerivation">http://www.w3.org/ns/prov#hadDerivation</seealso>
    let hadDerivation = Prefixed_Name(nsprov, "hadDerivation") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadInfluence</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>hadInfluence</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadInfluence">http://www.w3.org/ns/prov#hadInfluence</seealso>
    let hadInfluence = Prefixed_Name(nsprov, "hadInfluence") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:generated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>generated</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#generated">http://www.w3.org/ns/prov#generated</seealso>
    let generated = Prefixed_Name(nsprov, "generated") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:AgentInfluence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>AgentInfluence provides additional descriptions of an Agent's binary influence upon any other kind of resource. Instances of AgentInfluence use the prov:agent property to cite the influencing Agent.</para>
    ///   <para>It is not recommended that the type AgentInfluence be asserted without also asserting one of its more specific subclasses.</para>
    /// labels<para>AgentInfluence</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#AgentInfluence">http://www.w3.org/ns/prov#AgentInfluence</seealso>
    let AgentInfluence = Prefixed_Name(nsprov, "AgentInfluence") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:unqualifiedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Classes and properties used to qualify relationships are annotated with prov:unqualifiedForm to indicate the property used to assert an unqualified provenance relation.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#unqualifiedForm">http://www.w3.org/ns/prov#unqualifiedForm</seealso>
    let unqualifiedForm = Prefixed_Name(nsprov, "unqualifiedForm") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:has_anchor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates anchor URI for a potentially dynamic resource instance.</para>
    /// labels<para>has_anchor</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#has_anchor">http://www.w3.org/ns/prov#has_anchor</seealso>
    let has_anchor = Prefixed_Name(nsprov, "has_anchor") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:has_query_service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a provenance query service that can access provenance related to its subject or anchor resource.</para>
    /// labels<para>hasProvenanceService</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#has_query_service">http://www.w3.org/ns/prov#has_query_service</seealso>
    let has_query_service = Prefixed_Name(nsprov, "has_query_service") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadRevision</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>hadRevision</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadRevision">http://www.w3.org/ns/prov#hadRevision</seealso>
    let hadRevision = Prefixed_Name(nsprov, "hadRevision") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The _optional_ Usage involved in an Entity's Derivation.</para>
    /// labels<para>hadUsage</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadUsage">http://www.w3.org/ns/prov#hadUsage</seealso>
    let hadUsage = Prefixed_Name(nsprov, "hadUsage") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:has_provenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a provenance-URI for a resource; the resource identified by this property presents a provenance record about its subject or anchor resource.</para>
    /// labels<para>has_provenance</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#has_provenance">http://www.w3.org/ns/prov#has_provenance</seealso>
    let has_provenance = Prefixed_Name(nsprov, "has_provenance") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:informed</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>informed</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#informed">http://www.w3.org/ns/prov#informed</seealso>
    let informed = Prefixed_Name(nsprov, "informed") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:invalidated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>invalidated</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#invalidated">http://www.w3.org/ns/prov#invalidated</seealso>
    let invalidated = Prefixed_Name(nsprov, "invalidated") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Bundle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Note that there are kinds of bundles (e.g. handwritten letters, audio recordings, etc.) that are not expressed in PROV-O, but can be still be described by PROV-O.</para>
    /// labels<para>Bundle</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Bundle">http://www.w3.org/ns/prov#Bundle</seealso>
    let Bundle = Prefixed_Name(nsprov, "Bundle") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:locationOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>locationOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#locationOf">http://www.w3.org/ns/prov#locationOf</seealso>
    let locationOf = Prefixed_Name(nsprov, "locationOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Communication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of prov:Communication provides additional descriptions about the binary prov:wasInformedBy relation from an informed prov:Activity to the prov:Activity that informed it. For example, :you_jumping_off_bridge prov:wasInformedBy :everyone_else_jumping_off_bridge; prov:qualifiedCommunication [ a prov:Communication; prov:activity :everyone_else_jumping_off_bridge; :foo :bar ].</para>
    /// labels<para>Communication</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Communication">http://www.w3.org/ns/prov#Communication</seealso>
    let Communication = Prefixed_Name(nsprov, "Communication") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Contribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Contribute
    /// </para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Contribute">http://www.w3.org/ns/prov#Contribute</seealso>
    let Contribute = Prefixed_Name(nsprov, "Contribute") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Role</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Role">http://www.w3.org/ns/prov#Role</seealso>
    let Role = Prefixed_Name(nsprov, "Role") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Creator</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Creator">http://www.w3.org/ns/prov#Creator</seealso>
    let Creator = Prefixed_Name(nsprov, "Creator") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:actedOnBehalfOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An object property to express the accountability of an agent towards another agent. The subordinate agent acted on behalf of the responsible agent in an actual activity. </para>
    /// labels<para>actedOnBehalfOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#actedOnBehalfOf">http://www.w3.org/ns/prov#actedOnBehalfOf</seealso>
    let actedOnBehalfOf = Prefixed_Name(nsprov, "actedOnBehalfOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Dictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This concept allows for the provenance of the dictionary, but also of its constituents to be expressed. Such a notion of dictionary corresponds to a wide variety of concrete data structures, such as a maps or associative arrays.</para>
    ///   <para>A given dictionary forms a given structure for its members. A different structure (obtained either by insertion or removal of members) constitutes a different dictionary.</para>
    /// labels<para>Dictionary</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Dictionary">http://www.w3.org/ns/prov#Dictionary</seealso>
    let Dictionary = Prefixed_Name(nsprov, "Dictionary") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:todo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#todo">http://www.w3.org/ns/prov#todo</seealso>
    let todo = Prefixed_Name(nsprov, "todo") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasInformedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An activity a2 is dependent on or informed by another activity a1, by way of some unspecified entity that is generated by a1 and used by a2.</para>
    /// labels<para>wasInformedBy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasInformedBy">http://www.w3.org/ns/prov#wasInformedBy</seealso>
    let wasInformedBy = Prefixed_Name(nsprov, "wasInformedBy") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Copyright</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Copyright</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Copyright">http://www.w3.org/ns/prov#Copyright</seealso>
    let Copyright = Prefixed_Name(nsprov, "Copyright") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Delegation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of prov:Delegation provides additional descriptions about the binary prov:actedOnBehalfOf relation from a performing prov:Agent to some prov:Agent for whom it was performed. For example, :mixing prov:wasAssociatedWith :toddler . :toddler prov:actedOnBehalfOf :mother; prov:qualifiedDelegation [ a prov:Delegation; prov:entity :mother; :foo :bar ].</para>
    /// labels<para>Delegation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Delegation">http://www.w3.org/ns/prov#Delegation</seealso>
    let Delegation = Prefixed_Name(nsprov, "Delegation") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedInvalidationOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>qualifiedInvalidationOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedInvalidationOf">http://www.w3.org/ns/prov#qualifiedInvalidationOf</seealso>
    let qualifiedInvalidationOf =
        Prefixed_Name(nsprov, "qualifiedInvalidationOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedRemoval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>qualifiedRemoval</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedRemoval">http://www.w3.org/ns/prov#qualifiedRemoval</seealso>
    let qualifiedRemoval = Prefixed_Name(nsprov, "qualifiedRemoval") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Contributor</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Contributor">http://www.w3.org/ns/prov#Contributor</seealso>
    let Contributor = Prefixed_Name(nsprov, "Contributor") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Create</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Create</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Create">http://www.w3.org/ns/prov#Create</seealso>
    let Create = Prefixed_Name(nsprov, "Create") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedDerivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If this Entity prov:wasDerivedFrom Entity :e, then it can qualify how it was derived using prov:qualifiedDerivation [ a prov:Derivation;  prov:entity :e; :foo :bar ].</para>
    /// labels<para>qualifiedDerivation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedDerivation">http://www.w3.org/ns/prov#qualifiedDerivation</seealso>
    let qualifiedDerivation =
        Prefixed_Name(nsprov, "qualifiedDerivation") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedEndOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>qualifiedEndOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedEndOf">http://www.w3.org/ns/prov#qualifiedEndOf</seealso>
    let qualifiedEndOf = Prefixed_Name(nsprov, "qualifiedEndOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:pingback</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a resource to a provenance pingback service that may receive additional provenance links about the resource.</para>
    /// labels<para>provenance pingback</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#pingback">http://www.w3.org/ns/prov#pingback</seealso>
    let pingback = Prefixed_Name(nsprov, "pingback") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If this Activity prov:wasAssociatedWith Agent :ag, then it can qualify the Association using prov:qualifiedAssociation [ a prov:Association;  prov:agent :ag; :foo :bar ].</para>
    /// labels<para>qualifiedAssociation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedAssociation">http://www.w3.org/ns/prov#qualifiedAssociation</seealso>
    let qualifiedAssociation =
        Prefixed_Name(nsprov, "qualifiedAssociation") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedAssociationOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>qualifiedAssociationOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedAssociationOf">http://www.w3.org/ns/prov#qualifiedAssociationOf</seealso>
    let qualifiedAssociationOf =
        Prefixed_Name(nsprov, "qualifiedAssociationOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedAttributionOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>qualifiedAttributionOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedAttributionOf">http://www.w3.org/ns/prov#qualifiedAttributionOf</seealso>
    let qualifiedAttributionOf =
        Prefixed_Name(nsprov, "qualifiedAttributionOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedDelegationOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>qualifiedDelegationOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedDelegationOf">http://www.w3.org/ns/prov#qualifiedDelegationOf</seealso>
    let qualifiedDelegationOf =
        Prefixed_Name(nsprov, "qualifiedDelegationOf") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:Derivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of prov:Derivation provides additional descriptions about the binary prov:wasDerivedFrom relation from some derived prov:Entity to another prov:Entity from which it was derived. For example, :chewed_bubble_gum prov:wasDerivedFrom :unwrapped_bubble_gum; prov:qualifiedDerivation [ a prov:Derivation; prov:entity :unwrapped_bubble_gum; :foo :bar ].</para>
    ///   <para>The more specific forms of prov:Derivation (i.e., prov:Revision, prov:Quotation, prov:PrimarySource) should be asserted if they apply.</para>
    /// labels<para>Derivation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Derivation">http://www.w3.org/ns/prov#Derivation</seealso>
    let Derivation = Prefixed_Name(nsprov, "Derivation") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:DirectQueryService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Type for a generic provenance query service. Mainly for use in RDF provenance query service descriptions, to facilitate discovery in linked data environments.</para>
    /// labels<para>ProvenanceService</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#DirectQueryService">http://www.w3.org/ns/prov#DirectQueryService</seealso>
    let DirectQueryService = Prefixed_Name(nsprov, "DirectQueryService") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:aq</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#aq">http://www.w3.org/ns/prov#aq</seealso>
    let aq = Prefixed_Name(nsprov, "aq") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:EmptyDictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Empty Dictionary</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#EmptyDictionary">http://www.w3.org/ns/prov#EmptyDictionary</seealso>
    let EmptyDictionary = Prefixed_Name(nsprov, "EmptyDictionary") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Generation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of prov:Generation provides additional descriptions about the binary prov:wasGeneratedBy relation from a generated prov:Entity to the prov:Activity that generated it. For example, :cake prov:wasGeneratedBy :baking; prov:qualifiedGeneration [ a prov:Generation; prov:activity :baking; :foo :bar ].</para>
    /// labels<para>Generation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Generation">http://www.w3.org/ns/prov#Generation</seealso>
    let Generation = Prefixed_Name(nsprov, "Generation") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasGeneratedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>wasGeneratedBy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasGeneratedBy">http://www.w3.org/ns/prov#wasGeneratedBy</seealso>
    let wasGeneratedBy = Prefixed_Name(nsprov, "wasGeneratedBy") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:insertedKeyEntityPair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>insertedKeyEntityPair</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#insertedKeyEntityPair">http://www.w3.org/ns/prov#insertedKeyEntityPair</seealso>
    let insertedKeyEntityPair =
        Prefixed_Name(nsprov, "insertedKeyEntityPair") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:revisedEntity</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>revisedEntity</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#revisedEntity">http://www.w3.org/ns/prov#revisedEntity</seealso>
    let revisedEntity = Prefixed_Name(nsprov, "revisedEntity") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:started</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>started</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#started">http://www.w3.org/ns/prov#started</seealso>
    let started = Prefixed_Name(nsprov, "started") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>value</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#value">http://www.w3.org/ns/prov#value</seealso>
    let value = Prefixed_Name(nsprov, "value") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:wasActivityOfInfluence</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>wasActivityOfInfluence</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasActivityOfInfluence">http://www.w3.org/ns/prov#wasActivityOfInfluence</seealso>
    let wasActivityOfInfluence =
        Prefixed_Name(nsprov, "wasActivityOfInfluence") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:wasAssociateFor</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>wasAssociateFor</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasAssociateFor">http://www.w3.org/ns/prov#wasAssociateFor</seealso>
    let wasAssociateFor = Prefixed_Name(nsprov, "wasAssociateFor") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Agent</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Agent">http://www.w3.org/ns/prov#Agent</seealso>
    let Agent = Prefixed_Name(nsprov, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:hadPrimarySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hadPrimarySource</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#hadPrimarySource">http://www.w3.org/ns/prov#hadPrimarySource</seealso>
    let hadPrimarySource = Prefixed_Name(nsprov, "hadPrimarySource") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasQuotedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An entity is derived from an original entity by copying, or 'quoting', some or all of it.</para>
    /// labels<para>wasQuotedFrom</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasQuotedFrom">http://www.w3.org/ns/prov#wasQuotedFrom</seealso>
    let wasQuotedFrom = Prefixed_Name(nsprov, "wasQuotedFrom") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This document is published by the Provenance Working Group (http://www.w3.org/2011/prov/wiki/Main_Page).
    ///
    /// If you wish to make comments regarding this document, please send them to public-prov-comments@w3.org (subscribe public-prov-comments-request@w3.org, archives http://lists.w3.org/
    /// Archives/Public/public-prov-comments/). All feedback is welcome.</para>
    /// labels<para>W3C PROVenance Interchange</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#">http://www.w3.org/ns/prov#</seealso>
    let _prefix_iri = Prefixed_Name(nsprov, "") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:specializationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>specializationOf</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#specializationOf">http://www.w3.org/ns/prov#specializationOf</seealso>
    let specializationOf = Prefixed_Name(nsprov, "specializationOf") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:RightsHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>RightsHolder</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#RightsHolder">http://www.w3.org/ns/prov#RightsHolder</seealso>
    let RightsHolder = Prefixed_Name(nsprov, "RightsHolder") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:ServiceDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Type for a generic provenance query service. Mainly for use in RDF provenance query service descriptions, to facilitate discovery in linked data environments.</para>
    /// labels<para>ServiceDescription</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#ServiceDescription">http://www.w3.org/ns/prov#ServiceDescription</seealso>
    let ServiceDescription = Prefixed_Name(nsprov, "ServiceDescription") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:wasStartedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Start is when an activity is deemed to have started. A start may refer to an entity, known as trigger, that initiated the activity.</para>
    /// labels<para>wasStartedBy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#wasStartedBy">http://www.w3.org/ns/prov#wasStartedBy</seealso>
    let wasStartedBy = Prefixed_Name(nsprov, "wasStartedBy") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:Submit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Submit</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#Submit">http://www.w3.org/ns/prov#Submit</seealso>
    let Submit = Prefixed_Name(nsprov, "Submit") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:used</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A prov:Entity that was used by this prov:Activity. For example, :baking prov:used :spoon, :egg, :oven .</para>
    /// labels<para>used</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#used">http://www.w3.org/ns/prov#used</seealso>
    let used = Prefixed_Name(nsprov, "used") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:qualifiedDelegation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If this Agent prov:actedOnBehalfOf Agent :ag, then it can qualify how with prov:qualifiedResponsibility [ a prov:Responsibility;  prov:agent :ag; :foo :bar ].</para>
    /// labels<para>qualifiedDelegation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#qualifiedDelegation">http://www.w3.org/ns/prov#qualifiedDelegation</seealso>
    let qualifiedDelegation =
        Prefixed_Name(nsprov, "qualifiedDelegation") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:influencer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Subproperties of prov:influencer are used to cite the object of an unqualified PROV-O triple whose predicate is a subproperty of prov:wasInfluencedBy (e.g. prov:used, prov:wasGeneratedBy). prov:influencer is used much like rdf:object is used.</para>
    /// labels<para>influencer</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#influencer">http://www.w3.org/ns/prov#influencer</seealso>
    let influencer = Prefixed_Name(nsprov, "influencer") |> PrefixedName
    /// <summary>
    ///   <para>nsprov:editorialNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A note by the OWL development team about how this term expresses the PROV-DM concept, or how it should be used in context of semantic web or linked data.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/prov#editorialNote">http://www.w3.org/ns/prov#editorialNote</seealso>
    let editorialNote = Prefixed_Name(nsprov, "editorialNote") |> PrefixedName

    /// <summary>
    ///   <para>nsprov:activityOfInfluence</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>activityOfInfluence</para></remarks>
    /// <seealso href="http://www.w3.org/ns/prov#activityOfInfluence">http://www.w3.org/ns/prov#activityOfInfluence</seealso>
    let activityOfInfluence =
        Prefixed_Name(nsprov, "activityOfInfluence") |> PrefixedName
