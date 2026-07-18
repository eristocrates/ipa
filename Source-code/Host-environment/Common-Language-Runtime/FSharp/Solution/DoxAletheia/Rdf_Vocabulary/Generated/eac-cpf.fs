namespace http.archivi.ibc.regione.emilia_romagna.it.ontology.eac_cpf.slash

open DoxAletheia.Rdf_Vocabulary

module eac_cpf =
    let _namespace_name =
        "http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/"

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/biogHist"></see>
    /// </summary>
    let biogHist = Namespaced_IRI.parse _namespace_name "biogHist" |> NamespacedName
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/entity"></see>
    /// </summary>
    let entity = Namespaced_IRI.parse _namespace_name "entity" |> NamespacedName
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/control"></see>
    /// </summary>
    let control = Namespaced_IRI.parse _namespace_name "control" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/controlArea"></see>
    /// </summary>
    let controlArea =
        Namespaced_IRI.parse _namespace_name "controlArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/maintenanceHistory"></see>
    /// </summary>
    let maintenanceHistory =
        Namespaced_IRI.parse _namespace_name "maintenanceHistory" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/publicationStatus"></see>
    /// </summary>
    let publicationStatus =
        Namespaced_IRI.parse _namespace_name "publicationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/source"></see>
    /// </summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/conventionDeclaration"></see>
    /// </summary>
    let conventionDeclaration =
        Namespaced_IRI.parse _namespace_name "conventionDeclaration" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/recordID"></see>
    /// </summary>
    let recordID = Namespaced_IRI.parse _namespace_name "recordID" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/localTypeDeclaration"></see>
    /// </summary>
    let localTypeDeclaration =
        Namespaced_IRI.parse _namespace_name "localTypeDeclaration" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/maintenanceStatus"></see>
    /// </summary>
    let maintenanceStatus =
        Namespaced_IRI.parse _namespace_name "maintenanceStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/maintenanceAgency"></see>
    /// </summary>
    let maintenanceAgency =
        Namespaced_IRI.parse _namespace_name "maintenanceAgency" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/corporateBody"></see>
    /// </summary>
    let corporateBody =
        Namespaced_IRI.parse _namespace_name "corporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/cpfRelation"></see>
    /// </summary>
    let cpfRelation =
        Namespaced_IRI.parse _namespace_name "cpfRelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/relation"></see>
    /// </summary>
    let relation = Namespaced_IRI.parse _namespace_name "relation" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/cpfRelationType"></see>
    /// </summary>
    let cpfRelationType =
        Namespaced_IRI.parse _namespace_name "cpfRelationType" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/description"></see>
    /// </summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/descriptionArea"></see>
    /// </summary>
    let descriptionArea =
        Namespaced_IRI.parse _namespace_name "descriptionArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/existDates"></see>
    /// </summary>
    let existDates = Namespaced_IRI.parse _namespace_name "existDates" |> NamespacedName
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/nameEntry"></see>
    /// </summary>
    let nameEntry = Namespaced_IRI.parse _namespace_name "nameEntry" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/resourceRelation"></see>
    /// </summary>
    let resourceRelation =
        Namespaced_IRI.parse _namespace_name "resourceRelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/eac-cpf.rdf"></see>
    /// </summary>
    let ``eac-cpf.rdf`` =
        Namespaced_IRI.parse _namespace_name "eac-cpf.rdf" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/family"></see>
    /// </summary>
    let family = Namespaced_IRI.parse _namespace_name "family" |> NamespacedName
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/function"></see>
    /// </summary>
    let function_ = Namespaced_IRI.parse _namespace_name "function" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/generalContext"></see>
    /// </summary>
    let generalContext =
        Namespaced_IRI.parse _namespace_name "generalContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/hasMultipleIdentities"></see>
    /// </summary>
    let hasMultipleIdentities =
        Namespaced_IRI.parse _namespace_name "hasMultipleIdentities" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/hasPlace"></see>
    /// </summary>
    let hasPlace = Namespaced_IRI.parse _namespace_name "hasPlace" |> NamespacedName
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/place"></see>
    /// </summary>
    let place = Namespaced_IRI.parse _namespace_name "place" |> NamespacedName
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/language"></see>
    /// </summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/languageDeclaration"></see>
    /// </summary>
    let languageDeclaration =
        Namespaced_IRI.parse _namespace_name "languageDeclaration" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/languageUsed"></see>
    /// </summary>
    let languageUsed =
        Namespaced_IRI.parse _namespace_name "languageUsed" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/legalStatus"></see>
    /// </summary>
    let legalStatus =
        Namespaced_IRI.parse _namespace_name "legalStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/localControl"></see>
    /// </summary>
    let localControl =
        Namespaced_IRI.parse _namespace_name "localControl" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/mandate"></see>
    /// </summary>
    let mandate = Namespaced_IRI.parse _namespace_name "mandate" |> NamespacedName
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/nameArea"></see>
    /// </summary>
    let nameArea = Namespaced_IRI.parse _namespace_name "nameArea" |> NamespacedName
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/dainserire"></see>
    /// </summary>
    let dainserire = Namespaced_IRI.parse _namespace_name "dainserire" |> NamespacedName
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/occupation"></see>
    /// </summary>
    let occupation = Namespaced_IRI.parse _namespace_name "occupation" |> NamespacedName
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/person"></see>
    /// </summary>
    let person = Namespaced_IRI.parse _namespace_name "person" |> NamespacedName
    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/placeRole"></see>
    /// </summary>
    let placeRole = Namespaced_IRI.parse _namespace_name "placeRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/resourceRelationType"></see>
    /// </summary>
    let resourceRelationType =
        Namespaced_IRI.parse _namespace_name "resourceRelationType" |> NamespacedName

    /// <summary>
    ///   <see href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/structureOrGenealogy"></see>
    /// </summary>
    let structureOrGenealogy =
        Namespaced_IRI.parse _namespace_name "structureOrGenealogy" |> NamespacedName
