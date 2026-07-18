namespace http.ontologi.es.doap_deps.hash

open DoxAletheia.Rdf_Vocabulary

module deps =
    let _namespace_name = "http://ontologi.es/doap-deps#"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#BuildPhase"></see>
    /// </summary>
    let BuildPhase = Namespaced_IRI.parse _namespace_name "BuildPhase" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#Phase"></see>
    /// </summary>
    let Phase = Namespaced_IRI.parse _namespace_name "Phase" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#ConfigurePhase"></see>
    /// </summary>
    let ConfigurePhase =
        Namespaced_IRI.parse _namespace_name "ConfigurePhase" |> NamespacedName

    /// <summary>
    /// Examples: `Moose::Role` or `Moose::Role 2.0600`
    /// A module name, optionally followed by a space character and a version.
    /// <see href="http://ontologi.es/doap-deps#CpanId"></see></summary>
    let CpanId = Namespaced_IRI.parse _namespace_name "CpanId" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#IdentifierScheme"></see>
    /// </summary>
    let IdentifierScheme =
        Namespaced_IRI.parse _namespace_name "IdentifierScheme" |> NamespacedName

    /// <summary>
    /// Examples: `libmoose-perl` or `libmoose-perl (&gt;= 2.0600-1)`
    /// Note that architecture-specific modifiers (in square brackets) are not supported yet.
    /// <see href="http://ontologi.es/doap-deps#DebianId"></see></summary>
    let DebianId = Namespaced_IRI.parse _namespace_name "DebianId" |> NamespacedName
    /// <summary>
    /// A condition to be met
    /// <see href="http://ontologi.es/doap-deps#Dependency"></see></summary>
    let Dependency = Namespaced_IRI.parse _namespace_name "Dependency" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#DevelopmentPhase"></see>
    /// </summary>
    let DevelopmentPhase =
        Namespaced_IRI.parse _namespace_name "DevelopmentPhase" |> NamespacedName

    /// <summary>
    /// Examples: `log4r` or `log4r &gt;= 1.0.5` or `log4r &gt;= 1.0.5, &lt; 2.0.0`
    /// A module name, optionally followed by one or more operator, version number pairs.
    /// <see href="http://ontologi.es/doap-deps#GemId"></see></summary>
    let GemId = Namespaced_IRI.parse _namespace_name "GemId" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#HistoricDependency"></see>
    /// </summary>
    let HistoricDependency =
        Namespaced_IRI.parse _namespace_name "HistoricDependency" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#Level"></see>
    /// </summary>
    let Level = Namespaced_IRI.parse _namespace_name "Level" |> NamespacedName
    /// <summary>
    /// Example 'org.clojure/clojure 1.5.1-SNAPSHOT'
    /// A fully qualified Maven artefact name: 'groupID/artefactID version[-classifier]'
    /// <see href="http://ontologi.es/doap-deps#MvnId"></see></summary>
    let MvnId = Namespaced_IRI.parse _namespace_name "MvnId" |> NamespacedName
    /// <summary>
    /// Example: `html5lib==0.95`
    /// A single line from a requirements.txt file, minus the line break.
    /// <see href="http://ontologi.es/doap-deps#PipId"></see></summary>
    let PipId = Namespaced_IRI.parse _namespace_name "PipId" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#Recommended"></see>
    /// </summary>
    let Recommended =
        Namespaced_IRI.parse _namespace_name "Recommended" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#Required"></see>
    /// </summary>
    let Required = Namespaced_IRI.parse _namespace_name "Required" |> NamespacedName
    /// <summary>
    /// Examples: `perl-Moose` or `perl-Moose &gt;= 2.0600-1`
    /// <see href="http://ontologi.es/doap-deps#RpmId"></see></summary>
    let RpmId = Namespaced_IRI.parse _namespace_name "RpmId" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#RuntimePhase"></see>
    /// </summary>
    let RuntimePhase =
        Namespaced_IRI.parse _namespace_name "RuntimePhase" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#Suggested"></see>
    /// </summary>
    let Suggested = Namespaced_IRI.parse _namespace_name "Suggested" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#TestPhase"></see>
    /// </summary>
    let TestPhase = Namespaced_IRI.parse _namespace_name "TestPhase" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#build-recommendation"></see>
    /// </summary>
    let ``build-recommendation`` =
        Namespaced_IRI.parse _namespace_name "build-recommendation" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#level"></see>
    /// </summary>
    let level = Namespaced_IRI.parse _namespace_name "level" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#phase"></see>
    /// </summary>
    let phase = Namespaced_IRI.parse _namespace_name "phase" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#build-requirement"></see>
    /// </summary>
    let ``build-requirement`` =
        Namespaced_IRI.parse _namespace_name "build-requirement" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#build-suggestion"></see>
    /// </summary>
    let ``build-suggestion`` =
        Namespaced_IRI.parse _namespace_name "build-suggestion" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#configure-recommendation"></see>
    /// </summary>
    let ``configure-recommendation`` =
        Namespaced_IRI.parse _namespace_name "configure-recommendation" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#configure-requirement"></see>
    /// </summary>
    let ``configure-requirement`` =
        Namespaced_IRI.parse _namespace_name "configure-requirement" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#configure-suggestion"></see>
    /// </summary>
    let ``configure-suggestion`` =
        Namespaced_IRI.parse _namespace_name "configure-suggestion" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#develop-recommendation"></see>
    /// </summary>
    let ``develop-recommendation`` =
        Namespaced_IRI.parse _namespace_name "develop-recommendation" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#develop-requirement"></see>
    /// </summary>
    let ``develop-requirement`` =
        Namespaced_IRI.parse _namespace_name "develop-requirement" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#develop-suggestion"></see>
    /// </summary>
    let ``develop-suggestion`` =
        Namespaced_IRI.parse _namespace_name "develop-suggestion" |> NamespacedName

    /// <summary>
    /// the range of this property is a little woolly; a doap:Project is certainly fine, as is a literal which acts as an identifier, provided it's qualified with a datatype indicating what scheme it's an identifier in
    /// <see href="http://ontologi.es/doap-deps#on"></see></summary>
    let on = Namespaced_IRI.parse _namespace_name "on" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#runtime-recommendation"></see>
    /// </summary>
    let ``runtime-recommendation`` =
        Namespaced_IRI.parse _namespace_name "runtime-recommendation" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#runtime-requirement"></see>
    /// </summary>
    let ``runtime-requirement`` =
        Namespaced_IRI.parse _namespace_name "runtime-requirement" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#runtime-suggestion"></see>
    /// </summary>
    let ``runtime-suggestion`` =
        Namespaced_IRI.parse _namespace_name "runtime-suggestion" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#since"></see>
    /// </summary>
    let since = Namespaced_IRI.parse _namespace_name "since" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#test-recommendation"></see>
    /// </summary>
    let ``test-recommendation`` =
        Namespaced_IRI.parse _namespace_name "test-recommendation" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#test-requirement"></see>
    /// </summary>
    let ``test-requirement`` =
        Namespaced_IRI.parse _namespace_name "test-requirement" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#test-suggestion"></see>
    /// </summary>
    let ``test-suggestion`` =
        Namespaced_IRI.parse _namespace_name "test-suggestion" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#until"></see>
    /// </summary>
    let until = Namespaced_IRI.parse _namespace_name "until" |> NamespacedName
