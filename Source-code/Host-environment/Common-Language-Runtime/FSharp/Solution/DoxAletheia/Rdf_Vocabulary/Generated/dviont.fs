namespace http.purl.org.ontology.dvia.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dviont =
    let _namespace_iri = Namespace_Iri dviont |> NamespaceIRI
    /// <summary>
    ///   <para>dviont:Application</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The aplication or the mashup developed for demo-ing or consuming data in LD fashion"</para>
    /// labels<para>"Application"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#Application">http://purl.org/ontology/dvia#Application</seealso>
    let Application = Prefixed_Name(dviont, "Application") |> PrefixedName
    /// <summary>
    ///   <para>dviont:Platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The platform where to host or use the application, could be on the web (firefox, chrome, IE, etc..) or mobile (android, etc..) or event desktop"</para>
    /// labels<para>"Plate forme"</para><para>"Platform"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#Platform">http://purl.org/ontology/dvia#Platform</seealso>
    let Platform = Prefixed_Name(dviont, "Platform") |> PrefixedName
    /// <summary>
    ///   <para>dviont:VisualTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The tool or library used to build the application"</para>
    /// labels<para>"Outil de visualisation"</para><para>"visual Tool"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#VisualTool">http://purl.org/ontology/dvia#VisualTool</seealso>
    let VisualTool = Prefixed_Name(dviont, "VisualTool") |> PrefixedName

    /// <summary>
    ///   <para>dviont:alternativeNavigator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name of the alternate navigator if applicable"</para>
    /// labels<para>"alternative navigator"</para><para>"navigateur alternatif"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#alternativeNavigator">http://purl.org/ontology/dvia#alternativeNavigator</seealso>
    let alternativeNavigator =
        Prefixed_Name(dviont, "alternativeNavigator") |> PrefixedName

    /// <summary>
    ///   <para>dviont:author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"links to the authors of the application or the tools, libraries"</para>
    /// labels<para>"auteur"</para><para>"author"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#author">http://purl.org/ontology/dvia#author</seealso>
    let author = Prefixed_Name(dviont, "author") |> PrefixedName
    /// <summary>
    ///   <para>dviont:businessValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The business value of the application; generally could be commercial of free. Also depending on the license"</para>
    /// labels<para>"businessValue"</para><para>"valeur commerciale"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#businessValue">http://purl.org/ontology/dvia#businessValue</seealso>
    let businessValue = Prefixed_Name(dviont, "businessValue") |> PrefixedName
    /// <summary>
    ///   <para>dviont:consumes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"links to the dataset used to make the application, and could be of different types or formats"</para>
    /// labels<para>"consomme"</para><para>"consumes"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#consumes">http://purl.org/ontology/dvia#consumes</seealso>
    let consumes = Prefixed_Name(dviont, "consumes") |> PrefixedName
    /// <summary>
    ///   <para>dviont:datasetDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property for a given descriptive informations of the datasets used for making the application. It could be used when no more details are given on the datasets like URL, formats, etc."</para>
    /// labels<para>"description du jeu de donn�es"</para><para>"dataset description"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#datasetDescription">http://purl.org/ontology/dvia#datasetDescription</seealso>
    let datasetDescription = Prefixed_Name(dviont, "datasetDescription") |> PrefixedName
    /// <summary>
    ///   <para>dviont:designBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"links to the organization which builds the application"</para>
    /// labels<para>"design By"</para><para>"impl�menter par"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#designBy">http://purl.org/ontology/dvia#designBy</seealso>
    let designBy = Prefixed_Name(dviont, "designBy") |> PrefixedName
    /// <summary>
    ///   <para>dviont:downloadUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The download url of the tool for visualization."</para>
    /// labels<para>"url t�l�chargement"</para><para>"download url"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#downloadUrl">http://purl.org/ontology/dvia#downloadUrl</seealso>
    let downloadUrl = Prefixed_Name(dviont, "downloadUrl") |> PrefixedName
    /// <summary>
    ///   <para>dviont:hasLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links to the license of the application"</para>
    /// labels<para>"a pour license"</para><para>"hasLicense"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#hasLicense">http://purl.org/ontology/dvia#hasLicense</seealso>
    let hasLicense = Prefixed_Name(dviont, "hasLicense") |> PrefixedName
    /// <summary>
    ///   <para>dviont:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"keywords used for the application."</para>
    /// labels<para>"keyword"</para><para>"mot cl�"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#keyword">http://purl.org/ontology/dvia#keyword</seealso>
    let keyword = Prefixed_Name(dviont, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>dviont:libUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The url to the page describing the library or the tool for visualization."</para>
    /// labels<para>"library url"</para><para>"url de la librairie"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#libUrl">http://purl.org/ontology/dvia#libUrl</seealso>
    let libUrl = Prefixed_Name(dviont, "libUrl") |> PrefixedName
    /// <summary>
    ///   <para>dviont:platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"This property links the application to a platform to actually use the application."</para>
    /// labels<para>"plate forme"</para><para>"platform"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#platform">http://purl.org/ontology/dvia#platform</seealso>
    let platform = Prefixed_Name(dviont, "platform") |> PrefixedName
    /// <summary>
    ///   <para>dviont:preferredNavigator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The name of the preferred navigator to be usd by the application"</para>
    /// labels<para>"preferred navigator"</para><para>"navigateur pr�f�rr�"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#preferredNavigator">http://purl.org/ontology/dvia#preferredNavigator</seealso>
    let preferredNavigator = Prefixed_Name(dviont, "preferredNavigator") |> PrefixedName
    /// <summary>
    ///   <para>dviont:scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The scope or domain of the application."</para>
    /// labels<para>"scope"</para><para>"domain d'usage"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#scope">http://purl.org/ontology/dvia#scope</seealso>
    let scope = Prefixed_Name(dviont, "scope") |> PrefixedName
    /// <summary>
    ///   <para>dviont:system</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The operating system where the application runs."</para>
    /// labels<para>"system"</para><para>"syst�me"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#system">http://purl.org/ontology/dvia#system</seealso>
    let system = Prefixed_Name(dviont, "system") |> PrefixedName
    /// <summary>
    ///   <para>dviont:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the url of the application."</para>
    /// labels<para>"url"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#url">http://purl.org/ontology/dvia#url</seealso>
    let url = Prefixed_Name(dviont, "url") |> PrefixedName
    /// <summary>
    ///   <para>dviont:usesTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"This property links to the tools or libraries used for the application"</para>
    /// labels<para>"utilise l'outil"</para><para>"uses Tool"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#usesTool">http://purl.org/ontology/dvia#usesTool</seealso>
    let usesTool = Prefixed_Name(dviont, "usesTool") |> PrefixedName
    /// <summary>
    ///   <para>dviont:view</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The types of view available in the application, such as maps, charts, graphs, etc."</para>
    /// labels<para>"view"</para><para>"vue"</para></remarks>
    /// <seealso href="http://purl.org/ontology/dvia#view">http://purl.org/ontology/dvia#view</seealso>
    let view = Prefixed_Name(dviont, "view") |> PrefixedName
