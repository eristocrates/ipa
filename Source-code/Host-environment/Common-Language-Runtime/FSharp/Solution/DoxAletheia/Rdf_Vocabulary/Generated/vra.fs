namespace http.simile.mit.edu._2003._10.ontologies.vraCore3.hash

open DoxAletheia.Rdf_Vocabulary

module vra =
    let _namespace_name = "http://simile.mit.edu/2003/10/ontologies/vraCore3#"

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Corporation"></see>
    /// </summary>
    let Corporation =
        Namespaced_IRI.parse _namespace_name "Corporation" |> NamespacedName

    /// <summary>
    /// Entities are creators e.g. people or organisations
    /// <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Entity"></see></summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName
    /// <summary>
    /// An image record is used for the visual surrogates of objects
    /// <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName
    /// <summary>
    /// A record is the superclass for Works and Images
    /// <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Record"></see></summary>
    let Record = Namespaced_IRI.parse _namespace_name "Record" |> NamespacedName

    /// <summary>
    /// A work
    /// <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#LargerEntity"></see></summary>
    let LargerEntity =
        Namespaced_IRI.parse _namespace_name "LargerEntity" |> NamespacedName

    /// <summary>
    /// A Series
    /// <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Series"></see></summary>
    let Series = Namespaced_IRI.parse _namespace_name "Series" |> NamespacedName
    /// <summary>
    /// A work record is used for physical or created objects
    /// <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Work"></see></summary>
    let Work = Namespaced_IRI.parse _namespace_name "Work" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#alteration"></see>
    /// </summary>
    let alteration = Namespaced_IRI.parse _namespace_name "alteration" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#date"></see>
    /// </summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#attribution"></see>
    /// </summary>
    let attribution =
        Namespaced_IRI.parse _namespace_name "attribution" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#beginning"></see>
    /// </summary>
    let beginning = Namespaced_IRI.parse _namespace_name "beginning" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#completion"></see>
    /// </summary>
    let completion = Namespaced_IRI.parse _namespace_name "completion" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#creation"></see>
    /// </summary>
    let creation = Namespaced_IRI.parse _namespace_name "creation" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#creator"></see>
    /// </summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#culture"></see>
    /// </summary>
    let culture = Namespaced_IRI.parse _namespace_name "culture" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#description"></see>
    /// </summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#design"></see>
    /// </summary>
    let design = Namespaced_IRI.parse _namespace_name "design" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#dynasty"></see>
    /// </summary>
    let dynasty = Namespaced_IRI.parse _namespace_name "dynasty" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#group"></see>
    /// </summary>
    let group = Namespaced_IRI.parse _namespace_name "group" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#id"></see>
    /// </summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#idCurrentAccession"></see>
    /// </summary>
    let idCurrentAccession =
        Namespaced_IRI.parse _namespace_name "idCurrentAccession" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#idCurrentRepository"></see>
    /// </summary>
    let idCurrentRepository =
        Namespaced_IRI.parse _namespace_name "idCurrentRepository" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#idFormerAccession"></see>
    /// </summary>
    let idFormerAccession =
        Namespaced_IRI.parse _namespace_name "idFormerAccession" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#idFormerRepository"></see>
    /// </summary>
    let idFormerRepository =
        Namespaced_IRI.parse _namespace_name "idFormerRepository" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#location"></see>
    /// </summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationCreationSite"></see>
    /// </summary>
    let locationCreationSite =
        Namespaced_IRI.parse _namespace_name "locationCreationSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationCurrentRepository"></see>
    /// </summary>
    let locationCurrentRepository =
        Namespaced_IRI.parse _namespace_name "locationCurrentRepository" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationCurrentSite"></see>
    /// </summary>
    let locationCurrentSite =
        Namespaced_IRI.parse _namespace_name "locationCurrentSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationDiscoverySite"></see>
    /// </summary>
    let locationDiscoverySite =
        Namespaced_IRI.parse _namespace_name "locationDiscoverySite" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationFormerRepository"></see>
    /// </summary>
    let locationFormerRepository =
        Namespaced_IRI.parse _namespace_name "locationFormerRepository" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#locationFormerSite"></see>
    /// </summary>
    let locationFormerSite =
        Namespaced_IRI.parse _namespace_name "locationFormerSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#material"></see>
    /// </summary>
    let material = Namespaced_IRI.parse _namespace_name "material" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#measurements"></see>
    /// </summary>
    let measurements =
        Namespaced_IRI.parse _namespace_name "measurements" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#measurementsDimensions"></see>
    /// </summary>
    let measurementsDimensions =
        Namespaced_IRI.parse _namespace_name "measurementsDimensions" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#measurementsFormat"></see>
    /// </summary>
    let measurementsFormat =
        Namespaced_IRI.parse _namespace_name "measurementsFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#measurementsResolution"></see>
    /// </summary>
    let measurementsResolution =
        Namespaced_IRI.parse _namespace_name "measurementsResolution" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#medium"></see>
    /// </summary>
    let medium = Namespaced_IRI.parse _namespace_name "medium" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#movement"></see>
    /// </summary>
    let movement = Namespaced_IRI.parse _namespace_name "movement" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#period"></see>
    /// </summary>
    let period = Namespaced_IRI.parse _namespace_name "period" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#stylePeriod"></see>
    /// </summary>
    let stylePeriod =
        Namespaced_IRI.parse _namespace_name "stylePeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#relation"></see>
    /// </summary>
    let relation = Namespaced_IRI.parse _namespace_name "relation" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#Relation"></see>
    /// </summary>
    let Relation = Namespaced_IRI.parse _namespace_name "Relation" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#restoration"></see>
    /// </summary>
    let restoration =
        Namespaced_IRI.parse _namespace_name "restoration" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#rights"></see>
    /// </summary>
    let rights = Namespaced_IRI.parse _namespace_name "rights" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#role"></see>
    /// </summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#school"></see>
    /// </summary>
    let school = Namespaced_IRI.parse _namespace_name "school" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#source"></see>
    /// </summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#style"></see>
    /// </summary>
    let style = Namespaced_IRI.parse _namespace_name "style" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#subject"></see>
    /// </summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#support"></see>
    /// </summary>
    let support = Namespaced_IRI.parse _namespace_name "support" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#technique"></see>
    /// </summary>
    let technique = Namespaced_IRI.parse _namespace_name "technique" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#titleTranslation"></see>
    /// </summary>
    let titleTranslation =
        Namespaced_IRI.parse _namespace_name "titleTranslation" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#titleVariant"></see>
    /// </summary>
    let titleVariant =
        Namespaced_IRI.parse _namespace_name "titleVariant" |> NamespacedName

    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#type"></see>
    /// </summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
    /// <summary>
    ///   <see href="http://simile.mit.edu/2003/10/ontologies/vraCore3#typeAAT"></see>
    /// </summary>
    let typeAAT = Namespaced_IRI.parse _namespace_name "typeAAT" |> NamespacedName
