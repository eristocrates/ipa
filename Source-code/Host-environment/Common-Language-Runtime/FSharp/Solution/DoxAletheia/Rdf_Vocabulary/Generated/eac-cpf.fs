namespace http.archivi.ibc.regione.emilia_romagna.it.ontology.eac_cpf.slash

open DoxAletheia

module eac_cpf =
    let _namespace_name =
        "http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/biogHist"></see>
    /// </summary>
    let biogHist = _prefix "biogHist"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/entity"></see>
    /// </summary>
    let entity = _prefix "entity"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/control"></see>
    /// </summary>
    let control = _prefix "control"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/controlArea"></see>
    /// </summary>
    let controlArea = _prefix "controlArea"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/maintenanceHistory"></see>
    /// </summary>
    let maintenanceHistory = _prefix "maintenanceHistory"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/publicationStatus"></see>
    /// </summary>
    let publicationStatus = _prefix "publicationStatus"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/source"></see>
    /// </summary>
    let source = _prefix "source"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/conventionDeclaration"></see>
    /// </summary>
    let conventionDeclaration = _prefix "conventionDeclaration"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/recordID"></see>
    /// </summary>
    let recordID = _prefix "recordID"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/localTypeDeclaration"></see>
    /// </summary>
    let localTypeDeclaration = _prefix "localTypeDeclaration"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/maintenanceStatus"></see>
    /// </summary>
    let maintenanceStatus = _prefix "maintenanceStatus"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/maintenanceAgency"></see>
    /// </summary>
    let maintenanceAgency = _prefix "maintenanceAgency"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/corporateBody"></see>
    /// </summary>
    let corporateBody = _prefix "corporateBody"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/cpfRelation"></see>
    /// </summary>
    let cpfRelation = _prefix "cpfRelation"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/relation"></see>
    /// </summary>
    let relation = _prefix "relation"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/cpfRelationType"></see>
    /// </summary>
    let cpfRelationType = _prefix "cpfRelationType"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/description"></see>
    /// </summary>
    let description = _prefix "description"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/descriptionArea"></see>
    /// </summary>
    let descriptionArea = _prefix "descriptionArea"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/existDates"></see>
    /// </summary>
    let existDates = _prefix "existDates"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/nameEntry"></see>
    /// </summary>
    let nameEntry = _prefix "nameEntry"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/resourceRelation"></see>
    /// </summary>
    let resourceRelation = _prefix "resourceRelation"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/eac-cpf.rdf"></see>
    /// </summary>
    let ``eac-cpf.rdf`` = _prefix "eac-cpf.rdf"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/family"></see>
    /// </summary>
    let family = _prefix "family"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/function"></see>
    /// </summary>
    let function_ = _prefix "function"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/generalContext"></see>
    /// </summary>
    let generalContext = _prefix "generalContext"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/hasMultipleIdentities"></see>
    /// </summary>
    let hasMultipleIdentities = _prefix "hasMultipleIdentities"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/hasPlace"></see>
    /// </summary>
    let hasPlace = _prefix "hasPlace"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/place"></see>
    /// </summary>
    let place = _prefix "place"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/language"></see>
    /// </summary>
    let language = _prefix "language"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/languageDeclaration"></see>
    /// </summary>
    let languageDeclaration = _prefix "languageDeclaration"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/languageUsed"></see>
    /// </summary>
    let languageUsed = _prefix "languageUsed"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/legalStatus"></see>
    /// </summary>
    let legalStatus = _prefix "legalStatus"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/localControl"></see>
    /// </summary>
    let localControl = _prefix "localControl"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/mandate"></see>
    /// </summary>
    let mandate = _prefix "mandate"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/nameArea"></see>
    /// </summary>
    let nameArea = _prefix "nameArea"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/dainserire"></see>
    /// </summary>
    let dainserire = _prefix "dainserire"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/occupation"></see>
    /// </summary>
    let occupation = _prefix "occupation"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/person"></see>
    /// </summary>
    let person = _prefix "person"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/placeRole"></see>
    /// </summary>
    let placeRole = _prefix "placeRole"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/resourceRelationType"></see>
    /// </summary>
    let resourceRelationType = _prefix "resourceRelationType"
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/structureOrGenealogy"></see>
    /// </summary>
    let structureOrGenealogy = _prefix "structureOrGenealogy"
