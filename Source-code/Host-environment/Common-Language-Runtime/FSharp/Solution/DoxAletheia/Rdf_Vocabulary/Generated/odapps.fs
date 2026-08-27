namespace http.semweb.mmlab.be.ns.odapps.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module odapps =
    let _namespace_iri = Namespace_Iri odapps |> NamespaceIRI
    /// <summary>
    ///   <para>odapps:AppConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An App Concept describes an idea for an application (a digital work) which refers to Open Data."</para>
    /// labels<para>"Application Concept"</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#AppConcept">http://semweb.mmlab.be/ns/odapps#AppConcept</seealso>
    let AppConcept = Prefixed_Name(odapps, "AppConcept") |> PrefixedName
    /// <summary>
    ///   <para>odapps:Application</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An App Concept implementation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Application"</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#Application">http://semweb.mmlab.be/ns/odapps#Application</seealso>
    let Application = Prefixed_Name(odapps, "Application") |> PrefixedName
    /// <summary>
    ///   <para>odapps:Tool</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The tool or library used to build the application."</para>
    /// labels<para>"Tool."</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#Tool">http://semweb.mmlab.be/ns/odapps#Tool</seealso>
    let Tool = Prefixed_Name(odapps, "Tool") |> PrefixedName
    /// <summary>
    ///   <para>odapps:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"comment on the application and the Concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"comment"</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#comment">http://semweb.mmlab.be/ns/odapps#comment</seealso>
    let comment = Prefixed_Name(odapps, "comment") |> PrefixedName
    /// <summary>
    ///   <para>odapps:conceived</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Agent which conceived the idea about the App Concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"conceived by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#conceived">http://semweb.mmlab.be/ns/odapps#conceived</seealso>
    let conceived = Prefixed_Name(odapps, "conceived") |> PrefixedName
    /// <summary>
    ///   <para>odapps:consumes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"links to the dataset used to make the application, and could be of different types or formats"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"consumes"</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#consumes">http://semweb.mmlab.be/ns/odapps#consumes</seealso>
    let consumes = Prefixed_Name(odapps, "consumes") |> PrefixedName
    /// <summary>
    ///   <para>odapps:datasetDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property for a given descriptive informations of the datasets used for making the application. It could be used when no more details are given on the datasets like URL, formats, etc."</para>
    /// labels<para>"dataset description"</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#datasetDescription">http://semweb.mmlab.be/ns/odapps#datasetDescription</seealso>
    let datasetDescription = Prefixed_Name(odapps, "datasetDescription") |> PrefixedName
    /// <summary>
    ///   <para>odapps:demoUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property for a given demo of the application and/or the Concept."</para>
    /// labels<para>"demo uri"</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#demoUri">http://semweb.mmlab.be/ns/odapps#demoUri</seealso>
    let demoUri = Prefixed_Name(odapps, "demoUri") |> PrefixedName
    /// <summary>
    ///   <para>odapps:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property for a given descriptive informations of the concept and/or the application."</para>
    /// labels<para>"Concept and/or Application description"</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#description">http://semweb.mmlab.be/ns/odapps#description</seealso>
    let description = Prefixed_Name(odapps, "description") |> PrefixedName
    /// <summary>
    ///   <para>odapps:downloadUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property links to the application"</para>
    /// labels<para>"download url"</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#downloadUrl">http://semweb.mmlab.be/ns/odapps#downloadUrl</seealso>
    let downloadUrl = Prefixed_Name(odapps, "downloadUrl") |> PrefixedName
    /// <summary>
    ///   <para>odapps:implements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The App Concept that this application implements"</para>
    /// labels<para>"implements"</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#implements">http://semweb.mmlab.be/ns/odapps#implements</seealso>
    let implements = Prefixed_Name(odapps, "implements") |> PrefixedName
    /// <summary>
    ///   <para>odapps:instigator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The Agent which conceived the idea about the App Concept (the instigator/initiator)."</para>
    /// labels<para>"instigator"</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#instigator">http://semweb.mmlab.be/ns/odapps#instigator</seealso>
    let instigator = Prefixed_Name(odapps, "instigator") |> PrefixedName
    /// <summary>
    ///   <para>odapps:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The keywords of the Application."</para>
    /// labels<para>"dataset description"</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#keyword">http://semweb.mmlab.be/ns/odapps#keyword</seealso>
    let keyword = Prefixed_Name(odapps, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>odapps:license</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"This property links to the license of the application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has license"</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#license">http://semweb.mmlab.be/ns/odapps#license</seealso>
    let license = Prefixed_Name(odapps, "license") |> PrefixedName
    /// <summary>
    ///   <para>odapps:revised</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The Agent which revised / extended the idea about the App Concept."</para>
    /// labels<para>"revised"</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#revised">http://semweb.mmlab.be/ns/odapps#revised</seealso>
    let revised = Prefixed_Name(odapps, "revised") |> PrefixedName
    /// <summary>
    ///   <para>odapps:revision</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An App concept which was revised and re-posed / extended. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"revision of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#revision">http://semweb.mmlab.be/ns/odapps#revision</seealso>
    let revision = Prefixed_Name(odapps, "revision") |> PrefixedName
    /// <summary>
    ///   <para>odapps:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property links to the application"</para>
    /// labels<para>"url"</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#url">http://semweb.mmlab.be/ns/odapps#url</seealso>
    let url = Prefixed_Name(odapps, "url") |> PrefixedName
    /// <summary>
    ///   <para>odapps:usesTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property links to the tools or libraries used for the application"</para>
    /// labels<para>"usesTool"</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/odapps#usesTool">http://semweb.mmlab.be/ns/odapps#usesTool</seealso>
    let usesTool = Prefixed_Name(odapps, "usesTool") |> PrefixedName
