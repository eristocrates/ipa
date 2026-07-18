namespace http.gov.genealogy.net.ontology.owl.hash

open DoxAletheia.Rdf_Vocabulary

module gov =
    let _namespace_name = "http://gov.genealogy.net/ontology.owl#"
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#GovItem"></see>
    /// </summary>
    let GovItem = Namespaced_IRI.parse _namespace_name "GovItem" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#GovObject"></see>
    /// </summary>
    let GovObject = Namespaced_IRI.parse _namespace_name "GovObject" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#Note"></see>
    /// </summary>
    let Note = Namespaced_IRI.parse _namespace_name "Note" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#Position"></see>
    /// </summary>
    let Position = Namespaced_IRI.parse _namespace_name "Position" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#Property"></see>
    /// </summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#PropertyForObject"></see>
    /// </summary>
    let PropertyForObject =
        Namespaced_IRI.parse _namespace_name "PropertyForObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#PropertyForSource"></see>
    /// </summary>
    let PropertyForSource =
        Namespaced_IRI.parse _namespace_name "PropertyForSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#PropertyName"></see>
    /// </summary>
    let PropertyName =
        Namespaced_IRI.parse _namespace_name "PropertyName" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#PropertyType"></see>
    /// </summary>
    let PropertyType =
        Namespaced_IRI.parse _namespace_name "PropertyType" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#Relation"></see>
    /// </summary>
    let Relation = Namespaced_IRI.parse _namespace_name "Relation" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#Source"></see>
    /// </summary>
    let Source = Namespaced_IRI.parse _namespace_name "Source" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#SourceReference"></see>
    /// </summary>
    let SourceReference =
        Namespaced_IRI.parse _namespace_name "SourceReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#Timespan"></see>
    /// </summary>
    let Timespan = Namespaced_IRI.parse _namespace_name "Timespan" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#Type"></see>
    /// </summary>
    let Type = Namespaced_IRI.parse _namespace_name "Type" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#begin"></see>
    /// </summary>
    let begin_ = Namespaced_IRI.parse _namespace_name "begin" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#containsInformationAbout"></see>
    /// </summary>
    let containsInformationAbout =
        Namespaced_IRI.parse _namespace_name "containsInformationAbout" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#relation"></see>
    /// </summary>
    let relation = Namespaced_IRI.parse _namespace_name "relation" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#end"></see>
    /// </summary>
    let end_ = Namespaced_IRI.parse _namespace_name "end" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasArea"></see>
    /// </summary>
    let hasArea = Namespaced_IRI.parse _namespace_name "hasArea" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#property"></see>
    /// </summary>
    let property = Namespaced_IRI.parse _namespace_name "property" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasAuthor"></see>
    /// </summary>
    let hasAuthor = Namespaced_IRI.parse _namespace_name "hasAuthor" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasDenomination"></see>
    /// </summary>
    let hasDenomination =
        Namespaced_IRI.parse _namespace_name "hasDenomination" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasHouseholds"></see>
    /// </summary>
    let hasHouseholds =
        Namespaced_IRI.parse _namespace_name "hasHouseholds" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasISBN"></see>
    /// </summary>
    let hasISBN = Namespaced_IRI.parse _namespace_name "hasISBN" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasMunicipalityId"></see>
    /// </summary>
    let hasMunicipalityId =
        Namespaced_IRI.parse _namespace_name "hasMunicipalityId" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasName"></see>
    /// </summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasPopulation"></see>
    /// </summary>
    let hasPopulation =
        Namespaced_IRI.parse _namespace_name "hasPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasPostalCode"></see>
    /// </summary>
    let hasPostalCode =
        Namespaced_IRI.parse _namespace_name "hasPostalCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasSubtitle"></see>
    /// </summary>
    let hasSubtitle =
        Namespaced_IRI.parse _namespace_name "hasSubtitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasTitle"></see>
    /// </summary>
    let hasTitle = Namespaced_IRI.parse _namespace_name "hasTitle" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasType"></see>
    /// </summary>
    let hasType = Namespaced_IRI.parse _namespace_name "hasType" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasURL"></see>
    /// </summary>
    let hasURL = Namespaced_IRI.parse _namespace_name "hasURL" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#hasWNumber"></see>
    /// </summary>
    let hasWNumber = Namespaced_IRI.parse _namespace_name "hasWNumber" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#height"></see>
    /// </summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#isLocatedIn"></see>
    /// </summary>
    let isLocatedIn =
        Namespaced_IRI.parse _namespace_name "isLocatedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#isPartOf"></see>
    /// </summary>
    let isPartOf = Namespaced_IRI.parse _namespace_name "isPartOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#isReplacedBy"></see>
    /// </summary>
    let isReplacedBy =
        Namespaced_IRI.parse _namespace_name "isReplacedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#language"></see>
    /// </summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#lastModification"></see>
    /// </summary>
    let lastModification =
        Namespaced_IRI.parse _namespace_name "lastModification" |> NamespacedName

    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#latitude"></see>
    /// </summary>
    let latitude = Namespaced_IRI.parse _namespace_name "latitude" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#longitude"></see>
    /// </summary>
    let longitude = Namespaced_IRI.parse _namespace_name "longitude" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#note"></see>
    /// </summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#noteText"></see>
    /// </summary>
    let noteText = Namespaced_IRI.parse _namespace_name "noteText" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#position"></see>
    /// </summary>
    let position = Namespaced_IRI.parse _namespace_name "position" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#ref"></see>
    /// </summary>
    let ref = Namespaced_IRI.parse _namespace_name "ref" |> NamespacedName
    /// <summary>
    /// examples: 1) a church as a visible building represents a parish 2) a town represents a country
    ///     as its capital
    /// <see href="http://gov.genealogy.net/ontology.owl#represents"></see></summary>
    let represents = Namespaced_IRI.parse _namespace_name "represents" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#source"></see>
    /// </summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#sourceNote"></see>
    /// </summary>
    let sourceNote = Namespaced_IRI.parse _namespace_name "sourceNote" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#sourceRef"></see>
    /// </summary>
    let sourceRef = Namespaced_IRI.parse _namespace_name "sourceRef" |> NamespacedName
    /// <summary>
    /// time period in which the statement was correct or there was relation
    ///     relationship.
    /// <see href="http://gov.genealogy.net/ontology.owl#time"></see></summary>
    let time = Namespaced_IRI.parse _namespace_name "time" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#type"></see>
    /// </summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#typeName"></see>
    /// </summary>
    let typeName = Namespaced_IRI.parse _namespace_name "typeName" |> NamespacedName
    /// <summary>
    ///   <see href="http://gov.genealogy.net/ontology.owl#value"></see>
    /// </summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
