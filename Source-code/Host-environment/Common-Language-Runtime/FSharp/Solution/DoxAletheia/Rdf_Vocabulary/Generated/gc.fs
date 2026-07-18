namespace http.www.oegov.org.core.owl.gc.hash

open DoxAletheia.Rdf_Vocabulary

module gc =
    let _namespace_name = "http://www.oegov.org/core/owl/gc#"

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense"></see>
    /// </summary>
    let ``CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense`` =
        Namespaced_IRI.parse _namespace_name "CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#attributedSource"></see>
    /// </summary>
    let attributedSource =
        Namespaced_IRI.parse _namespace_name "attributedSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#TopQuadrantAttribution"></see>
    /// </summary>
    let TopQuadrantAttribution =
        Namespaced_IRI.parse _namespace_name "TopQuadrantAttribution" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#revision"></see>
    /// </summary>
    let revision = Namespaced_IRI.parse _namespace_name "revision" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Anarcy"></see>
    /// </summary>
    let Anarcy = Namespaced_IRI.parse _namespace_name "Anarcy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#PoliticalSystem"></see>
    /// </summary>
    let PoliticalSystem =
        Namespaced_IRI.parse _namespace_name "PoliticalSystem" |> NamespacedName

    /// <summary>
    /// The name, url and other details of an attribution.
    /// <see href="http://www.oegov.org/core/owl/gc#AttributedSource"></see></summary>
    let AttributedSource =
        Namespaced_IRI.parse _namespace_name "AttributedSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#pointOfContact"></see>
    /// </summary>
    let pointOfContact =
        Namespaced_IRI.parse _namespace_name "pointOfContact" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#CSV-Format"></see>
    /// </summary>
    let ``CSV-Format`` =
        Namespaced_IRI.parse _namespace_name "CSV-Format" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#DataFormat"></see>
    /// </summary>
    let DataFormat = Namespaced_IRI.parse _namespace_name "DataFormat" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Category"></see>
    /// </summary>
    let Category = Namespaced_IRI.parse _namespace_name "Category" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#subCategory"></see>
    /// </summary>
    let subCategory =
        Namespaced_IRI.parse _namespace_name "subCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#CommunistState"></see>
    /// </summary>
    let CommunistState =
        Namespaced_IRI.parse _namespace_name "CommunistState" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#DateUnion"></see>
    /// </summary>
    let DateUnion = Namespaced_IRI.parse _namespace_name "DateUnion" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Democracy"></see>
    /// </summary>
    let Democracy = Namespaced_IRI.parse _namespace_name "Democracy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Dictatorship"></see>
    /// </summary>
    let Dictatorship =
        Namespaced_IRI.parse _namespace_name "Dictatorship" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Entity"></see>
    /// </summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#hashtag"></see>
    /// </summary>
    let hashtag = Namespaced_IRI.parse _namespace_name "hashtag" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#url"></see>
    /// </summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#HTML-Format"></see>
    /// </summary>
    let ``HTML-Format`` =
        Namespaced_IRI.parse _namespace_name "HTML-Format" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#KML-Format"></see>
    /// </summary>
    let ``KML-Format`` =
        Namespaced_IRI.parse _namespace_name "KML-Format" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#KMZ-Format"></see>
    /// </summary>
    let ``KMZ-Format`` =
        Namespaced_IRI.parse _namespace_name "KMZ-Format" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Monarchy"></see>
    /// </summary>
    let Monarchy = Namespaced_IRI.parse _namespace_name "Monarchy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#OWL-Format"></see>
    /// </summary>
    let ``OWL-Format`` =
        Namespaced_IRI.parse _namespace_name "OWL-Format" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Period"></see>
    /// </summary>
    let Period = Namespaced_IRI.parse _namespace_name "Period" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Q1"></see>
    /// </summary>
    let Q1 = Namespaced_IRI.parse _namespace_name "Q1" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Quarter"></see>
    /// </summary>
    let Quarter = Namespaced_IRI.parse _namespace_name "Quarter" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Q2"></see>
    /// </summary>
    let Q2 = Namespaced_IRI.parse _namespace_name "Q2" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Q3"></see>
    /// </summary>
    let Q3 = Namespaced_IRI.parse _namespace_name "Q3" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Q4"></see>
    /// </summary>
    let Q4 = Namespaced_IRI.parse _namespace_name "Q4" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#RDF-Format"></see>
    /// </summary>
    let ``RDF-Format`` =
        Namespaced_IRI.parse _namespace_name "RDF-Format" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#RSS-Format"></see>
    /// </summary>
    let ``RSS-Format`` =
        Namespaced_IRI.parse _namespace_name "RSS-Format" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Republic"></see>
    /// </summary>
    let Republic = Namespaced_IRI.parse _namespace_name "Republic" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#ShapefileFormat"></see>
    /// </summary>
    let ShapefileFormat =
        Namespaced_IRI.parse _namespace_name "ShapefileFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#SocialistState"></see>
    /// </summary>
    let SocialistState =
        Namespaced_IRI.parse _namespace_name "SocialistState" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#TextFormat"></see>
    /// </summary>
    let TextFormat = Namespaced_IRI.parse _namespace_name "TextFormat" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Theocracy"></see>
    /// </summary>
    let Theocracy = Namespaced_IRI.parse _namespace_name "Theocracy" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Tribal"></see>
    /// </summary>
    let Tribal = Namespaced_IRI.parse _namespace_name "Tribal" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#UnstructuredDataFormat"></see>
    /// </summary>
    let UnstructuredDataFormat =
        Namespaced_IRI.parse _namespace_name "UnstructuredDataFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#XML-Format"></see>
    /// </summary>
    let ``XML-Format`` =
        Namespaced_IRI.parse _namespace_name "XML-Format" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#XSL-Format"></see>
    /// </summary>
    let ``XSL-Format`` =
        Namespaced_IRI.parse _namespace_name "XSL-Format" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#archiveURL"></see>
    /// </summary>
    let archiveURL = Namespaced_IRI.parse _namespace_name "archiveURL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#awardDate"></see>
    /// </summary>
    let awardDate = Namespaced_IRI.parse _namespace_name "awardDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#date"></see>
    /// </summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#category"></see>
    /// </summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#cause"></see>
    /// </summary>
    let cause = Namespaced_IRI.parse _namespace_name "cause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#cessationDate"></see>
    /// </summary>
    let cessationDate =
        Namespaced_IRI.parse _namespace_name "cessationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#clause"></see>
    /// </summary>
    let clause = Namespaced_IRI.parse _namespace_name "clause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#creationDate"></see>
    /// </summary>
    let creationDate =
        Namespaced_IRI.parse _namespace_name "creationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#currency"></see>
    /// </summary>
    let currency = Namespaced_IRI.parse _namespace_name "currency" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#endDate"></see>
    /// </summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#format"></see>
    /// </summary>
    let format = Namespaced_IRI.parse _namespace_name "format" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#foundedOn"></see>
    /// </summary>
    let foundedOn = Namespaced_IRI.parse _namespace_name "foundedOn" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#identifier"></see>
    /// </summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#image"></see>
    /// </summary>
    let image = Namespaced_IRI.parse _namespace_name "image" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#licence"></see>
    /// </summary>
    let licence = Namespaced_IRI.parse _namespace_name "licence" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#member"></see>
    /// </summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#number"></see>
    /// </summary>
    let number = Namespaced_IRI.parse _namespace_name "number" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#person"></see>
    /// </summary>
    let person = Namespaced_IRI.parse _namespace_name "person" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#releasedDate"></see>
    /// </summary>
    let releasedDate =
        Namespaced_IRI.parse _namespace_name "releasedDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#result"></see>
    /// </summary>
    let result = Namespaced_IRI.parse _namespace_name "result" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#section"></see>
    /// </summary>
    let section = Namespaced_IRI.parse _namespace_name "section" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#shortTitle"></see>
    /// </summary>
    let shortTitle = Namespaced_IRI.parse _namespace_name "shortTitle" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#startDate"></see>
    /// </summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#status"></see>
    /// </summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#submissionDate"></see>
    /// </summary>
    let submissionDate =
        Namespaced_IRI.parse _namespace_name "submissionDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#summary"></see>
    /// </summary>
    let summary = Namespaced_IRI.parse _namespace_name "summary" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#text"></see>
    /// </summary>
    let text = Namespaced_IRI.parse _namespace_name "text" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#updatedDate"></see>
    /// </summary>
    let updatedDate =
        Namespaced_IRI.parse _namespace_name "updatedDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#year"></see>
    /// </summary>
    let year = Namespaced_IRI.parse _namespace_name "year" |> NamespacedName
