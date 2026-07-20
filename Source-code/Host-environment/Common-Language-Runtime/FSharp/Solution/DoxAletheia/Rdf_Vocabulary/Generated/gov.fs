namespace http.gov.genealogy.net.ontology.owl.hash

open DoxAletheia

module gov =
    let _namespace_name = "http://gov.genealogy.net/ontology.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#GovItem"></see>
    /// </summary>
    let GovItem = _prefix "GovItem"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#GovObject"></see>
    /// </summary>
    let GovObject = _prefix "GovObject"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#Note"></see>
    /// </summary>
    let Note = _prefix "Note"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#Position"></see>
    /// </summary>
    let Position = _prefix "Position"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#Property"></see>
    /// </summary>
    let Property = _prefix "Property"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#PropertyForObject"></see>
    /// </summary>
    let PropertyForObject = _prefix "PropertyForObject"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#PropertyForSource"></see>
    /// </summary>
    let PropertyForSource = _prefix "PropertyForSource"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#PropertyName"></see>
    /// </summary>
    let PropertyName = _prefix "PropertyName"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#PropertyType"></see>
    /// </summary>
    let PropertyType = _prefix "PropertyType"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#Relation"></see>
    /// </summary>
    let Relation = _prefix "Relation"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#Source"></see>
    /// </summary>
    let Source = _prefix "Source"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#SourceReference"></see>
    /// </summary>
    let SourceReference = _prefix "SourceReference"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#Timespan"></see>
    /// </summary>
    let Timespan = _prefix "Timespan"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#Type"></see>
    /// </summary>
    let Type = _prefix "Type"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#begin"></see>
    /// </summary>
    let begin_ = _prefix "begin"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#containsInformationAbout"></see>
    /// </summary>
    let containsInformationAbout = _prefix "containsInformationAbout"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#relation"></see>
    /// </summary>
    let relation = _prefix "relation"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#end"></see>
    /// </summary>
    let end_ = _prefix "end"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasArea"></see>
    /// </summary>
    let hasArea = _prefix "hasArea"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#property"></see>
    /// </summary>
    let property = _prefix "property"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasAuthor"></see>
    /// </summary>
    let hasAuthor = _prefix "hasAuthor"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasDenomination"></see>
    /// </summary>
    let hasDenomination = _prefix "hasDenomination"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasHouseholds"></see>
    /// </summary>
    let hasHouseholds = _prefix "hasHouseholds"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasISBN"></see>
    /// </summary>
    let hasISBN = _prefix "hasISBN"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasMunicipalityId"></see>
    /// </summary>
    let hasMunicipalityId = _prefix "hasMunicipalityId"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasName"></see>
    /// </summary>
    let hasName = _prefix "hasName"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasPopulation"></see>
    /// </summary>
    let hasPopulation = _prefix "hasPopulation"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasPostalCode"></see>
    /// </summary>
    let hasPostalCode = _prefix "hasPostalCode"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasSubtitle"></see>
    /// </summary>
    let hasSubtitle = _prefix "hasSubtitle"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasTitle"></see>
    /// </summary>
    let hasTitle = _prefix "hasTitle"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasType"></see>
    /// </summary>
    let hasType = _prefix "hasType"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasURL"></see>
    /// </summary>
    let hasURL = _prefix "hasURL"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasWNumber"></see>
    /// </summary>
    let hasWNumber = _prefix "hasWNumber"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#height"></see>
    /// </summary>
    let height = _prefix "height"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#isLocatedIn"></see>
    /// </summary>
    let isLocatedIn = _prefix "isLocatedIn"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#isPartOf"></see>
    /// </summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#isReplacedBy"></see>
    /// </summary>
    let isReplacedBy = _prefix "isReplacedBy"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#language"></see>
    /// </summary>
    let language = _prefix "language"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#lastModification"></see>
    /// </summary>
    let lastModification = _prefix "lastModification"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#latitude"></see>
    /// </summary>
    let latitude = _prefix "latitude"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#longitude"></see>
    /// </summary>
    let longitude = _prefix "longitude"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#note"></see>
    /// </summary>
    let note = _prefix "note"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#noteText"></see>
    /// </summary>
    let noteText = _prefix "noteText"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#position"></see>
    /// </summary>
    let position = _prefix "position"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#ref"></see>
    /// </summary>
    let ref = _prefix "ref"
    /// <summary>
    /// examples: 1) a church as a visible building represents a parish 2) a town represents a country
    ///     as its capital
    /// <see href="http://gov.genealogy.net/ontology.owl#represents"></see></summary>
    let represents = _prefix "represents"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#source"></see>
    /// </summary>
    let source = _prefix "source"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#sourceNote"></see>
    /// </summary>
    let sourceNote = _prefix "sourceNote"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#sourceRef"></see>
    /// </summary>
    let sourceRef = _prefix "sourceRef"
    /// <summary>
    /// time period in which the statement was correct or there was relation
    ///     relationship.
    /// <see href="http://gov.genealogy.net/ontology.owl#time"></see></summary>
    let time = _prefix "time"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#type"></see>
    /// </summary>
    let type_ = _prefix "type"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#typeName"></see>
    /// </summary>
    let typeName = _prefix "typeName"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#value"></see>
    /// </summary>
    let value = _prefix "value"
