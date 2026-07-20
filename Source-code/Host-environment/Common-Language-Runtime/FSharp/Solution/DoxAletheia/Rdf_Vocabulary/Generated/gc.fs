namespace http.www.oegov.org.core.owl.gc.hash

open DoxAletheia

module gc =
    let _namespace_name = "http://www.oegov.org/core/owl/gc#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense"></see>
    /// </summary>
    let ``CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense`` =
        _prefix "CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense"

    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#attributedSource"></see>
    /// </summary>
    let attributedSource = _prefix "attributedSource"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#TopQuadrantAttribution"></see>
    /// </summary>
    let TopQuadrantAttribution = _prefix "TopQuadrantAttribution"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#revision"></see>
    /// </summary>
    let revision = _prefix "revision"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Anarcy"></see>
    /// </summary>
    let Anarcy = _prefix "Anarcy"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#PoliticalSystem"></see>
    /// </summary>
    let PoliticalSystem = _prefix "PoliticalSystem"
    /// <summary>
    /// The name, url and other details of an attribution.
    /// <see href="http://www.oegov.org/core/owl/gc#AttributedSource"></see></summary>
    let AttributedSource = _prefix "AttributedSource"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#pointOfContact"></see>
    /// </summary>
    let pointOfContact = _prefix "pointOfContact"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#CSV-Format"></see>
    /// </summary>
    let ``CSV-Format`` = _prefix "CSV-Format"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#DataFormat"></see>
    /// </summary>
    let DataFormat = _prefix "DataFormat"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Category"></see>
    /// </summary>
    let Category = _prefix "Category"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#subCategory"></see>
    /// </summary>
    let subCategory = _prefix "subCategory"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#CommunistState"></see>
    /// </summary>
    let CommunistState = _prefix "CommunistState"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#DateUnion"></see>
    /// </summary>
    let DateUnion = _prefix "DateUnion"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Democracy"></see>
    /// </summary>
    let Democracy = _prefix "Democracy"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Dictatorship"></see>
    /// </summary>
    let Dictatorship = _prefix "Dictatorship"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Entity"></see>
    /// </summary>
    let Entity = _prefix "Entity"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#hashtag"></see>
    /// </summary>
    let hashtag = _prefix "hashtag"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#url"></see>
    /// </summary>
    let url = _prefix "url"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#HTML-Format"></see>
    /// </summary>
    let ``HTML-Format`` = _prefix "HTML-Format"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#KML-Format"></see>
    /// </summary>
    let ``KML-Format`` = _prefix "KML-Format"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#KMZ-Format"></see>
    /// </summary>
    let ``KMZ-Format`` = _prefix "KMZ-Format"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Monarchy"></see>
    /// </summary>
    let Monarchy = _prefix "Monarchy"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#OWL-Format"></see>
    /// </summary>
    let ``OWL-Format`` = _prefix "OWL-Format"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Period"></see>
    /// </summary>
    let Period = _prefix "Period"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Q1"></see>
    /// </summary>
    let Q1 = _prefix "Q1"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Quarter"></see>
    /// </summary>
    let Quarter = _prefix "Quarter"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Q2"></see>
    /// </summary>
    let Q2 = _prefix "Q2"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Q3"></see>
    /// </summary>
    let Q3 = _prefix "Q3"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Q4"></see>
    /// </summary>
    let Q4 = _prefix "Q4"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#RDF-Format"></see>
    /// </summary>
    let ``RDF-Format`` = _prefix "RDF-Format"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#RSS-Format"></see>
    /// </summary>
    let ``RSS-Format`` = _prefix "RSS-Format"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Republic"></see>
    /// </summary>
    let Republic = _prefix "Republic"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#ShapefileFormat"></see>
    /// </summary>
    let ShapefileFormat = _prefix "ShapefileFormat"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#SocialistState"></see>
    /// </summary>
    let SocialistState = _prefix "SocialistState"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#TextFormat"></see>
    /// </summary>
    let TextFormat = _prefix "TextFormat"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Theocracy"></see>
    /// </summary>
    let Theocracy = _prefix "Theocracy"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#Tribal"></see>
    /// </summary>
    let Tribal = _prefix "Tribal"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#UnstructuredDataFormat"></see>
    /// </summary>
    let UnstructuredDataFormat = _prefix "UnstructuredDataFormat"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#XML-Format"></see>
    /// </summary>
    let ``XML-Format`` = _prefix "XML-Format"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#XSL-Format"></see>
    /// </summary>
    let ``XSL-Format`` = _prefix "XSL-Format"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#archiveURL"></see>
    /// </summary>
    let archiveURL = _prefix "archiveURL"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#awardDate"></see>
    /// </summary>
    let awardDate = _prefix "awardDate"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#date"></see>
    /// </summary>
    let date = _prefix "date"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#category"></see>
    /// </summary>
    let category = _prefix "category"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#cause"></see>
    /// </summary>
    let cause = _prefix "cause"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#cessationDate"></see>
    /// </summary>
    let cessationDate = _prefix "cessationDate"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#clause"></see>
    /// </summary>
    let clause = _prefix "clause"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#creationDate"></see>
    /// </summary>
    let creationDate = _prefix "creationDate"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#currency"></see>
    /// </summary>
    let currency = _prefix "currency"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#endDate"></see>
    /// </summary>
    let endDate = _prefix "endDate"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#format"></see>
    /// </summary>
    let format = _prefix "format"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#foundedOn"></see>
    /// </summary>
    let foundedOn = _prefix "foundedOn"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#identifier"></see>
    /// </summary>
    let identifier = _prefix "identifier"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#image"></see>
    /// </summary>
    let image = _prefix "image"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#licence"></see>
    /// </summary>
    let licence = _prefix "licence"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#member"></see>
    /// </summary>
    let member_ = _prefix "member"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#number"></see>
    /// </summary>
    let number = _prefix "number"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#person"></see>
    /// </summary>
    let person = _prefix "person"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#releasedDate"></see>
    /// </summary>
    let releasedDate = _prefix "releasedDate"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#result"></see>
    /// </summary>
    let result = _prefix "result"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#section"></see>
    /// </summary>
    let section = _prefix "section"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#shortTitle"></see>
    /// </summary>
    let shortTitle = _prefix "shortTitle"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#startDate"></see>
    /// </summary>
    let startDate = _prefix "startDate"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#status"></see>
    /// </summary>
    let status = _prefix "status"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#submissionDate"></see>
    /// </summary>
    let submissionDate = _prefix "submissionDate"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#summary"></see>
    /// </summary>
    let summary = _prefix "summary"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#text"></see>
    /// </summary>
    let text = _prefix "text"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#title"></see>
    /// </summary>
    let title = _prefix "title"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#updatedDate"></see>
    /// </summary>
    let updatedDate = _prefix "updatedDate"
    /// <summary>
    ///   <see href="http://www.oegov.org/core/owl/gc#year"></see>
    /// </summary>
    let year = _prefix "year"
