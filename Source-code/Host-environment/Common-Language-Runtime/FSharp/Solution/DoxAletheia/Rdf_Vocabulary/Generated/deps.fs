namespace http.ontologi.es.doap_deps.hash

open DoxAletheia

module deps =
    let _namespace_name = "http://ontologi.es/doap-deps#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#BuildPhase"></see>
    /// </summary>
    let BuildPhase = _prefix "BuildPhase"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#Phase"></see>
    /// </summary>
    let Phase = _prefix "Phase"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#ConfigurePhase"></see>
    /// </summary>
    let ConfigurePhase = _prefix "ConfigurePhase"
    /// <summary>
    /// Examples: `Moose::Role` or `Moose::Role 2.0600`
    /// A module name, optionally followed by a space character and a version.
    /// <see href="http://ontologi.es/doap-deps#CpanId"></see></summary>
    let CpanId = _prefix "CpanId"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#IdentifierScheme"></see>
    /// </summary>
    let IdentifierScheme = _prefix "IdentifierScheme"
    /// <summary>
    /// Examples: `libmoose-perl` or `libmoose-perl (&gt;= 2.0600-1)`
    /// Note that architecture-specific modifiers (in square brackets) are not supported yet.
    /// <see href="http://ontologi.es/doap-deps#DebianId"></see></summary>
    let DebianId = _prefix "DebianId"
    /// <summary>
    /// A condition to be met
    /// <see href="http://ontologi.es/doap-deps#Dependency"></see></summary>
    let Dependency = _prefix "Dependency"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#DevelopmentPhase"></see>
    /// </summary>
    let DevelopmentPhase = _prefix "DevelopmentPhase"
    /// <summary>
    /// Examples: `log4r` or `log4r &gt;= 1.0.5` or `log4r &gt;= 1.0.5, &lt; 2.0.0`
    /// A module name, optionally followed by one or more operator, version number pairs.
    /// <see href="http://ontologi.es/doap-deps#GemId"></see></summary>
    let GemId = _prefix "GemId"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#HistoricDependency"></see>
    /// </summary>
    let HistoricDependency = _prefix "HistoricDependency"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#Level"></see>
    /// </summary>
    let Level = _prefix "Level"
    /// <summary>
    /// Example 'org.clojure/clojure 1.5.1-SNAPSHOT'
    /// A fully qualified Maven artefact name: 'groupID/artefactID version[-classifier]'
    /// <see href="http://ontologi.es/doap-deps#MvnId"></see></summary>
    let MvnId = _prefix "MvnId"
    /// <summary>
    /// Example: `html5lib==0.95`
    /// A single line from a requirements.txt file, minus the line break.
    /// <see href="http://ontologi.es/doap-deps#PipId"></see></summary>
    let PipId = _prefix "PipId"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#Recommended"></see>
    /// </summary>
    let Recommended = _prefix "Recommended"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#Required"></see>
    /// </summary>
    let Required = _prefix "Required"
    /// <summary>
    /// Examples: `perl-Moose` or `perl-Moose &gt;= 2.0600-1`
    /// <see href="http://ontologi.es/doap-deps#RpmId"></see></summary>
    let RpmId = _prefix "RpmId"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#RuntimePhase"></see>
    /// </summary>
    let RuntimePhase = _prefix "RuntimePhase"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#Suggested"></see>
    /// </summary>
    let Suggested = _prefix "Suggested"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#TestPhase"></see>
    /// </summary>
    let TestPhase = _prefix "TestPhase"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#build-recommendation"></see>
    /// </summary>
    let ``build-recommendation`` = _prefix "build-recommendation"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#level"></see>
    /// </summary>
    let level = _prefix "level"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#phase"></see>
    /// </summary>
    let phase = _prefix "phase"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#build-requirement"></see>
    /// </summary>
    let ``build-requirement`` = _prefix "build-requirement"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#build-suggestion"></see>
    /// </summary>
    let ``build-suggestion`` = _prefix "build-suggestion"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#configure-recommendation"></see>
    /// </summary>
    let ``configure-recommendation`` = _prefix "configure-recommendation"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#configure-requirement"></see>
    /// </summary>
    let ``configure-requirement`` = _prefix "configure-requirement"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#configure-suggestion"></see>
    /// </summary>
    let ``configure-suggestion`` = _prefix "configure-suggestion"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#develop-recommendation"></see>
    /// </summary>
    let ``develop-recommendation`` = _prefix "develop-recommendation"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#develop-requirement"></see>
    /// </summary>
    let ``develop-requirement`` = _prefix "develop-requirement"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#develop-suggestion"></see>
    /// </summary>
    let ``develop-suggestion`` = _prefix "develop-suggestion"
    /// <summary>
    /// the range of this property is a little woolly; a doap:Project is certainly fine, as is a literal which acts as an identifier, provided it's qualified with a datatype indicating what scheme it's an identifier in
    /// <see href="http://ontologi.es/doap-deps#on"></see></summary>
    let on = _prefix "on"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#runtime-recommendation"></see>
    /// </summary>
    let ``runtime-recommendation`` = _prefix "runtime-recommendation"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#runtime-requirement"></see>
    /// </summary>
    let ``runtime-requirement`` = _prefix "runtime-requirement"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#runtime-suggestion"></see>
    /// </summary>
    let ``runtime-suggestion`` = _prefix "runtime-suggestion"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#since"></see>
    /// </summary>
    let since = _prefix "since"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#test-recommendation"></see>
    /// </summary>
    let ``test-recommendation`` = _prefix "test-recommendation"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#test-requirement"></see>
    /// </summary>
    let ``test-requirement`` = _prefix "test-requirement"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#test-suggestion"></see>
    /// </summary>
    let ``test-suggestion`` = _prefix "test-suggestion"
    /// <summary>
    ///   <see href="http://ontologi.es/doap-deps#until"></see>
    /// </summary>
    let until = _prefix "until"
