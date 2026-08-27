namespace http.vocab.deri.ie.odapp.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module odapp =
    let _namespace_iri = Namespace_Iri odapp |> NamespaceIRI
    /// <summary>
    ///   <para>odapp:AppType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"describes the type of the application (e.g. mobile app, desktop app, etc...)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"application type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/odapp#AppType">http://vocab.deri.ie/odapp#AppType</seealso>
    let AppType = Prefixed_Name(odapp, "AppType") |> PrefixedName

    /// <summary>
    ///   <para>odapp:DERI%2C%20NUI%20Galway</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/odapp#DERI%2C%20NUI%20Galway">http://vocab.deri.ie/odapp#DERI%2C%20NUI%20Galway</seealso>
    let ``DERI%2C%20NUI%20Galway`` =
        Prefixed_Name(odapp, "DERI%2C%20NUI%20Galway") |> PrefixedName

    /// <summary>
    ///   <para>odapp:FreeApp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"a free application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"free application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/odapp#FreeApp">http://vocab.deri.ie/odapp#FreeApp</seealso>
    let FreeApp = Prefixed_Name(odapp, "FreeApp") |> PrefixedName
    /// <summary>
    ///   <para>odapp:PaidApp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"a paid application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"paid application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/odapp#PaidApp">http://vocab.deri.ie/odapp#PaidApp</seealso>
    let PaidApp = Prefixed_Name(odapp, "PaidApp") |> PrefixedName
    /// <summary>
    ///   <para>odapp:Price</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An application price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"application price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/odapp#Price">http://vocab.deri.ie/odapp#Price</seealso>
    let Price = Prefixed_Name(odapp, "Price") |> PrefixedName
    /// <summary>
    ///   <para>odapp:appType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"application type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/odapp#appType">http://vocab.deri.ie/odapp#appType</seealso>
    let appType = Prefixed_Name(odapp, "appType") |> PrefixedName
    /// <summary>
    ///   <para>odapp:deilee</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/odapp#deilee">http://vocab.deri.ie/odapp#deilee</seealso>
    let deilee = Prefixed_Name(odapp, "deilee") |> PrefixedName
    /// <summary>
    ///   <para>odapp:fadmaa</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/odapp#fadmaa">http://vocab.deri.ie/odapp#fadmaa</seealso>
    let fadmaa = Prefixed_Name(odapp, "fadmaa") |> PrefixedName
    /// <summary>
    ///   <para>odapp:gofshu</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/odapp#gofshu">http://vocab.deri.ie/odapp#gofshu</seealso>
    let gofshu = Prefixed_Name(odapp, "gofshu") |> PrefixedName
    /// <summary>
    ///   <para>odapp:niklou</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/odapp#niklou">http://vocab.deri.ie/odapp#niklou</seealso>
    let niklou = Prefixed_Name(odapp, "niklou") |> PrefixedName
    /// <summary>
    ///   <para>odapp:price</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"relationship between the admssw:SoftwareRelease and odap:Price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"application price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/odapp#price">http://vocab.deri.ie/odapp#price</seealso>
    let price = Prefixed_Name(odapp, "price") |> PrefixedName
    /// <summary>
    ///   <para>odapp:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/odapp#rdf">http://vocab.deri.ie/odapp#rdf</seealso>
    let rdf = Prefixed_Name(odapp, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>odapp:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/odapp#ttl">http://vocab.deri.ie/odapp#ttl</seealso>
    let ttl = Prefixed_Name(odapp, "ttl") |> PrefixedName
    /// <summary>
    ///   <para>odapp:uses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"describes a dataset that is used by the application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"uses dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.deri.ie/odapp#uses">http://vocab.deri.ie/odapp#uses</seealso>
    let uses = Prefixed_Name(odapp, "uses") |> PrefixedName
