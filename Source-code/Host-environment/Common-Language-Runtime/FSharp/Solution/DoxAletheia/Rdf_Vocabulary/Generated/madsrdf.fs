namespace http.www.loc.gov.mads.rdf.v1.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module madsrdf =
    let _namespace_iri = Namespace_Iri madsrdf |> NamespaceIRI
    /// <summary>
    ///   <para>madsrdf:Affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A resource that describes an individual's affiliation with an
    ///       organization or group, such as the nature of the affiliation and the active
    ///       dates.</para>
    /// labels<para>Affiliation</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Affiliation">http://www.loc.gov/mads/rdf/v1#Affiliation</seealso>
    let Affiliation = Prefixed_Name(madsrdf, "Affiliation") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Geographic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose label represents a geographic place or
    ///       feature, especially when a more precise geographic determination (City, Country, Region, etc.)
    ///       cannot be made.</para>
    /// labels<para>Geographic Authority</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Geographic">http://www.loc.gov/mads/rdf/v1#Geographic</seealso>
    let Geographic = Prefixed_Name(madsrdf, "Geographic") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:associatedLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Language that a person,
    ///       organization, or family uses for publication, communication, etc., or in which a work is
    ///       expressed. </para>
    /// labels<para>Associated
    ///       Language</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#associatedLanguage">http://www.loc.gov/mads/rdf/v1#associatedLanguage</seealso>
    let associatedLanguage =
        Prefixed_Name(madsrdf, "associatedLanguage") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:authoritativeLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A lexical string representing a controlled, curated label for the
    ///       Authority.</para>
    /// labels<para>Authoritative Label</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#authoritativeLabel">http://www.loc.gov/mads/rdf/v1#authoritativeLabel</seealso>
    let authoritativeLabel =
        Prefixed_Name(madsrdf, "authoritativeLabel") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label is a non-jurisdictional geographic entity.</para>
    /// labels<para>Area Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Area">http://www.loc.gov/mads/rdf/v1#Area</seealso>
    let Area = Prefixed_Name(madsrdf, "Area") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Variant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A resource whose label is the alternate form of an Authority or
    ///       Deprecated Authority.</para>
    /// labels<para>Variant</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Variant">http://www.loc.gov/mads/rdf/v1#Variant</seealso>
    let Variant = Prefixed_Name(madsrdf, "Variant") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:FamilyNameElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Family Name
    ///       Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#FamilyNameElement">http://www.loc.gov/mads/rdf/v1#FamilyNameElement</seealso>
    let FamilyNameElement = Prefixed_Name(madsrdf, "FamilyNameElement") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:GenreFormElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Genre/Form Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#GenreFormElement">http://www.loc.gov/mads/rdf/v1#GenreFormElement</seealso>
    let GenreFormElement = Prefixed_Name(madsrdf, "GenreFormElement") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:GivenNameElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Given Name
    ///       Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#GivenNameElement">http://www.loc.gov/mads/rdf/v1#GivenNameElement</seealso>
    let GivenNameElement = Prefixed_Name(madsrdf, "GivenNameElement") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A madsrdf:Identifier
    ///       resource describes an identifier by associating the identifier value with its type. To be used
    ///       to record identifiers for a resource in the absence of URIs.</para>
    /// labels<para>Other Identifier</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Identifier">http://www.loc.gov/mads/rdf/v1#Identifier</seealso>
    let Identifier = Prefixed_Name(madsrdf, "Identifier") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose label represents a
    ///       language.</para>
    /// labels<para>Language Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Language">http://www.loc.gov/mads/rdf/v1#Language</seealso>
    let Language = Prefixed_Name(madsrdf, "Language") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:TitleElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Title Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#TitleElement">http://www.loc.gov/mads/rdf/v1#TitleElement</seealso>
    let TitleElement = Prefixed_Name(madsrdf, "TitleElement") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:NonSortElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Non-sort Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#NonSortElement">http://www.loc.gov/mads/rdf/v1#NonSortElement</seealso>
    let NonSortElement = Prefixed_Name(madsrdf, "NonSortElement") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:PartNumberElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Part Number
    ///       Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#PartNumberElement">http://www.loc.gov/mads/rdf/v1#PartNumberElement</seealso>
    let PartNumberElement = Prefixed_Name(madsrdf, "PartNumberElement") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:PersonalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label represents a personal name.</para>
    /// labels<para>Personal Name Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#PersonalName">http://www.loc.gov/mads/rdf/v1#PersonalName</seealso>
    let PersonalName = Prefixed_Name(madsrdf, "PersonalName") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label is an area that has the status of a jurisdiction, usually incorporating more than one
    ///       first level jurisdiction. </para>
    /// labels<para>Region Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Region">http://www.loc.gov/mads/rdf/v1#Region</seealso>
    let Region = Prefixed_Name(madsrdf, "Region") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasMADSCollectionMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Associates an Authority or other Collection with a
    ///       madsrdf:MADSCollection.</para>
    /// labels<para>Has MADSCollection Member</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasMADSCollectionMember">http://www.loc.gov/mads/rdf/v1#hasMADSCollectionMember</seealso>
    let hasMADSCollectionMember =
        Prefixed_Name(madsrdf, "hasMADSCollectionMember") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasMADSSchemeMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an Authority or Collection with a
    ///       madsrdf:MADSScheme.</para>
    /// labels<para>Has MADS Scheme
    ///       Member</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasMADSSchemeMember">http://www.loc.gov/mads/rdf/v1#hasMADSSchemeMember</seealso>
    let hasMADSSchemeMember =
        Prefixed_Name(madsrdf, "hasMADSSchemeMember") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasNarrowerExternalAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Creates a direct
    ///       relationship between an Authority and a more narrowly defined Authority from a different MADS
    ///       Scheme.</para>
    /// labels<para>Has Narrower External
    ///       Authority</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasNarrowerExternalAuthority">http://www.loc.gov/mads/rdf/v1#hasNarrowerExternalAuthority</seealso>
    let hasNarrowerExternalAuthority =
        Prefixed_Name(madsrdf, "hasNarrowerExternalAuthority") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasReciprocalAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Establishes a relationship between two Authority resources. It is
    ///       reciprocal, so the relationship must be shared. This is Related type='equivalent' in MADS
    ///       XML.</para>
    /// labels<para>Has Reciprocal
    ///       Authority</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasReciprocalAuthority">http://www.loc.gov/mads/rdf/v1#hasReciprocalAuthority</seealso>
    let hasReciprocalAuthority =
        Prefixed_Name(madsrdf, "hasReciprocalAuthority") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasReciprocalExternalAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Establishes a relationship
    ///       between an Authority and one from a different MADS Scheme. It is reciprocal, so the
    ///       relationship must be shared.</para>
    /// labels<para>Has Reciprocal External
    ///       Authority</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasReciprocalExternalAuthority">http://www.loc.gov/mads/rdf/v1#hasReciprocalExternalAuthority</seealso>
    let hasReciprocalExternalAuthority =
        Prefixed_Name(madsrdf, "hasReciprocalExternalAuthority") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a resource description with its Source.</para>
    /// labels<para>Has Source</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasSource">http://www.loc.gov/mads/rdf/v1#hasSource</seealso>
    let hasSource = Prefixed_Name(madsrdf, "hasSource") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasTopMemberOfMADSScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies an Authority
    ///       that is at the top of the hierarchy of authorities within the MADS Scheme.</para>
    /// labels<para>Has Top Member of MADS
    ///       Scheme</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasTopMemberOfMADSScheme">http://www.loc.gov/mads/rdf/v1#hasTopMemberOfMADSScheme</seealso>
    let hasTopMemberOfMADSScheme =
        Prefixed_Name(madsrdf, "hasTopMemberOfMADSScheme") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:MADSCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A madsrdf:Collection is an
    ///       organizational unit, members of which will have some form of intellectually unifying theme but
    ///       not to the extent that it defines an independent knowledge organization system. It aggregates
    ///       madsrdf:Authority descriptions or other madsrdf:MADSCollection resources.</para>
    /// labels<para>MADS Collection</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#MADSCollection">http://www.loc.gov/mads/rdf/v1#MADSCollection</seealso>
    let MADSCollection = Prefixed_Name(madsrdf, "MADSCollection") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:idValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The value of the identifier
    ///       conforming to the Identifier Scheme syntax.</para>
    /// labels<para>Identifier Value</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#idValue">http://www.loc.gov/mads/rdf/v1#idValue</seealso>
    let idValue = Prefixed_Name(madsrdf, "idValue") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:identifiesRWO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Associates a
    ///       madsrdf:Authority with the Real World Object that is the subject of the authority's
    ///       label.</para>
    /// labels<para>Identifies RWO</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#identifiesRWO">http://www.loc.gov/mads/rdf/v1#identifiesRWO</seealso>
    let identifiesRWO = Prefixed_Name(madsrdf, "identifiesRWO") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:isIdentifiedByAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a Real World
    ///       Object with its Authority description.</para>
    /// labels<para>Is Identified By
    ///       Authority</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#isIdentifiedByAuthority">http://www.loc.gov/mads/rdf/v1#isIdentifiedByAuthority</seealso>
    let isIdentifiedByAuthority =
        Prefixed_Name(madsrdf, "isIdentifiedByAuthority") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:DeprecatedAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A former
    ///       Authority.</para>
    /// labels<para>Deprecated
    ///       Authority</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#DeprecatedAuthority">http://www.loc.gov/mads/rdf/v1#DeprecatedAuthority</seealso>
    let DeprecatedAuthority =
        Prefixed_Name(madsrdf, "DeprecatedAuthority") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label is an inhabited place incorporated as a city, town, etc.</para>
    /// labels<para>City Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#City">http://www.loc.gov/mads/rdf/v1#City</seealso>
    let City = Prefixed_Name(madsrdf, "City") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:CitySection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label is a smaller unit within a populated place, e.g., a neighborhood, park, or
    ///       street.</para>
    /// labels<para>City Section Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#CitySection">http://www.loc.gov/mads/rdf/v1#CitySection</seealso>
    let CitySection = Prefixed_Name(madsrdf, "CitySection") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:ComplexType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>madsrdf:ComplexType is a resource whose label is the concatenation
    ///       of labels from two or more Authority descriptions or two or more Variant descriptions or some
    ///       combination of Authority and Variant descriptions, each of a
    ///       madsrdf:SimpleType.</para>
    /// labels<para>Complex Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#ComplexType">http://www.loc.gov/mads/rdf/v1#ComplexType</seealso>
    let ComplexType = Prefixed_Name(madsrdf, "ComplexType") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:MADSType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>MADS Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#MADSType">http://www.loc.gov/mads/rdf/v1#MADSType</seealso>
    let MADSType = Prefixed_Name(madsrdf, "MADSType") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:HierarchicalGeographic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A madsrdf:HierarchicalGeographic indicates that its label is the
    ///       concatenation of labels from a sequence of madsrdf:Geographic types taken from one of the
    ///       madsrdf:Geographic sub-classes such as madsrdf:City, madsrdf:Country, madsrdf:State,
    ///       madsrdf:Region, madsrdf:Area, etc. The madsrdf:Geographic resources that constitute the
    ///       madsrdf:HierarchicalGeographic should have a broader to narrower hierarchical relationship
    ///       between them.</para>
    /// labels<para>Hierarchical Geographic Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#HierarchicalGeographic">http://www.loc.gov/mads/rdf/v1#HierarchicalGeographic</seealso>
    let HierarchicalGeographic =
        Prefixed_Name(madsrdf, "HierarchicalGeographic") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:SimpleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>madsrdf:SimpleType is a resource with a label constituting a single
    ///       word or phrase.</para>
    /// labels<para>Simple Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#SimpleType">http://www.loc.gov/mads/rdf/v1#SimpleType</seealso>
    let SimpleType = Prefixed_Name(madsrdf, "SimpleType") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:componentList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>madsrdf:componentList
    ///       organizes the madsrdf:SimpleType resources whose labels are represented in the label of the
    ///       associated madsrdf:ComplexType resource.</para>
    /// labels<para>Component List</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#componentList">http://www.loc.gov/mads/rdf/v1#componentList</seealso>
    let componentList = Prefixed_Name(madsrdf, "componentList") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:birthDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The year a person was born.
    ///       Date of birth may also include the month and day of the person’s birth. (RDA
    ///       9.3.2.1)</para>
    /// labels<para>Birth Date</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#birthDate">http://www.loc.gov/mads/rdf/v1#birthDate</seealso>
    let birthDate = Prefixed_Name(madsrdf, "birthDate") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:changeNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A note detailing a modification to an Authority or
    ///       Variant.</para>
    /// labels<para>Change Note</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#changeNote">http://www.loc.gov/mads/rdf/v1#changeNote</seealso>
    let changeNote = Prefixed_Name(madsrdf, "changeNote") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:citationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Should use a standard term - such as 'found' or 'not found' - to
    ///       indicate whether the cited resource yielded information about the resource related to the
    ///       madsrdf:Source.</para>
    /// labels<para>Citation Status</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#citationStatus">http://www.loc.gov/mads/rdf/v1#citationStatus</seealso>
    let citationStatus = Prefixed_Name(madsrdf, "citationStatus") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:city</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The city component of an address.</para>
    /// labels<para>City</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#city">http://www.loc.gov/mads/rdf/v1#city</seealso>
    let city = Prefixed_Name(madsrdf, "city") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The classification code associated with a
    ///       madsrdf:Authority.</para>
    /// labels<para>Classification</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#classification">http://www.loc.gov/mads/rdf/v1#classification</seealso>
    let classification = Prefixed_Name(madsrdf, "classification") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A code is a string of
    ///       characters associated with a the authoritative or deprecated label. It may record an
    ///       historical notation once used to uniquely identify a concept.</para>
    /// labels<para>Code</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#code">http://www.loc.gov/mads/rdf/v1#code</seealso>
    let code = Prefixed_Name(madsrdf, "code") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:creationDateEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Ending date of the date range for which the beginning date is recorded in madsrdf:creationDateStart.</para>
    /// labels<para></para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#creationDateEnd">http://www.loc.gov/mads/rdf/v1#creationDateEnd</seealso>
    let creationDateEnd = Prefixed_Name(madsrdf, "creationDateEnd") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:deathDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The year a person died.
    ///       Date of death may also include the month and day of the person’s death. (RDA
    ///       9.3.3.1)</para>
    /// labels<para>Death Date</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#deathDate">http://www.loc.gov/mads/rdf/v1#deathDate</seealso>
    let deathDate = Prefixed_Name(madsrdf, "deathDate") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:definitionNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>An explanation of the meaning of an Authority, DeprecatedAuthority,
    ///       or Variant description.</para>
    /// labels<para>Definition Note</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#definitionNote">http://www.loc.gov/mads/rdf/v1#definitionNote</seealso>
    let definitionNote = Prefixed_Name(madsrdf, "definitionNote") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:deletionNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A note pertaining to the
    ///       deletion of a resource.</para>
    /// labels<para>Deletion Note</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#deletionNote">http://www.loc.gov/mads/rdf/v1#deletionNote</seealso>
    let deletionNote = Prefixed_Name(madsrdf, "deletionNote") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:deprecatedLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A label once considered
    ///       authoritative (controlled and curated) but which is no longer.</para>
    /// labels<para>Deprecated Label</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#deprecatedLabel">http://www.loc.gov/mads/rdf/v1#deprecatedLabel</seealso>
    let deprecatedLabel = Prefixed_Name(madsrdf, "deprecatedLabel") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:ComplexSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The label of a madsrdf:ComplexSubject is the concatenation of labels
    ///       from two or more madsrdf:SimpleType descriptions, except that the combination of
    ///       madsrdf:SimpleType labels for the madsrdf:ComplexSubject does not meet the conditions to be
    ///       the label of a madsrdf:NameTitle resource or madsrdf:HierarchicalGeographic
    ///       resource.</para>
    /// labels<para>Complex Subject Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#ComplexSubject">http://www.loc.gov/mads/rdf/v1#ComplexSubject</seealso>
    let ComplexSubject = Prefixed_Name(madsrdf, "ComplexSubject") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:NameTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The label of a madsrdf:NameTitle resource is the concatenation of a
    ///       label of a madsrdf:Name description and the label of a madsrdf:Title description. Both
    ///       description types (madsrdf:Name and madsrdf:Title) are of madsrdf:SimpleType
    ///       types.</para>
    /// labels<para>Name/Title Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#NameTitle">http://www.loc.gov/mads/rdf/v1#NameTitle</seealso>
    let NameTitle = Prefixed_Name(madsrdf, "NameTitle") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose label represents a name, especially when
    ///       a more precise Name type (madsrdf:ConferenceName, masdrdf:FamilyName, etc.) cannot be
    ///       identified.</para>
    /// labels<para>Name Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Name">http://www.loc.gov/mads/rdf/v1#Name</seealso>
    let Name = Prefixed_Name(madsrdf, "Name") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label is a country, i.e. a political entity considered a country. </para>
    /// labels<para>Country Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Country">http://www.loc.gov/mads/rdf/v1#Country</seealso>
    let Country = Prefixed_Name(madsrdf, "Country") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Country associated with an
    ///       address.</para>
    /// labels<para>Country</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#country">http://www.loc.gov/mads/rdf/v1#country</seealso>
    let country = Prefixed_Name(madsrdf, "country") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:creationDateStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For a work, earliest date (normally the year) associated with a work; that date may be the date the work was created or first published or released. For an expression, the earliest date (normally the year) associated with an expression; that date may be the date of the earliest known manifestation of that expression. In both cases the date may be the starting date of a range or a single date.</para>
    /// labels<para>Work begun</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#creationDateStart">http://www.loc.gov/mads/rdf/v1#creationDateStart</seealso>
    let creationDateStart = Prefixed_Name(madsrdf, "creationDateStart") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:deathPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The town, city, province,
    ///       state, and/or country in which a person died.</para>
    /// labels<para>Place of Death</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#deathPlace">http://www.loc.gov/mads/rdf/v1#deathPlace</seealso>
    let deathPlace = Prefixed_Name(madsrdf, "deathPlace") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:editorialNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A note pertaining to the
    ///       management of the label associated with the resource.</para>
    /// labels<para>Editorial Note</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#editorialNote">http://www.loc.gov/mads/rdf/v1#editorialNote</seealso>
    let editorialNote = Prefixed_Name(madsrdf, "editorialNote") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:elementList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The madsrdf:elementList property is used to organize the various
    ///       parts of labels.</para>
    /// labels<para>Element List</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#elementList">http://www.loc.gov/mads/rdf/v1#elementList</seealso>
    let elementList = Prefixed_Name(madsrdf, "elementList") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:entityDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Any attribute that serves
    ///       to characterize a person, family or corporate body or that may be needed for differentiation
    ///       from other persons. families or corporate bodies and for which separate content designation is
    ///       not already defined.Or </para>
    /// labels<para>Entity
    ///       Descriptor</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#entityDescriptor">http://www.loc.gov/mads/rdf/v1#entityDescriptor</seealso>
    let entityDescriptor = Prefixed_Name(madsrdf, "entityDescriptor") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:extendedAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The second address line, if
    ///       needed.</para>
    /// labels<para>Extended Address</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#extendedAddress">http://www.loc.gov/mads/rdf/v1#extendedAddress</seealso>
    let extendedAddress = Prefixed_Name(madsrdf, "extendedAddress") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:fax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Fax number</para>
    /// labels<para>Fax</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#fax">http://www.loc.gov/mads/rdf/v1#fax</seealso>
    let fax = Prefixed_Name(madsrdf, "fax") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:fieldOfActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The field of activity
    ///       associated with an individual.</para>
    /// labels<para>Field of
    ///       Activity</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#fieldOfActivity">http://www.loc.gov/mads/rdf/v1#fieldOfActivity</seealso>
    let fieldOfActivity = Prefixed_Name(madsrdf, "fieldOfActivity") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DataTypeProperty</para>
    ///   <para>The gender with which a
    ///       person identifies. </para>
    /// labels<para>Gender</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#gender">http://www.loc.gov/mads/rdf/v1#gender</seealso>
    let gender = Prefixed_Name(madsrdf, "gender") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:hasAcronymVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Has Acronym
    ///       Variant</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasAcronymVariant">http://www.loc.gov/mads/rdf/v1#hasAcronymVariant</seealso>
    let hasAcronymVariant = Prefixed_Name(madsrdf, "hasAcronymVariant") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:hasAffiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property to associate an
    ///       individual, such as a foaf:Agent, to a group or organization with which an individual is or
    ///       has been affiliated.</para>
    /// labels<para>Has Affiliation</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasAffiliation">http://www.loc.gov/mads/rdf/v1#hasAffiliation</seealso>
    let hasAffiliation = Prefixed_Name(madsrdf, "hasAffiliation") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:ConferenceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label represents a conference name.</para>
    /// labels<para>Conference Name Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#ConferenceName">http://www.loc.gov/mads/rdf/v1#ConferenceName</seealso>
    let ConferenceName = Prefixed_Name(madsrdf, "ConferenceName") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:CorporateName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label is the name of a corporate entity, which may include political or ecclesiastical
    ///       entities.</para>
    /// labels<para>Corporate Name Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#CorporateName">http://www.loc.gov/mads/rdf/v1#CorporateName</seealso>
    let CorporateName = Prefixed_Name(madsrdf, "CorporateName") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:DateNameElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Date Name
    ///       Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#DateNameElement">http://www.loc.gov/mads/rdf/v1#DateNameElement</seealso>
    let DateNameElement = Prefixed_Name(madsrdf, "DateNameElement") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:TopicElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Topic Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#TopicElement">http://www.loc.gov/mads/rdf/v1#TopicElement</seealso>
    let TopicElement = Prefixed_Name(madsrdf, "TopicElement") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:activityStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Earliest date in a period of activity.
    ///     </para>
    /// labels<para>Activity Start</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#activityStartDate">http://www.loc.gov/mads/rdf/v1#activityStartDate</seealso>
    let activityStartDate = Prefixed_Name(madsrdf, "activityStartDate") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:affiliationEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The date an individual
    ///       ceased to be affiliated with an organization.</para>
    /// labels<para>Affiliation
    ///       Ended</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#affiliationEnd">http://www.loc.gov/mads/rdf/v1#affiliationEnd</seealso>
    let affiliationEnd = Prefixed_Name(madsrdf, "affiliationEnd") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:affiliationStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date an individual
    ///       established an affiliation with an organization.</para>
    /// labels<para>Affiliation
    ///       Started</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#affiliationStart">http://www.loc.gov/mads/rdf/v1#affiliationStart</seealso>
    let affiliationStart = Prefixed_Name(madsrdf, "affiliationStart") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:associatedLocale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A town, city, province,
    ///       state, and/or country associated with persons, corporate bodies, families, works, and
    ///       expressions.</para>
    /// labels<para>Associated Locale</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#associatedLocale">http://www.loc.gov/mads/rdf/v1#associatedLocale</seealso>
    let associatedLocale = Prefixed_Name(madsrdf, "associatedLocale") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:birthPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The town, city, province,
    ///       state, and/or country in which a person was born.</para>
    /// labels<para>Place of Birth</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#birthPlace">http://www.loc.gov/mads/rdf/v1#birthPlace</seealso>
    let birthPlace = Prefixed_Name(madsrdf, "birthPlace") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A note about the
    ///       resource.</para>
    /// labels<para>Note</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#note">http://www.loc.gov/mads/rdf/v1#note</seealso>
    let note = Prefixed_Name(madsrdf, "note") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:citationNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A note about how the madsrdf:Source relates to the resource about
    ///       which the madsrdf:Source is the information source.</para>
    /// labels<para>Citation Note</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#citationNote">http://www.loc.gov/mads/rdf/v1#citationNote</seealso>
    let citationNote = Prefixed_Name(madsrdf, "citationNote") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:citationSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The cited resource.</para>
    /// labels<para>Citation Source</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#citationSource">http://www.loc.gov/mads/rdf/v1#citationSource</seealso>
    let citationSource = Prefixed_Name(madsrdf, "citationSource") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Continent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label is one of seven large landmasses on Earth. These are: Asia, Africa, Europe, North
    ///       America, South America, Australia, and Antarctica.</para>
    /// labels<para>Continent Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Continent">http://www.loc.gov/mads/rdf/v1#Continent</seealso>
    let Continent = Prefixed_Name(madsrdf, "Continent") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:County</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label is the largest local administrative unit, e.g. Warwickshire, in a country, e.g.
    ///       England.</para>
    /// labels<para>County Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#County">http://www.loc.gov/mads/rdf/v1#County</seealso>
    let County = Prefixed_Name(madsrdf, "County") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:NameElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Name Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#NameElement">http://www.loc.gov/mads/rdf/v1#NameElement</seealso>
    let NameElement = Prefixed_Name(madsrdf, "NameElement") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:elementValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Element Value</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#elementValue">http://www.loc.gov/mads/rdf/v1#elementValue</seealso>
    let elementValue = Prefixed_Name(madsrdf, "elementValue") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:extension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Extension</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#extension">http://www.loc.gov/mads/rdf/v1#extension</seealso>
    let extension = Prefixed_Name(madsrdf, "extension") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:fullerName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Full form of name needed to
    ///       distinguish a person from another person with the same preferred name.</para>
    /// labels<para>Fuller Name</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#fullerName">http://www.loc.gov/mads/rdf/v1#fullerName</seealso>
    let fullerName = Prefixed_Name(madsrdf, "fullerName") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasAbbreviationVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Has Abbreviation
    ///       Variant</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasAbbreviationVariant">http://www.loc.gov/mads/rdf/v1#hasAbbreviationVariant</seealso>
    let hasAbbreviationVariant =
        Prefixed_Name(madsrdf, "hasAbbreviationVariant") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Associates a Variant with an Authority or Deprecrated Authority.
    ///       Unless the variant type can be more specifically identified, use 'hasVariant.'</para>
    /// labels<para>Has Variant</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasVariant">http://www.loc.gov/mads/rdf/v1#hasVariant</seealso>
    let hasVariant = Prefixed_Name(madsrdf, "hasVariant") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasAffiliationAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The address of the group or
    ///       organization with which an individual is associated.</para>
    /// labels<para>Has Affiliation
    ///       Address</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasAffiliationAddress">http://www.loc.gov/mads/rdf/v1#hasAffiliationAddress</seealso>
    let hasAffiliationAddress =
        Prefixed_Name(madsrdf, "hasAffiliationAddress") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasRelatedAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Unless the relationship can be more specifically identified, use
    ///       'hasRelatedAuthority.'</para>
    /// labels<para>Has Related Authority</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasRelatedAuthority">http://www.loc.gov/mads/rdf/v1#hasRelatedAuthority</seealso>
    let hasRelatedAuthority =
        Prefixed_Name(madsrdf, "hasRelatedAuthority") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasChararacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A term that specifies a characteristic that differentiates a work or expression from another one.
    ///     </para>
    /// labels<para>Other characteristic</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasChararacteristic">http://www.loc.gov/mads/rdf/v1#hasChararacteristic</seealso>
    let hasChararacteristic =
        Prefixed_Name(madsrdf, "hasChararacteristic") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:Element</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>madsrdf:Element types
    ///       describe the various parts of labels.</para>
    /// labels<para>Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Element">http://www.loc.gov/mads/rdf/v1#Element</seealso>
    let Element = Prefixed_Name(madsrdf, "Element") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:email</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Email</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#email">http://www.loc.gov/mads/rdf/v1#email</seealso>
    let email = Prefixed_Name(madsrdf, "email") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:establishDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The year a corporate body was established. Date of establishment may also include the month and day of the corporate body’s establishment.
    ///     </para>
    /// labels<para>Established</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#establishDate">http://www.loc.gov/mads/rdf/v1#establishDate</seealso>
    let establishDate = Prefixed_Name(madsrdf, "establishDate") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:exampleNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A example of how the
    ///       resource might be used.</para>
    /// labels<para>Example Note</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#exampleNote">http://www.loc.gov/mads/rdf/v1#exampleNote</seealso>
    let exampleNote = Prefixed_Name(madsrdf, "exampleNote") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:ExtraterrestrialArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label is any extraterrestrial entity or space, including a solar system, a galaxy, a star
    ///       system, and a planet, including a geographic feature of an individual planet.</para>
    /// labels<para>Extraterrestrial Area Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#ExtraterrestrialArea">http://www.loc.gov/mads/rdf/v1#ExtraterrestrialArea</seealso>
    let ExtraterrestrialArea =
        Prefixed_Name(madsrdf, "ExtraterrestrialArea") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:FamilyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label represents a family name.</para>
    /// labels<para>Family Name Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#FamilyName">http://www.loc.gov/mads/rdf/v1#FamilyName</seealso>
    let FamilyName = Prefixed_Name(madsrdf, "FamilyName") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:GenreForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose label is a genre or form term. Genre
    ///       terms for textual materials designate specific kinds of materials distinguished by the style
    ///       or technique of their intellectual contents; for example, biographies, catechisms, essays,
    ///       hymns, or reviews. Form terms designate historically and functionally specific kinds of
    ///       materials as distinguished by an examination of their physical character, characteristics of
    ///       their intellectual content, or the order of information within them; for example, daybooks,
    ///       diaries, directories, journals, memoranda, questionnaires, syllabi, or time sheets. In the
    ///       context of graphic materials, genre headings denote categories of material distinguished by
    ///       vantage point, intended purpose, characteristics of the creator, publication status, or method
    ///       of representation.</para>
    /// labels<para>Genre/Form Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#GenreForm">http://www.loc.gov/mads/rdf/v1#GenreForm</seealso>
    let GenreForm = Prefixed_Name(madsrdf, "GenreForm") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasCloseExternalAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Records a relationship
    ///       between an Authority and one that is closely related from a different MADS
    ///       Scheme.</para>
    /// labels<para>Has Close External
    ///       Authority</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasCloseExternalAuthority">http://www.loc.gov/mads/rdf/v1#hasCloseExternalAuthority</seealso>
    let hasCloseExternalAuthority =
        Prefixed_Name(madsrdf, "hasCloseExternalAuthority") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasCorporateParentAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Establishes a relationship
    ///       between a CorporateName Authority and one of the same that is more broadly
    ///       defined.</para>
    /// labels<para>Has Parent
    ///       Organization</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasCorporateParentAuthority">http://www.loc.gov/mads/rdf/v1#hasCorporateParentAuthority</seealso>
    let hasCorporateParentAuthority =
        Prefixed_Name(madsrdf, "hasCorporateParentAuthority") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasEarlierEstablishedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to reference a resource that was an earlier form. This is
    ///       Related type='earlier' in MADS XML.</para>
    /// labels<para>Has Earlier Established
    ///       Form</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasEarlierEstablishedForm">http://www.loc.gov/mads/rdf/v1#hasEarlierEstablishedForm</seealso>
    let hasEarlierEstablishedForm =
        Prefixed_Name(madsrdf, "hasEarlierEstablishedForm") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasLaterEstablishedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Use to reference the later form of a resource. This is Related
    ///       type='later' in MADS XML.</para>
    /// labels<para>Has Later Established
    ///       Form</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasLaterEstablishedForm">http://www.loc.gov/mads/rdf/v1#hasLaterEstablishedForm</seealso>
    let hasLaterEstablishedForm =
        Prefixed_Name(madsrdf, "hasLaterEstablishedForm") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasExactExternalAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Records a relationship
    ///       between an Authority and one to which it matches exactly but from a different MADS
    ///       Scheme.</para>
    /// labels<para>Has Exact External
    ///       Authority</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasExactExternalAuthority">http://www.loc.gov/mads/rdf/v1#hasExactExternalAuthority</seealso>
    let hasExactExternalAuthority =
        Prefixed_Name(madsrdf, "hasExactExternalAuthority") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasHiddenVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Use for variants that are searchable, but not necessarily for
    ///       display.</para>
    /// labels<para>Has Hidden Variant</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasHiddenVariant">http://www.loc.gov/mads/rdf/v1#hasHiddenVariant</seealso>
    let hasHiddenVariant = Prefixed_Name(madsrdf, "hasHiddenVariant") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:hasIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Associates a resource with
    ///       a madsrdf:Identifier.</para>
    /// labels<para>Has Identifier</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasIdentifier">http://www.loc.gov/mads/rdf/v1#hasIdentifier</seealso>
    let hasIdentifier = Prefixed_Name(madsrdf, "hasIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:FullNameElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Fullname Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#FullNameElement">http://www.loc.gov/mads/rdf/v1#FullNameElement</seealso>
    let FullNameElement = Prefixed_Name(madsrdf, "FullNameElement") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasBroaderAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Has Broader
    ///       Authority</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasBroaderAuthority">http://www.loc.gov/mads/rdf/v1#hasBroaderAuthority</seealso>
    let hasBroaderAuthority =
        Prefixed_Name(madsrdf, "hasBroaderAuthority") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasNarrowerAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Creates a direct
    ///       relationship between an Authority and one that is more narrowly defined.</para>
    /// labels<para>Has Narrower
    ///       Authority</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasNarrowerAuthority">http://www.loc.gov/mads/rdf/v1#hasNarrowerAuthority</seealso>
    let hasNarrowerAuthority =
        Prefixed_Name(madsrdf, "hasNarrowerAuthority") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasBroaderExternalAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Creates a direct
    ///       relationship between an Authority and a more broadly defined Authority from a different MADS
    ///       Scheme.</para>
    /// labels<para>Has Broader External
    ///       Authority</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasBroaderExternalAuthority">http://www.loc.gov/mads/rdf/v1#hasBroaderExternalAuthority</seealso>
    let hasBroaderExternalAuthority =
        Prefixed_Name(madsrdf, "hasBroaderExternalAuthority") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasCorporateSubsidiaryAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relationship
    ///       between a CorporateName Authority and one of the same that is more narrowly
    ///       defined.</para>
    /// labels<para>Is Parent Organization
    ///       Of</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasCorporateSubsidiaryAuthority">http://www.loc.gov/mads/rdf/v1#hasCorporateSubsidiaryAuthority</seealso>
    let hasCorporateSubsidiaryAuthority =
        Prefixed_Name(madsrdf, "hasCorporateSubsidiaryAuthority") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:see</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Denotes a relationship
    ///       between an Authority and/or DeprecatedAuthority. The relationship may or may or may not be
    ///       reciprocated and there is no certainty that the related resource will further illuminate the
    ///       original resource.</para>
    /// labels<para>See Also</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#see">http://www.loc.gov/mads/rdf/v1#see</seealso>
    let see = Prefixed_Name(madsrdf, "see") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:GeographicElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geographic Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#GeographicElement">http://www.loc.gov/mads/rdf/v1#GeographicElement</seealso>
    let GeographicElement = Prefixed_Name(madsrdf, "GeographicElement") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Island</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label is a tract of land surrounded by water and smaller than a continent but is not itself a
    ///       separate country. </para>
    /// labels<para>Island Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Island">http://www.loc.gov/mads/rdf/v1#Island</seealso>
    let Island = Prefixed_Name(madsrdf, "Island") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasExpansionVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Has Expansion
    ///       Variant</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasExpansionVariant">http://www.loc.gov/mads/rdf/v1#hasExpansionVariant</seealso>
    let hasExpansionVariant =
        Prefixed_Name(madsrdf, "hasExpansionVariant") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:LanguageElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Language Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#LanguageElement">http://www.loc.gov/mads/rdf/v1#LanguageElement</seealso>
    let LanguageElement = Prefixed_Name(madsrdf, "LanguageElement") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:isMemberOfMADSCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Associates a Collection with a madsrdf:Authority or another
    ///       madsrdf:MADSCollection.</para>
    /// labels<para>Is Member Of MADSCollection</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#isMemberOfMADSCollection">http://www.loc.gov/mads/rdf/v1#isMemberOfMADSCollection</seealso>
    let isMemberOfMADSCollection =
        Prefixed_Name(madsrdf, "isMemberOfMADSCollection") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:isMemberOfMADSScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Is Member of MADS
    ///       Scheme</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#isMemberOfMADSScheme">http://www.loc.gov/mads/rdf/v1#isMemberOfMADSScheme</seealso>
    let isMemberOfMADSScheme =
        Prefixed_Name(madsrdf, "isMemberOfMADSScheme") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:MainTitleElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Main Title
    ///       Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#MainTitleElement">http://www.loc.gov/mads/rdf/v1#MainTitleElement</seealso>
    let MainTitleElement = Prefixed_Name(madsrdf, "MainTitleElement") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Occupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label represents an occcupation.</para>
    /// labels<para>Occupation Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Occupation">http://www.loc.gov/mads/rdf/v1#Occupation</seealso>
    let Occupation = Prefixed_Name(madsrdf, "Occupation") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:hours</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Hours</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hours">http://www.loc.gov/mads/rdf/v1#hours</seealso>
    let hours = Prefixed_Name(madsrdf, "hours") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:isTopMemberOfMADSScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Identifies a MADS Scheme in
    ///       which the Authority is at the top of the hierarchy.</para>
    /// labels<para>Is Top Member of MADS
    ///       Scheme</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#isTopMemberOfMADSScheme">http://www.loc.gov/mads/rdf/v1#isTopMemberOfMADSScheme</seealso>
    let isTopMemberOfMADSScheme =
        Prefixed_Name(madsrdf, "isTopMemberOfMADSScheme") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:natureOfAffiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Records the individual's
    ///       role or position in the organization with which the individual is affiliated. A "job title"
    ///       might be appropriate.</para>
    /// labels<para>Nature of
    ///       Affiliation</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#natureOfAffiliation">http://www.loc.gov/mads/rdf/v1#natureOfAffiliation</seealso>
    let natureOfAffiliation =
        Prefixed_Name(madsrdf, "natureOfAffiliation") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:occupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A profession or occupation
    ///       in which the person works or has worked.</para>
    /// labels<para>Occupation</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#occupation">http://www.loc.gov/mads/rdf/v1#occupation</seealso>
    let occupation = Prefixed_Name(madsrdf, "occupation") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The group or organization
    ///       with which an individual is associated.</para>
    /// labels<para>Organization or
    ///       Group</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#organization">http://www.loc.gov/mads/rdf/v1#organization</seealso>
    let organization = Prefixed_Name(madsrdf, "organization") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:phone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Phone</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#phone">http://www.loc.gov/mads/rdf/v1#phone</seealso>
    let phone = Prefixed_Name(madsrdf, "phone") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:prominentFamilyMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A well-known individual who
    ///       is a member of the family.</para>
    /// labels<para>Prominent Family
    ///       Member</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#prominentFamilyMember">http://www.loc.gov/mads/rdf/v1#prominentFamilyMember</seealso>
    let prominentFamilyMember =
        Prefixed_Name(madsrdf, "prominentFamilyMember") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:state</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The state associated with
    ///       an address.</para>
    /// labels<para>State</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#state">http://www.loc.gov/mads/rdf/v1#state</seealso>
    let state = Prefixed_Name(madsrdf, "state") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:streetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>First line of address. For
    ///       second line, use madsrdf:extendedAddress.</para>
    /// labels<para>Street Address</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#streetAddress">http://www.loc.gov/mads/rdf/v1#streetAddress</seealso>
    let streetAddress = Prefixed_Name(madsrdf, "streetAddress") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:terminateDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The year a corporate body was terminated. Date of termination may also include the month and day of the corporate body’s termination.
    ///     </para>
    /// labels<para>Terminated</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#terminateDate">http://www.loc.gov/mads/rdf/v1#terminateDate</seealso>
    let terminateDate = Prefixed_Name(madsrdf, "terminateDate") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:useFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Use [This Resource] For."
    ///       Traditional "USE FOR" reference.</para>
    /// labels<para>Use For</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#useFor">http://www.loc.gov/mads/rdf/v1#useFor</seealso>
    let useFor = Prefixed_Name(madsrdf, "useFor") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:useInstead</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Use [This Other Resource]
    ///       Instead." Traditional "USE" reference.</para>
    /// labels<para>Use Instead</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#useInstead">http://www.loc.gov/mads/rdf/v1#useInstead</seealso>
    let useInstead = Prefixed_Name(madsrdf, "useInstead") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:variantLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The lexical, variant form
    ///       of an authoritative label.</para>
    /// labels<para>Variant Label</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#variantLabel">http://www.loc.gov/mads/rdf/v1#variantLabel</seealso>
    let variantLabel = Prefixed_Name(madsrdf, "variantLabel") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:workOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The country or other territorial jurisdiction from which a work originated.</para>
    /// labels<para>Work locale</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#workOrigin">http://www.loc.gov/mads/rdf/v1#workOrigin</seealso>
    let workOrigin = Prefixed_Name(madsrdf, "workOrigin") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:PartNameElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Part Name
    ///       Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#PartNameElement">http://www.loc.gov/mads/rdf/v1#PartNameElement</seealso>
    let PartNameElement = Prefixed_Name(madsrdf, "PartNameElement") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Province</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label is a first order political division, e.g. Ontario, within a country, e.g. Canada. </para>
    /// labels<para>Province Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Province">http://www.loc.gov/mads/rdf/v1#Province</seealso>
    let Province = Prefixed_Name(madsrdf, "Province") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:postcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Post Code / Zip
    ///       Code</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#postcode">http://www.loc.gov/mads/rdf/v1#postcode</seealso>
    let postcode = Prefixed_Name(madsrdf, "postcode") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:scopeNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>Scope Note</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#scopeNote">http://www.loc.gov/mads/rdf/v1#scopeNote</seealso>
    let scopeNote = Prefixed_Name(madsrdf, "scopeNote") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:RWO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A madsrdf:RWO is an
    ///       abstract entity and identifies a Real World Object (RWO) identified by the label of a
    ///       madsrdf:Authority or madsrdf:DeprecatedAuthority.</para>
    /// labels<para>Real World
    ///       Object</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#RWO">http://www.loc.gov/mads/rdf/v1#RWO</seealso>
    let RWO = Prefixed_Name(madsrdf, "RWO") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A resource that represents
    ///       the source of information about another resource. madsrdf:Source is a type of
    ///       citation.</para>
    /// labels<para>Source</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Source">http://www.loc.gov/mads/rdf/v1#Source</seealso>
    let Source = Prefixed_Name(madsrdf, "Source") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label is a first order political division, e.g. Montana, within a country, e.g.
    ///       U.S.</para>
    /// labels<para>State Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#State">http://www.loc.gov/mads/rdf/v1#State</seealso>
    let State = Prefixed_Name(madsrdf, "State") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:SubTitleElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Subtitle Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#SubTitleElement">http://www.loc.gov/mads/rdf/v1#SubTitleElement</seealso>
    let SubTitleElement = Prefixed_Name(madsrdf, "SubTitleElement") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:TemporalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Temporal Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#TemporalElement">http://www.loc.gov/mads/rdf/v1#TemporalElement</seealso>
    let TemporalElement = Prefixed_Name(madsrdf, "TemporalElement") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Territory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label is a geographical area belonging to or under the jurisdiction of a governmental
    ///       authority. </para>
    /// labels<para>Territory Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Territory">http://www.loc.gov/mads/rdf/v1#Territory</seealso>
    let Territory = Prefixed_Name(madsrdf, "Territory") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Temporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label represents a time-based notion.</para>
    /// labels<para>Temporal Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Temporal">http://www.loc.gov/mads/rdf/v1#Temporal</seealso>
    let Temporal = Prefixed_Name(madsrdf, "Temporal") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:TermsOfAddressNameElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Terms of Address
    ///       Element</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#TermsOfAddressNameElement">http://www.loc.gov/mads/rdf/v1#TermsOfAddressNameElement</seealso>
    let TermsOfAddressNameElement =
        Prefixed_Name(madsrdf, "TermsOfAddressNameElement") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:Topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label represents a topic.</para>
    /// labels<para>Topic Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Topic">http://www.loc.gov/mads/rdf/v1#Topic</seealso>
    let Topic = Prefixed_Name(madsrdf, "Topic") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:activityEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Latest date in a period of activity.
    ///     </para>
    /// labels<para>Activity End</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#activityEndDate">http://www.loc.gov/mads/rdf/v1#activityEndDate</seealso>
    let activityEndDate = Prefixed_Name(madsrdf, "activityEndDate") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:adminMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This relates an Authority or Variant to its administrative metadata,
    ///       which is, minimimally, a Class defined outside of the MADS/RDF namespace. The RecordInfo Class
    ///       from the RecordInfo ontology is recommended.</para>
    /// labels<para>Administrative Metadata</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#adminMetadata">http://www.loc.gov/mads/rdf/v1#adminMetadata</seealso>
    let adminMetadata = Prefixed_Name(madsrdf, "adminMetadata") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a resource whose
    ///       label represents a title.</para>
    /// labels<para>Title Type</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Title">http://www.loc.gov/mads/rdf/v1#Title</seealso>
    let Title = Prefixed_Name(madsrdf, "Title") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Address">http://www.loc.gov/mads/rdf/v1#Address</seealso>
    let Address = Prefixed_Name(madsrdf, "Address") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:Authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A concept with a controlled
    ///       label.</para>
    /// labels<para>Authority</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#Authority">http://www.loc.gov/mads/rdf/v1#Authority</seealso>
    let Authority = Prefixed_Name(madsrdf, "Authority") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:MADSScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>MADS Scheme is an organizational unit that describes a knowledge
    ///       organization system. It aggregates madsrdf:Authority descriptions and/or
    ///       madsrdf:MADSCollection resources included in the knowledge organization system. Including a
    ///       madsrdf:MADSCollection within a madsrdf:MADSScheme should be done with care; when a
    ///       madsrdf:MADSCollection is part of a madsrdf:MADSScheme, then any madsrdf:Authority within that
    ///       madsrdf:MADSCollection is effectively also in the madsrdf:MADSScheme.</para>
    /// labels<para>MADS Scheme</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#MADSScheme">http://www.loc.gov/mads/rdf/v1#MADSScheme</seealso>
    let MADSScheme = Prefixed_Name(madsrdf, "MADSScheme") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hasTranslationVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Variant whose label
    ///       represents a translation of that of the authoritative label.</para>
    /// labels<para>Has Translation
    ///       Variant</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hasTranslationVariant">http://www.loc.gov/mads/rdf/v1#hasTranslationVariant</seealso>
    let hasTranslationVariant =
        Prefixed_Name(madsrdf, "hasTranslationVariant") |> PrefixedName

    /// <summary>
    ///   <para>madsrdf:hiddenLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A label entered for
    ///       discovery purposes but not shown.</para>
    /// labels<para>Hidden Label</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#hiddenLabel">http://www.loc.gov/mads/rdf/v1#hiddenLabel</seealso>
    let hiddenLabel = Prefixed_Name(madsrdf, "hiddenLabel") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:historyNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A note pertaining to the
    ///       history of the resource.</para>
    /// labels<para>History Note</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#historyNote">http://www.loc.gov/mads/rdf/v1#historyNote</seealso>
    let historyNote = Prefixed_Name(madsrdf, "historyNote") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:honoraryTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Designation indicative of
    ///       royalty, nobility, or ecclesiastical rank or office, or a term of address for a person of
    ///       religious vocation.</para>
    /// labels<para>Honorary Title</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#honoraryTitle">http://www.loc.gov/mads/rdf/v1#honoraryTitle</seealso>
    let honoraryTitle = Prefixed_Name(madsrdf, "honoraryTitle") |> PrefixedName
    /// <summary>
    ///   <para>madsrdf:idScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The scheme associated with
    ///       the identifier. For example, "LCCN" would be used when the Identifier Value (madsrdf:idValue)
    ///       is a LC Control Number.</para>
    /// labels<para>Identifier
    ///       Scheme</para></remarks>
    /// <seealso href="http://www.loc.gov/mads/rdf/v1#idScheme">http://www.loc.gov/mads/rdf/v1#idScheme</seealso>
    let idScheme = Prefixed_Name(madsrdf, "idScheme") |> PrefixedName
