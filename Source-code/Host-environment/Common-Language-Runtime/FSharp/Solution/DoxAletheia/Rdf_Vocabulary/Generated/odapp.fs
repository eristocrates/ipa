namespace http.vocab.deri.ie.odapp.hash

open DoxAletheia.Rdf_Vocabulary

module odapp =
    let _namespace_name = "http://vocab.deri.ie/odapp#"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/odapp#fadmaa"></see>
    /// </summary>
    let fadmaa = Namespaced_IRI.parse _namespace_name "fadmaa" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/odapp#niklou"></see>
    /// </summary>
    let niklou = Namespaced_IRI.parse _namespace_name "niklou" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/odapp#gofshu"></see>
    /// </summary>
    let gofshu = Namespaced_IRI.parse _namespace_name "gofshu" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/odapp#deilee"></see>
    /// </summary>
    let deilee = Namespaced_IRI.parse _namespace_name "deilee" |> NamespacedName
    /// <summary>
    /// describes the type of the application (e.g. mobile app, desktop app, etc...)
    /// <see href="http://vocab.deri.ie/odapp#AppType"></see></summary>
    let AppType = Namespaced_IRI.parse _namespace_name "AppType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/odapp#DERI%2C%20NUI%20Galway"></see>
    /// </summary>
    let ``DERI%2C%20NUI%20Galway`` =
        Namespaced_IRI.parse _namespace_name "DERI%2C%20NUI%20Galway" |> NamespacedName

    /// <summary>
    /// a free application
    /// <see href="http://vocab.deri.ie/odapp#FreeApp"></see></summary>
    let FreeApp = Namespaced_IRI.parse _namespace_name "FreeApp" |> NamespacedName
    /// <summary>
    /// a paid application
    /// <see href="http://vocab.deri.ie/odapp#PaidApp"></see></summary>
    let PaidApp = Namespaced_IRI.parse _namespace_name "PaidApp" |> NamespacedName
    /// <summary>
    /// An application price
    /// <see href="http://vocab.deri.ie/odapp#Price"></see></summary>
    let Price = Namespaced_IRI.parse _namespace_name "Price" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/odapp#appType"></see>
    /// </summary>
    let appType = Namespaced_IRI.parse _namespace_name "appType" |> NamespacedName
    /// <summary>
    /// relationship between the admssw:SoftwareRelease and odap:Price
    /// <see href="http://vocab.deri.ie/odapp#price"></see></summary>
    let price = Namespaced_IRI.parse _namespace_name "price" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/odapp#rdf"></see>
    /// </summary>
    let rdf = Namespaced_IRI.parse _namespace_name "rdf" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/odapp#ttl"></see>
    /// </summary>
    let ttl = Namespaced_IRI.parse _namespace_name "ttl" |> NamespacedName
    /// <summary>
    /// describes a dataset that is used by the application
    /// <see href="http://vocab.deri.ie/odapp#uses"></see></summary>
    let uses = Namespaced_IRI.parse _namespace_name "uses" |> NamespacedName
