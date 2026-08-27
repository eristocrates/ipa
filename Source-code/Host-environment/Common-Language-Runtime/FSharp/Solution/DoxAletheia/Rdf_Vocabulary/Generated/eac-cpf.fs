namespace http.archivi.ibc.regione.emilia_romagna.it.ontology.eac_cpf.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module eac_cpf =
    let _namespace_iri = Namespace_Iri eac_cpf |> NamespaceIRI
    /// <summary>
    ///   <para>eac-cpf:biogHist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Biographical or Historical Note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/biogHist">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/biogHist</seealso>
    let biogHist = Prefixed_Name(eac_cpf, "biogHist") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:control</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/control">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/control</seealso>
    let control = Prefixed_Name(eac_cpf, "control") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:controlArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"control area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/controlArea">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/controlArea</seealso>
    let controlArea = Prefixed_Name(eac_cpf, "controlArea") |> PrefixedName

    /// <summary>
    ///   <para>eac-cpf:conventionDeclaration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Convention Declaration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/conventionDeclaration">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/conventionDeclaration</seealso>
    let conventionDeclaration =
        Prefixed_Name(eac_cpf, "conventionDeclaration") |> PrefixedName

    /// <summary>
    ///   <para>eac-cpf:corporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"corporate body"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/corporateBody">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/corporateBody</seealso>
    let corporateBody = Prefixed_Name(eac_cpf, "corporateBody") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:cpfRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Corporate Body, Person, or Family Relation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/cpfRelation">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/cpfRelation</seealso>
    let cpfRelation = Prefixed_Name(eac_cpf, "cpfRelation") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:cpfRelationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Corporate Body, Person, or Family Relation Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/cpfRelationType">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/cpfRelationType</seealso>
    let cpfRelationType = Prefixed_Name(eac_cpf, "cpfRelationType") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:dainserire</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/dainserire">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/dainserire</seealso>
    let dainserire = Prefixed_Name(eac_cpf, "dainserire") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/description">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/description</seealso>
    let description = Prefixed_Name(eac_cpf, "description") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:descriptionArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"description area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/descriptionArea">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/descriptionArea</seealso>
    let descriptionArea = Prefixed_Name(eac_cpf, "descriptionArea") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:eac-cpf.rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/eac-cpf.rdf">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/eac-cpf.rdf</seealso>
    let ``eac_cpf.rdf`` = Prefixed_Name(eac_cpf, "eac-cpf.rdf") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/entity">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/entity</seealso>
    let entity = Prefixed_Name(eac_cpf, "entity") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:existDates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Dates of Existence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/existDates">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/existDates</seealso>
    let existDates = Prefixed_Name(eac_cpf, "existDates") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"family"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/family">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/family</seealso>
    let family = Prefixed_Name(eac_cpf, "family") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/function">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/function</seealso>
    let function_ = Prefixed_Name(eac_cpf, "function") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:generalContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"General Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/generalContext">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/generalContext</seealso>
    let generalContext = Prefixed_Name(eac_cpf, "generalContext") |> PrefixedName

    /// <summary>
    ///   <para>eac-cpf:hasMultipleIdentities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Multiple Identities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/hasMultipleIdentities">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/hasMultipleIdentities</seealso>
    let hasMultipleIdentities =
        Prefixed_Name(eac_cpf, "hasMultipleIdentities") |> PrefixedName

    /// <summary>
    ///   <para>eac-cpf:hasPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Place"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/hasPlace">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/hasPlace</seealso>
    let hasPlace = Prefixed_Name(eac_cpf, "hasPlace") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:allValuesFrom</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/language">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/language</seealso>
    let language = Prefixed_Name(eac_cpf, "language") |> PrefixedName

    /// <summary>
    ///   <para>eac-cpf:languageDeclaration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Language Declaration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/languageDeclaration">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/languageDeclaration</seealso>
    let languageDeclaration =
        Prefixed_Name(eac_cpf, "languageDeclaration") |> PrefixedName

    /// <summary>
    ///   <para>eac-cpf:languageUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Languages Used"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/languageUsed">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/languageUsed</seealso>
    let languageUsed = Prefixed_Name(eac_cpf, "languageUsed") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:legalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Legal Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/legalStatus">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/legalStatus</seealso>
    let legalStatus = Prefixed_Name(eac_cpf, "legalStatus") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:localControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Local Control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/localControl">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/localControl</seealso>
    let localControl = Prefixed_Name(eac_cpf, "localControl") |> PrefixedName

    /// <summary>
    ///   <para>eac-cpf:localTypeDeclaration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Local Type Declaration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/localTypeDeclaration">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/localTypeDeclaration</seealso>
    let localTypeDeclaration =
        Prefixed_Name(eac_cpf, "localTypeDeclaration") |> PrefixedName

    /// <summary>
    ///   <para>eac-cpf:maintenanceAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Maintenance Agency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/maintenanceAgency">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/maintenanceAgency</seealso>
    let maintenanceAgency = Prefixed_Name(eac_cpf, "maintenanceAgency") |> PrefixedName

    /// <summary>
    ///   <para>eac-cpf:maintenanceHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Maintenance History"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/maintenanceHistory">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/maintenanceHistory</seealso>
    let maintenanceHistory =
        Prefixed_Name(eac_cpf, "maintenanceHistory") |> PrefixedName

    /// <summary>
    ///   <para>eac-cpf:maintenanceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Maintenance Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/maintenanceStatus">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/maintenanceStatus</seealso>
    let maintenanceStatus = Prefixed_Name(eac_cpf, "maintenanceStatus") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:mandate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Mandate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/mandate">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/mandate</seealso>
    let mandate = Prefixed_Name(eac_cpf, "mandate") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:nameArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"name area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/nameArea">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/nameArea</seealso>
    let nameArea = Prefixed_Name(eac_cpf, "nameArea") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:nameEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Name Entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/nameEntry">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/nameEntry</seealso>
    let nameEntry = Prefixed_Name(eac_cpf, "nameEntry") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:occupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Occupation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/occupation">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/occupation</seealso>
    let occupation = Prefixed_Name(eac_cpf, "occupation") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/person">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/person</seealso>
    let person = Prefixed_Name(eac_cpf, "person") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"place"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/place">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/place</seealso>
    let place = Prefixed_Name(eac_cpf, "place") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:placeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Place Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/placeRole">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/placeRole</seealso>
    let placeRole = Prefixed_Name(eac_cpf, "placeRole") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:publicationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Publication Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/publicationStatus">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/publicationStatus</seealso>
    let publicationStatus = Prefixed_Name(eac_cpf, "publicationStatus") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:recordID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Record Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/recordID">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/recordID</seealso>
    let recordID = Prefixed_Name(eac_cpf, "recordID") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"relation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/relation">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/relation</seealso>
    let relation = Prefixed_Name(eac_cpf, "relation") |> PrefixedName
    /// <summary>
    ///   <para>eac-cpf:resourceRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Resource Relation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/resourceRelation">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/resourceRelation</seealso>
    let resourceRelation = Prefixed_Name(eac_cpf, "resourceRelation") |> PrefixedName

    /// <summary>
    ///   <para>eac-cpf:resourceRelationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Resource Relation Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/resourceRelationType">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/resourceRelationType</seealso>
    let resourceRelationType =
        Prefixed_Name(eac_cpf, "resourceRelationType") |> PrefixedName

    /// <summary>
    ///   <para>eac-cpf:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/source">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/source</seealso>
    let source = Prefixed_Name(eac_cpf, "source") |> PrefixedName

    /// <summary>
    ///   <para>eac-cpf:structureOrGenealogy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Structure or Genealogy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/structureOrGenealogy">http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/structureOrGenealogy</seealso>
    let structureOrGenealogy =
        Prefixed_Name(eac_cpf, "structureOrGenealogy") |> PrefixedName
