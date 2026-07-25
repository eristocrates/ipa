namespace http.ontologi.es.doap_deps.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module deps =
    let _namespace_iri = Namespace_Iri deps |> NamespaceIRI
    /// <summary>
    ///   <para>deps:BuildPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>deps:Phase</para>
    /// </remarks>
    /// <seealso href="http://ontologi.es/doap-deps#BuildPhase">http://ontologi.es/doap-deps#BuildPhase</seealso>
    let BuildPhase = Prefixed_Name(deps, "BuildPhase") |> PrefixedName
    /// <summary>
    ///   <para>deps:Phase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontologi.es/doap-deps#Phase">http://ontologi.es/doap-deps#Phase</seealso>
    let Phase = Prefixed_Name(deps, "Phase") |> PrefixedName
    /// <summary>
    ///   <para>deps:DebianId</para>
    /// </summary>
    /// <remarks>
    ///   <para>deps:IdentifierScheme</para>
    ///   <para>Examples: `libmoose-perl` or `libmoose-perl (&gt;= 2.0600-1)`</para>
    ///   <para>Note that architecture-specific modifiers (in square brackets) are not supported yet.</para>
    /// labels<para>Debian Package Identifier</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#DebianId">http://ontologi.es/doap-deps#DebianId</seealso>
    let DebianId = Prefixed_Name(deps, "DebianId") |> PrefixedName
    /// <summary>
    ///   <para>deps:Dependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A condition to be met</para>
    /// labels<para>Dependency</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#Dependency">http://ontologi.es/doap-deps#Dependency</seealso>
    let Dependency = Prefixed_Name(deps, "Dependency") |> PrefixedName
    /// <summary>
    ///   <para>deps:HistoricDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Historic Dependency</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#HistoricDependency">http://ontologi.es/doap-deps#HistoricDependency</seealso>
    let HistoricDependency = Prefixed_Name(deps, "HistoricDependency") |> PrefixedName
    /// <summary>
    ///   <para>deps:Level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontologi.es/doap-deps#Level">http://ontologi.es/doap-deps#Level</seealso>
    let Level = Prefixed_Name(deps, "Level") |> PrefixedName
    /// <summary>
    ///   <para>deps:MvnId</para>
    /// </summary>
    /// <remarks>
    ///   <para>deps:IdentifierScheme</para>
    ///   <para>Example 'org.clojure/clojure 1.5.1-SNAPSHOT'</para>
    ///   <para>A fully qualified Maven artefact name: 'groupID/artefactID version[-classifier]'</para>
    /// labels<para>Maven Identifier</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#MvnId">http://ontologi.es/doap-deps#MvnId</seealso>
    let MvnId = Prefixed_Name(deps, "MvnId") |> PrefixedName
    /// <summary>
    ///   <para>deps:RpmId</para>
    /// </summary>
    /// <remarks>
    ///   <para>deps:IdentifierScheme</para>
    ///   <para>Examples: `perl-Moose` or `perl-Moose &gt;= 2.0600-1`</para>
    /// labels<para>RPM Package Identifier</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#RpmId">http://ontologi.es/doap-deps#RpmId</seealso>
    let RpmId = Prefixed_Name(deps, "RpmId") |> PrefixedName
    /// <summary>
    ///   <para>deps:RuntimePhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>deps:Phase</para>
    /// </remarks>
    /// <seealso href="http://ontologi.es/doap-deps#RuntimePhase">http://ontologi.es/doap-deps#RuntimePhase</seealso>
    let RuntimePhase = Prefixed_Name(deps, "RuntimePhase") |> PrefixedName
    /// <summary>
    ///   <para>deps:build-suggestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>build suggestion</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#build-suggestion">http://ontologi.es/doap-deps#build-suggestion</seealso>
    let build_suggestion = Prefixed_Name(deps, "build-suggestion") |> PrefixedName

    /// <summary>
    ///   <para>deps:configure-recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>configure recommendation</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#configure-recommendation">http://ontologi.es/doap-deps#configure-recommendation</seealso>
    let configure_recommendation =
        Prefixed_Name(deps, "configure-recommendation") |> PrefixedName

    /// <summary>
    ///   <para>deps:develop-recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>development recommendation</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#develop-recommendation">http://ontologi.es/doap-deps#develop-recommendation</seealso>
    let develop_recommendation =
        Prefixed_Name(deps, "develop-recommendation") |> PrefixedName

    /// <summary>
    ///   <para>deps:develop-requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>development requirement</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#develop-requirement">http://ontologi.es/doap-deps#develop-requirement</seealso>
    let develop_requirement = Prefixed_Name(deps, "develop-requirement") |> PrefixedName

    /// <summary>
    ///   <para>deps:runtime-recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>runtime recommendation</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#runtime-recommendation">http://ontologi.es/doap-deps#runtime-recommendation</seealso>
    let runtime_recommendation =
        Prefixed_Name(deps, "runtime-recommendation") |> PrefixedName

    /// <summary>
    ///   <para>deps:runtime-requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>runtime requirement</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#runtime-requirement">http://ontologi.es/doap-deps#runtime-requirement</seealso>
    let runtime_requirement = Prefixed_Name(deps, "runtime-requirement") |> PrefixedName
    /// <summary>
    ///   <para>deps:runtime-suggestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>runtime suggestion</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#runtime-suggestion">http://ontologi.es/doap-deps#runtime-suggestion</seealso>
    let runtime_suggestion = Prefixed_Name(deps, "runtime-suggestion") |> PrefixedName
    /// <summary>
    ///   <para>deps:test-recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>test recommendation</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#test-recommendation">http://ontologi.es/doap-deps#test-recommendation</seealso>
    let test_recommendation = Prefixed_Name(deps, "test-recommendation") |> PrefixedName
    /// <summary>
    ///   <para>deps:test-requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>test requirement</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#test-requirement">http://ontologi.es/doap-deps#test-requirement</seealso>
    let test_requirement = Prefixed_Name(deps, "test-requirement") |> PrefixedName
    /// <summary>
    ///   <para>deps:test-suggestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>test suggestion</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#test-suggestion">http://ontologi.es/doap-deps#test-suggestion</seealso>
    let test_suggestion = Prefixed_Name(deps, "test-suggestion") |> PrefixedName
    /// <summary>
    ///   <para>deps:ConfigurePhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>deps:Phase</para>
    /// </remarks>
    /// <seealso href="http://ontologi.es/doap-deps#ConfigurePhase">http://ontologi.es/doap-deps#ConfigurePhase</seealso>
    let ConfigurePhase = Prefixed_Name(deps, "ConfigurePhase") |> PrefixedName
    /// <summary>
    ///   <para>deps:level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://ontologi.es/doap-deps#level">http://ontologi.es/doap-deps#level</seealso>
    let level = Prefixed_Name(deps, "level") |> PrefixedName
    /// <summary>
    ///   <para>deps:DevelopmentPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>deps:Phase</para>
    /// </remarks>
    /// <seealso href="http://ontologi.es/doap-deps#DevelopmentPhase">http://ontologi.es/doap-deps#DevelopmentPhase</seealso>
    let DevelopmentPhase = Prefixed_Name(deps, "DevelopmentPhase") |> PrefixedName
    /// <summary>
    ///   <para>deps:GemId</para>
    /// </summary>
    /// <remarks>
    ///   <para>deps:IdentifierScheme</para>
    ///   <para>A module name, optionally followed by one or more operator, version number pairs.</para>
    ///   <para>Examples: `log4r` or `log4r &gt;= 1.0.5` or `log4r &gt;= 1.0.5, &lt; 2.0.0`</para>
    /// labels<para>Gem Identifier</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#GemId">http://ontologi.es/doap-deps#GemId</seealso>
    let GemId = Prefixed_Name(deps, "GemId") |> PrefixedName
    /// <summary>
    ///   <para>deps:Required</para>
    /// </summary>
    /// <remarks>
    ///   <para>deps:Level</para>
    /// </remarks>
    /// <seealso href="http://ontologi.es/doap-deps#Required">http://ontologi.es/doap-deps#Required</seealso>
    let Required = Prefixed_Name(deps, "Required") |> PrefixedName
    /// <summary>
    ///   <para>deps:Suggested</para>
    /// </summary>
    /// <remarks>
    ///   <para>deps:Level</para>
    /// </remarks>
    /// <seealso href="http://ontologi.es/doap-deps#Suggested">http://ontologi.es/doap-deps#Suggested</seealso>
    let Suggested = Prefixed_Name(deps, "Suggested") |> PrefixedName
    /// <summary>
    ///   <para>deps:phase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://ontologi.es/doap-deps#phase">http://ontologi.es/doap-deps#phase</seealso>
    let phase = Prefixed_Name(deps, "phase") |> PrefixedName

    /// <summary>
    ///   <para>deps:configure-requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>configure requirement</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#configure-requirement">http://ontologi.es/doap-deps#configure-requirement</seealso>
    let configure_requirement =
        Prefixed_Name(deps, "configure-requirement") |> PrefixedName

    /// <summary>
    ///   <para>deps:develop-suggestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>development suggestion</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#develop-suggestion">http://ontologi.es/doap-deps#develop-suggestion</seealso>
    let develop_suggestion = Prefixed_Name(deps, "develop-suggestion") |> PrefixedName
    /// <summary>
    ///   <para>deps:Recommended</para>
    /// </summary>
    /// <remarks>
    ///   <para>deps:Level</para>
    /// </remarks>
    /// <seealso href="http://ontologi.es/doap-deps#Recommended">http://ontologi.es/doap-deps#Recommended</seealso>
    let Recommended = Prefixed_Name(deps, "Recommended") |> PrefixedName
    /// <summary>
    ///   <para>deps:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>an extension to DOAP for describing a project's requirements</para>
    /// labels<para>DOAP Dependencies</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#">http://ontologi.es/doap-deps#</seealso>
    let _prefix_iri = Prefixed_Name(deps, "") |> PrefixedName
    /// <summary>
    ///   <para>deps:CpanId</para>
    /// </summary>
    /// <remarks>
    ///   <para>deps:IdentifierScheme</para>
    ///   <para>A module name, optionally followed by a space character and a version.</para>
    ///   <para>Examples: `Moose::Role` or `Moose::Role 2.0600`</para>
    /// labels<para>CPAN Identifier</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#CpanId">http://ontologi.es/doap-deps#CpanId</seealso>
    let CpanId = Prefixed_Name(deps, "CpanId") |> PrefixedName
    /// <summary>
    ///   <para>deps:IdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://ontologi.es/doap-deps#IdentifierScheme">http://ontologi.es/doap-deps#IdentifierScheme</seealso>
    let IdentifierScheme = Prefixed_Name(deps, "IdentifierScheme") |> PrefixedName
    /// <summary>
    ///   <para>deps:PipId</para>
    /// </summary>
    /// <remarks>
    ///   <para>deps:IdentifierScheme</para>
    ///   <para>A single line from a requirements.txt file, minus the line break.</para>
    ///   <para>Example: `html5lib==0.95`</para>
    /// labels<para>Pip Identifier</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#PipId">http://ontologi.es/doap-deps#PipId</seealso>
    let PipId = Prefixed_Name(deps, "PipId") |> PrefixedName
    /// <summary>
    ///   <para>deps:TestPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>deps:Phase</para>
    /// </remarks>
    /// <seealso href="http://ontologi.es/doap-deps#TestPhase">http://ontologi.es/doap-deps#TestPhase</seealso>
    let TestPhase = Prefixed_Name(deps, "TestPhase") |> PrefixedName

    /// <summary>
    ///   <para>deps:build-recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>build recommendation</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#build-recommendation">http://ontologi.es/doap-deps#build-recommendation</seealso>
    let build_recommendation =
        Prefixed_Name(deps, "build-recommendation") |> PrefixedName

    /// <summary>
    ///   <para>deps:build-requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>build requirement</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#build-requirement">http://ontologi.es/doap-deps#build-requirement</seealso>
    let build_requirement = Prefixed_Name(deps, "build-requirement") |> PrefixedName

    /// <summary>
    ///   <para>deps:configure-suggestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>configure suggestion</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#configure-suggestion">http://ontologi.es/doap-deps#configure-suggestion</seealso>
    let configure_suggestion =
        Prefixed_Name(deps, "configure-suggestion") |> PrefixedName

    /// <summary>
    ///   <para>deps:on</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>the range of this property is a little woolly; a doap:Project is certainly fine, as is a literal which acts as an identifier, provided it's qualified with a datatype indicating what scheme it's an identifier in</para>
    /// labels<para>on</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#on">http://ontologi.es/doap-deps#on</seealso>
    let on = Prefixed_Name(deps, "on") |> PrefixedName
    /// <summary>
    ///   <para>deps:since</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>since</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#since">http://ontologi.es/doap-deps#since</seealso>
    let since = Prefixed_Name(deps, "since") |> PrefixedName
    /// <summary>
    ///   <para>deps:until</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>until</para></remarks>
    /// <seealso href="http://ontologi.es/doap-deps#until">http://ontologi.es/doap-deps#until</seealso>
    let until = Prefixed_Name(deps, "until") |> PrefixedName
