namespace http.vocab.deri.ie.odapp.hash

open DoxAletheia

module odapp =
    let _namespace_name = "http://vocab.deri.ie/odapp#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/odapp#fadmaa"></see>
    /// </summary>
    let fadmaa = _prefix "fadmaa"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/odapp#niklou"></see>
    /// </summary>
    let niklou = _prefix "niklou"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/odapp#gofshu"></see>
    /// </summary>
    let gofshu = _prefix "gofshu"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/odapp#deilee"></see>
    /// </summary>
    let deilee = _prefix "deilee"
    /// <summary>
    /// describes the type of the application (e.g. mobile app, desktop app, etc...)
    /// <see href="http://vocab.deri.ie/odapp#AppType"></see></summary>
    let AppType = _prefix "AppType"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/odapp#DERI%2C%20NUI%20Galway"></see>
    /// </summary>
    let ``DERI%2C%20NUI%20Galway`` = _prefix "DERI%2C%20NUI%20Galway"
    /// <summary>
    /// a free application
    /// <see href="http://vocab.deri.ie/odapp#FreeApp"></see></summary>
    let FreeApp = _prefix "FreeApp"
    /// <summary>
    /// a paid application
    /// <see href="http://vocab.deri.ie/odapp#PaidApp"></see></summary>
    let PaidApp = _prefix "PaidApp"
    /// <summary>
    /// An application price
    /// <see href="http://vocab.deri.ie/odapp#Price"></see></summary>
    let Price = _prefix "Price"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/odapp#appType"></see>
    /// </summary>
    let appType = _prefix "appType"
    /// <summary>
    /// relationship between the admssw:SoftwareRelease and odap:Price
    /// <see href="http://vocab.deri.ie/odapp#price"></see></summary>
    let price = _prefix "price"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/odapp#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/odapp#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
    /// <summary>
    /// describes a dataset that is used by the application
    /// <see href="http://vocab.deri.ie/odapp#uses"></see></summary>
    let uses = _prefix "uses"
