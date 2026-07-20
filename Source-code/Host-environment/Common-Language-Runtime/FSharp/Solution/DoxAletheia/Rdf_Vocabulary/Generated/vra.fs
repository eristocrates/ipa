namespace http.simile.mit.edu._2003._10.ontologies.vraCore3.hash

open DoxAletheia

module vra =
    let _namespace_name = "http://simile.mit.edu/2003/10/ontologies/vraCore3#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Corporation"></see>
    /// </summary>
    let Corporation = _prefix "Corporation"
    /// <summary>
    /// Entities are creators e.g. people or organisations
    /// <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Entity"></see></summary>
    let Entity = _prefix "Entity"
    /// <summary>
    /// An image record is used for the visual surrogates of objects
    /// <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    /// A record is the superclass for Works and Images
    /// <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Record"></see></summary>
    let Record = _prefix "Record"
    /// <summary>
    /// A work
    /// <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#LargerEntity"></see></summary>
    let LargerEntity = _prefix "LargerEntity"
    /// <summary>
    /// A Series
    /// <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Series"></see></summary>
    let Series = _prefix "Series"
    /// <summary>
    /// A work record is used for physical or created objects
    /// <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Work"></see></summary>
    let Work = _prefix "Work"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#alteration"></see>
    /// </summary>
    let alteration = _prefix "alteration"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#date"></see>
    /// </summary>
    let date = _prefix "date"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#attribution"></see>
    /// </summary>
    let attribution = _prefix "attribution"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#beginning"></see>
    /// </summary>
    let beginning = _prefix "beginning"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#completion"></see>
    /// </summary>
    let completion = _prefix "completion"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#creation"></see>
    /// </summary>
    let creation = _prefix "creation"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#creator"></see>
    /// </summary>
    let creator = _prefix "creator"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#culture"></see>
    /// </summary>
    let culture = _prefix "culture"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#description"></see>
    /// </summary>
    let description = _prefix "description"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#design"></see>
    /// </summary>
    let design = _prefix "design"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#dynasty"></see>
    /// </summary>
    let dynasty = _prefix "dynasty"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#group"></see>
    /// </summary>
    let group = _prefix "group"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#id"></see>
    /// </summary>
    let id = _prefix "id"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#idCurrentAccession"></see>
    /// </summary>
    let idCurrentAccession = _prefix "idCurrentAccession"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#idCurrentRepository"></see>
    /// </summary>
    let idCurrentRepository = _prefix "idCurrentRepository"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#idFormerAccession"></see>
    /// </summary>
    let idFormerAccession = _prefix "idFormerAccession"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#idFormerRepository"></see>
    /// </summary>
    let idFormerRepository = _prefix "idFormerRepository"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#location"></see>
    /// </summary>
    let location = _prefix "location"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationCreationSite"></see>
    /// </summary>
    let locationCreationSite = _prefix "locationCreationSite"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationCurrentRepository"></see>
    /// </summary>
    let locationCurrentRepository = _prefix "locationCurrentRepository"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationCurrentSite"></see>
    /// </summary>
    let locationCurrentSite = _prefix "locationCurrentSite"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationDiscoverySite"></see>
    /// </summary>
    let locationDiscoverySite = _prefix "locationDiscoverySite"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationFormerRepository"></see>
    /// </summary>
    let locationFormerRepository = _prefix "locationFormerRepository"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationFormerSite"></see>
    /// </summary>
    let locationFormerSite = _prefix "locationFormerSite"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#material"></see>
    /// </summary>
    let material = _prefix "material"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#measurements"></see>
    /// </summary>
    let measurements = _prefix "measurements"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#measurementsDimensions"></see>
    /// </summary>
    let measurementsDimensions = _prefix "measurementsDimensions"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#measurementsFormat"></see>
    /// </summary>
    let measurementsFormat = _prefix "measurementsFormat"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#measurementsResolution"></see>
    /// </summary>
    let measurementsResolution = _prefix "measurementsResolution"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#medium"></see>
    /// </summary>
    let medium = _prefix "medium"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#movement"></see>
    /// </summary>
    let movement = _prefix "movement"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#period"></see>
    /// </summary>
    let period = _prefix "period"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#stylePeriod"></see>
    /// </summary>
    let stylePeriod = _prefix "stylePeriod"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#relation"></see>
    /// </summary>
    let relation = _prefix "relation"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Relation"></see>
    /// </summary>
    let Relation = _prefix "Relation"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#restoration"></see>
    /// </summary>
    let restoration = _prefix "restoration"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#rights"></see>
    /// </summary>
    let rights = _prefix "rights"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#role"></see>
    /// </summary>
    let role = _prefix "role"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#school"></see>
    /// </summary>
    let school = _prefix "school"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#source"></see>
    /// </summary>
    let source = _prefix "source"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#style"></see>
    /// </summary>
    let style = _prefix "style"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#subject"></see>
    /// </summary>
    let subject = _prefix "subject"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#support"></see>
    /// </summary>
    let support = _prefix "support"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#technique"></see>
    /// </summary>
    let technique = _prefix "technique"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#title"></see>
    /// </summary>
    let title = _prefix "title"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#titleTranslation"></see>
    /// </summary>
    let titleTranslation = _prefix "titleTranslation"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#titleVariant"></see>
    /// </summary>
    let titleVariant = _prefix "titleVariant"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#type"></see>
    /// </summary>
    let type_ = _prefix "type"
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#typeAAT"></see>
    /// </summary>
    let typeAAT = _prefix "typeAAT"
