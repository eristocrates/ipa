namespace http.acm.rkbexplorer.com.ontologies.acm.hash

open DoxAletheia

module acm =
    let _namespace_name = "http://acm.rkbexplorer.com/ontologies/acm#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#A"></see>
    /// </summary>
    let A = _prefix "A"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#A.0"></see>
    /// </summary>
    let ``A.0`` = _prefix "A.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#A.0.0"></see>
    /// </summary>
    let ``A.0.0`` = _prefix "A.0.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#A.0.1"></see>
    /// </summary>
    let ``A.0.1`` = _prefix "A.0.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#A.0.2"></see>
    /// </summary>
    let ``A.0.2`` = _prefix "A.0.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#A.1"></see>
    /// </summary>
    let ``A.1`` = _prefix "A.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#A.2"></see>
    /// </summary>
    let ``A.2`` = _prefix "A.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#A.m"></see>
    /// </summary>
    let ``A.m`` = _prefix "A.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B"></see>
    /// </summary>
    let B = _prefix "B"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.0"></see>
    /// </summary>
    let ``B.0`` = _prefix "B.0"
    /// <summary>
    /// See also #D.3.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1"></see></summary>
    let ``B.1`` = _prefix "B.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.0"></see>
    /// </summary>
    let ``B.1.0`` = _prefix "B.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.1"></see>
    /// </summary>
    let ``B.1.1`` = _prefix "B.1.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.1.0"></see></summary>
    let ``B.1.1.0`` = _prefix "B.1.1.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.1.1"></see></summary>
    let ``B.1.1.1`` = _prefix "B.1.1.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.1.2"></see></summary>
    let ``B.1.1.2`` = _prefix "B.1.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.2"></see>
    /// </summary>
    let ``B.1.2`` = _prefix "B.1.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.2.0"></see></summary>
    let ``B.1.2.0`` = _prefix "B.1.2.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.2.1"></see></summary>
    let ``B.1.2.1`` = _prefix "B.1.2.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.2.2"></see></summary>
    let ``B.1.2.2`` = _prefix "B.1.2.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998. See also #B.8.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3"></see></summary>
    let ``B.1.3`` = _prefix "B.1.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3.0"></see></summary>
    let ``B.1.3.0`` = _prefix "B.1.3.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3.1"></see></summary>
    let ``B.1.3.1`` = _prefix "B.1.3.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3.2"></see></summary>
    let ``B.1.3.2`` = _prefix "B.1.3.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3.3"></see></summary>
    let ``B.1.3.3`` = _prefix "B.1.3.3"
    /// <summary>
    /// See also #D.2.2, #D.2.4, #D.3.2, #D.3.4.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4"></see></summary>
    let ``B.1.4`` = _prefix "B.1.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.0"></see></summary>
    let ``B.1.4.0`` = _prefix "B.1.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.1"></see>
    /// </summary>
    let ``B.1.4.1`` = _prefix "B.1.4.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.2"></see></summary>
    let ``B.1.4.2`` = _prefix "B.1.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.3"></see>
    /// </summary>
    let ``B.1.4.3`` = _prefix "B.1.4.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.4"></see></summary>
    let ``B.1.4.4`` = _prefix "B.1.4.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5"></see>
    /// </summary>
    let ``B.1.5`` = _prefix "B.1.5"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.0"></see></summary>
    let ``B.1.5.0`` = _prefix "B.1.5.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.1"></see></summary>
    let ``B.1.5.1`` = _prefix "B.1.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.2"></see>
    /// </summary>
    let ``B.1.5.2`` = _prefix "B.1.5.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.3"></see></summary>
    let ``B.1.5.3`` = _prefix "B.1.5.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.4"></see></summary>
    let ``B.1.5.4`` = _prefix "B.1.5.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.1.m"></see>
    /// </summary>
    let ``B.1.m`` = _prefix "B.1.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2"></see>
    /// </summary>
    let ``B.2`` = _prefix "B.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.0"></see>
    /// </summary>
    let ``B.2.0`` = _prefix "B.2.0"
    /// <summary>
    /// See also #C.1.1, #C.1.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.1"></see></summary>
    let ``B.2.1`` = _prefix "B.2.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.1.0"></see></summary>
    let ``B.2.1.0`` = _prefix "B.2.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.1.1"></see>
    /// </summary>
    let ``B.2.1.1`` = _prefix "B.2.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.1.2"></see>
    /// </summary>
    let ``B.2.1.2`` = _prefix "B.2.1.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998. See also #B.8.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.2"></see></summary>
    let ``B.2.2`` = _prefix "B.2.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.2.0"></see></summary>
    let ``B.2.2.0`` = _prefix "B.2.2.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.2.1"></see></summary>
    let ``B.2.2.1`` = _prefix "B.2.2.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.2.2"></see></summary>
    let ``B.2.2.2`` = _prefix "B.2.2.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998. See also #B.8.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3"></see></summary>
    let ``B.2.3`` = _prefix "B.2.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3.0"></see></summary>
    let ``B.2.3.0`` = _prefix "B.2.3.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3.1"></see></summary>
    let ``B.2.3.1`` = _prefix "B.2.3.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3.2"></see></summary>
    let ``B.2.3.2`` = _prefix "B.2.3.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3.3"></see></summary>
    let ``B.2.3.3`` = _prefix "B.2.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.4"></see>
    /// </summary>
    let ``B.2.4`` = _prefix "B.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.4.0"></see>
    /// </summary>
    let ``B.2.4.0`` = _prefix "B.2.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.4.1"></see>
    /// </summary>
    let ``B.2.4.1`` = _prefix "B.2.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.2.m"></see>
    /// </summary>
    let ``B.2.m`` = _prefix "B.2.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3"></see>
    /// </summary>
    let ``B.3`` = _prefix "B.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.0"></see>
    /// </summary>
    let ``B.3.0`` = _prefix "B.3.0"
    /// <summary>
    /// See also #B.7.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.1"></see></summary>
    let ``B.3.1`` = _prefix "B.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.1.0"></see>
    /// </summary>
    let ``B.3.1.0`` = _prefix "B.3.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.1.1"></see>
    /// </summary>
    let ``B.3.1.1`` = _prefix "B.3.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.1.2"></see>
    /// </summary>
    let ``B.3.1.2`` = _prefix "B.3.1.2"
    /// <summary>
    /// See also #D.4.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2"></see></summary>
    let ``B.3.2`` = _prefix "B.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.0"></see>
    /// </summary>
    let ``B.3.2.0`` = _prefix "B.3.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.1"></see>
    /// </summary>
    let ``B.3.2.1`` = _prefix "B.3.2.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.2"></see></summary>
    let ``B.3.2.2`` = _prefix "B.3.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.3"></see>
    /// </summary>
    let ``B.3.2.3`` = _prefix "B.3.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.4"></see>
    /// </summary>
    let ``B.3.2.4`` = _prefix "B.3.2.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.5"></see></summary>
    let ``B.3.2.5`` = _prefix "B.3.2.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.6"></see>
    /// </summary>
    let ``B.3.2.6`` = _prefix "B.3.2.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.7"></see>
    /// </summary>
    let ``B.3.2.7`` = _prefix "B.3.2.7"
    /// <summary>
    /// Depricated, no longer used as of January 1998. See also #B.8, #C.4.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.3"></see></summary>
    let ``B.3.3`` = _prefix "B.3.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.3.0"></see></summary>
    let ``B.3.3.0`` = _prefix "B.3.3.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.3.1"></see></summary>
    let ``B.3.3.1`` = _prefix "B.3.3.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.3.2"></see></summary>
    let ``B.3.3.2`` = _prefix "B.3.3.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998. See also #B.8.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4"></see></summary>
    let ``B.3.4`` = _prefix "B.3.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4.0"></see></summary>
    let ``B.3.4.0`` = _prefix "B.3.4.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4.1"></see></summary>
    let ``B.3.4.1`` = _prefix "B.3.4.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4.2"></see></summary>
    let ``B.3.4.2`` = _prefix "B.3.4.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4.3"></see></summary>
    let ``B.3.4.3`` = _prefix "B.3.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.3.m"></see>
    /// </summary>
    let ``B.3.m`` = _prefix "B.3.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4"></see>
    /// </summary>
    let ``B.4`` = _prefix "B.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.0"></see>
    /// </summary>
    let ``B.4.0`` = _prefix "B.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.1"></see>
    /// </summary>
    let ``B.4.1`` = _prefix "B.4.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.1.0"></see></summary>
    let ``B.4.1.0`` = _prefix "B.4.1.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.1.1"></see></summary>
    let ``B.4.1.1`` = _prefix "B.4.1.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.1.2"></see></summary>
    let ``B.4.1.2`` = _prefix "B.4.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2"></see>
    /// </summary>
    let ``B.4.2`` = _prefix "B.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2.0"></see>
    /// </summary>
    let ``B.4.2.0`` = _prefix "B.4.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2.1"></see>
    /// </summary>
    let ``B.4.2.1`` = _prefix "B.4.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2.2"></see>
    /// </summary>
    let ``B.4.2.2`` = _prefix "B.4.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2.3"></see>
    /// </summary>
    let ``B.4.2.3`` = _prefix "B.4.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3"></see>
    /// </summary>
    let ``B.4.3`` = _prefix "B.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.0"></see>
    /// </summary>
    let ``B.4.3.0`` = _prefix "B.4.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.1"></see>
    /// </summary>
    let ``B.4.3.1`` = _prefix "B.4.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.2"></see>
    /// </summary>
    let ``B.4.3.2`` = _prefix "B.4.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.3"></see>
    /// </summary>
    let ``B.4.3.3`` = _prefix "B.4.3.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.4"></see></summary>
    let ``B.4.3.4`` = _prefix "B.4.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.5"></see>
    /// </summary>
    let ``B.4.3.5`` = _prefix "B.4.3.5"
    /// <summary>
    /// Depricated, no longer used as of January 1998. See also #B.8.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4"></see></summary>
    let ``B.4.4`` = _prefix "B.4.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4.0"></see></summary>
    let ``B.4.4.0`` = _prefix "B.4.4.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4.1"></see></summary>
    let ``B.4.4.1`` = _prefix "B.4.4.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4.2"></see></summary>
    let ``B.4.4.2`` = _prefix "B.4.4.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4.3"></see></summary>
    let ``B.4.4.3`` = _prefix "B.4.4.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998. See also #B.8.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5"></see></summary>
    let ``B.4.5`` = _prefix "B.4.5"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.0"></see></summary>
    let ``B.4.5.0`` = _prefix "B.4.5.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.1"></see></summary>
    let ``B.4.5.1`` = _prefix "B.4.5.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.2"></see></summary>
    let ``B.4.5.2`` = _prefix "B.4.5.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.3"></see></summary>
    let ``B.4.5.3`` = _prefix "B.4.5.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.4"></see></summary>
    let ``B.4.5.4`` = _prefix "B.4.5.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.5"></see></summary>
    let ``B.4.5.5`` = _prefix "B.4.5.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.4.m"></see>
    /// </summary>
    let ``B.4.m`` = _prefix "B.4.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5"></see>
    /// </summary>
    let ``B.5`` = _prefix "B.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.0"></see>
    /// </summary>
    let ``B.5.0`` = _prefix "B.5.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1"></see>
    /// </summary>
    let ``B.5.1`` = _prefix "B.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.0"></see>
    /// </summary>
    let ``B.5.1.0`` = _prefix "B.5.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.1"></see>
    /// </summary>
    let ``B.5.1.1`` = _prefix "B.5.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.2"></see>
    /// </summary>
    let ``B.5.1.2`` = _prefix "B.5.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.3"></see>
    /// </summary>
    let ``B.5.1.3`` = _prefix "B.5.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.4"></see>
    /// </summary>
    let ``B.5.1.4`` = _prefix "B.5.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2"></see>
    /// </summary>
    let ``B.5.2`` = _prefix "B.5.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.0"></see>
    /// </summary>
    let ``B.5.2.0`` = _prefix "B.5.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.1"></see>
    /// </summary>
    let ``B.5.2.1`` = _prefix "B.5.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.2"></see>
    /// </summary>
    let ``B.5.2.2`` = _prefix "B.5.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.3"></see>
    /// </summary>
    let ``B.5.2.3`` = _prefix "B.5.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.4"></see>
    /// </summary>
    let ``B.5.2.4`` = _prefix "B.5.2.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998. See also #B.8.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3"></see></summary>
    let ``B.5.3`` = _prefix "B.5.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.0"></see></summary>
    let ``B.5.3.0`` = _prefix "B.5.3.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.1"></see></summary>
    let ``B.5.3.1`` = _prefix "B.5.3.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.2"></see></summary>
    let ``B.5.3.2`` = _prefix "B.5.3.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.3"></see></summary>
    let ``B.5.3.3`` = _prefix "B.5.3.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.4"></see></summary>
    let ``B.5.3.4`` = _prefix "B.5.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.5.m"></see>
    /// </summary>
    let ``B.5.m`` = _prefix "B.5.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6"></see>
    /// </summary>
    let ``B.6`` = _prefix "B.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.0"></see>
    /// </summary>
    let ``B.6.0`` = _prefix "B.6.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1"></see>
    /// </summary>
    let ``B.6.1`` = _prefix "B.6.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.0"></see>
    /// </summary>
    let ``B.6.1.0`` = _prefix "B.6.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.1"></see>
    /// </summary>
    let ``B.6.1.1`` = _prefix "B.6.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.2"></see>
    /// </summary>
    let ``B.6.1.2`` = _prefix "B.6.1.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.3"></see></summary>
    let ``B.6.1.3`` = _prefix "B.6.1.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.4"></see></summary>
    let ``B.6.1.4`` = _prefix "B.6.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.5"></see>
    /// </summary>
    let ``B.6.1.5`` = _prefix "B.6.1.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.6"></see>
    /// </summary>
    let ``B.6.1.6`` = _prefix "B.6.1.6"
    /// <summary>
    /// Depricated, no longer used as of January 1998. See also #B.8.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2"></see></summary>
    let ``B.6.2`` = _prefix "B.6.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.0"></see></summary>
    let ``B.6.2.0`` = _prefix "B.6.2.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.1"></see></summary>
    let ``B.6.2.1`` = _prefix "B.6.2.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.2"></see></summary>
    let ``B.6.2.2`` = _prefix "B.6.2.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.3"></see></summary>
    let ``B.6.2.3`` = _prefix "B.6.2.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.4"></see></summary>
    let ``B.6.2.4`` = _prefix "B.6.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3"></see>
    /// </summary>
    let ``B.6.3`` = _prefix "B.6.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.0"></see>
    /// </summary>
    let ``B.6.3.0`` = _prefix "B.6.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.1"></see>
    /// </summary>
    let ``B.6.3.1`` = _prefix "B.6.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.2"></see>
    /// </summary>
    let ``B.6.3.2`` = _prefix "B.6.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.3"></see>
    /// </summary>
    let ``B.6.3.3`` = _prefix "B.6.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.4"></see>
    /// </summary>
    let ``B.6.3.4`` = _prefix "B.6.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.5"></see>
    /// </summary>
    let ``B.6.3.5`` = _prefix "B.6.3.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.6.m"></see>
    /// </summary>
    let ``B.6.m`` = _prefix "B.6.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7"></see>
    /// </summary>
    let ``B.7`` = _prefix "B.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.0"></see>
    /// </summary>
    let ``B.7.0`` = _prefix "B.7.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1"></see>
    /// </summary>
    let ``B.7.1`` = _prefix "B.7.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.0"></see>
    /// </summary>
    let ``B.7.1.0`` = _prefix "B.7.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.1"></see>
    /// </summary>
    let ``B.7.1.1`` = _prefix "B.7.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.2"></see>
    /// </summary>
    let ``B.7.1.2`` = _prefix "B.7.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.3"></see>
    /// </summary>
    let ``B.7.1.3`` = _prefix "B.7.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.4"></see>
    /// </summary>
    let ``B.7.1.4`` = _prefix "B.7.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.5"></see>
    /// </summary>
    let ``B.7.1.5`` = _prefix "B.7.1.5"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.6"></see></summary>
    let ``B.7.1.6`` = _prefix "B.7.1.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.7"></see>
    /// </summary>
    let ``B.7.1.7`` = _prefix "B.7.1.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2"></see>
    /// </summary>
    let ``B.7.2`` = _prefix "B.7.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.0"></see>
    /// </summary>
    let ``B.7.2.0`` = _prefix "B.7.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.1"></see>
    /// </summary>
    let ``B.7.2.1`` = _prefix "B.7.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.2"></see>
    /// </summary>
    let ``B.7.2.2`` = _prefix "B.7.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.3"></see>
    /// </summary>
    let ``B.7.2.3`` = _prefix "B.7.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.4"></see>
    /// </summary>
    let ``B.7.2.4`` = _prefix "B.7.2.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998. See also #B.8.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3"></see></summary>
    let ``B.7.3`` = _prefix "B.7.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.0"></see></summary>
    let ``B.7.3.0`` = _prefix "B.7.3.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.1"></see></summary>
    let ``B.7.3.1`` = _prefix "B.7.3.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.2"></see></summary>
    let ``B.7.3.2`` = _prefix "B.7.3.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.3"></see></summary>
    let ``B.7.3.3`` = _prefix "B.7.3.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.4"></see></summary>
    let ``B.7.3.4`` = _prefix "B.7.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.7.m"></see>
    /// </summary>
    let ``B.7.m`` = _prefix "B.7.m"
    /// <summary>
    /// See also #C.4.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#B.8"></see></summary>
    let ``B.8`` = _prefix "B.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.8.0"></see>
    /// </summary>
    let ``B.8.0`` = _prefix "B.8.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.8.1"></see>
    /// </summary>
    let ``B.8.1`` = _prefix "B.8.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.8.2"></see>
    /// </summary>
    let ``B.8.2`` = _prefix "B.8.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.8.m"></see>
    /// </summary>
    let ``B.8.m`` = _prefix "B.8.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.m"></see>
    /// </summary>
    let ``B.m`` = _prefix "B.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#B.m.0"></see>
    /// </summary>
    let ``B.m.0`` = _prefix "B.m.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C"></see>
    /// </summary>
    let C = _prefix "C"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.0"></see>
    /// </summary>
    let ``C.0`` = _prefix "C.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.0.0"></see>
    /// </summary>
    let ``C.0.0`` = _prefix "C.0.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.0.1"></see>
    /// </summary>
    let ``C.0.1`` = _prefix "C.0.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.0.2"></see>
    /// </summary>
    let ``C.0.2`` = _prefix "C.0.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.0.3"></see>
    /// </summary>
    let ``C.0.3`` = _prefix "C.0.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.0.4"></see>
    /// </summary>
    let ``C.0.4`` = _prefix "C.0.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1"></see>
    /// </summary>
    let ``C.1`` = _prefix "C.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.0"></see>
    /// </summary>
    let ``C.1.0`` = _prefix "C.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1"></see>
    /// </summary>
    let ``C.1.1`` = _prefix "C.1.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.0"></see></summary>
    let ``C.1.1.0`` = _prefix "C.1.1.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.1"></see></summary>
    let ``C.1.1.1`` = _prefix "C.1.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.2"></see>
    /// </summary>
    let ``C.1.1.2`` = _prefix "C.1.1.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.3"></see></summary>
    let ``C.1.1.3`` = _prefix "C.1.1.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.4"></see></summary>
    let ``C.1.1.4`` = _prefix "C.1.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2"></see>
    /// </summary>
    let ``C.1.2`` = _prefix "C.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.0"></see>
    /// </summary>
    let ``C.1.2.0`` = _prefix "C.1.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.1"></see>
    /// </summary>
    let ``C.1.2.1`` = _prefix "C.1.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.2"></see>
    /// </summary>
    let ``C.1.2.2`` = _prefix "C.1.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.3"></see>
    /// </summary>
    let ``C.1.2.3`` = _prefix "C.1.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.4"></see>
    /// </summary>
    let ``C.1.2.4`` = _prefix "C.1.2.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.5"></see></summary>
    let ``C.1.2.5`` = _prefix "C.1.2.5"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.6"></see></summary>
    let ``C.1.2.6`` = _prefix "C.1.2.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.7"></see>
    /// </summary>
    let ``C.1.2.7`` = _prefix "C.1.2.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3"></see>
    /// </summary>
    let ``C.1.3`` = _prefix "C.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.0"></see>
    /// </summary>
    let ``C.1.3.0`` = _prefix "C.1.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.1"></see>
    /// </summary>
    let ``C.1.3.1`` = _prefix "C.1.3.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.2"></see></summary>
    let ``C.1.3.2`` = _prefix "C.1.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.3"></see>
    /// </summary>
    let ``C.1.3.3`` = _prefix "C.1.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.4"></see>
    /// </summary>
    let ``C.1.3.4`` = _prefix "C.1.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.5"></see>
    /// </summary>
    let ``C.1.3.5`` = _prefix "C.1.3.5"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.6"></see></summary>
    let ``C.1.3.6`` = _prefix "C.1.3.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.7"></see>
    /// </summary>
    let ``C.1.3.7`` = _prefix "C.1.3.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.8"></see>
    /// </summary>
    let ``C.1.3.8`` = _prefix "C.1.3.8"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.9"></see></summary>
    let ``C.1.3.9`` = _prefix "C.1.3.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.4"></see>
    /// </summary>
    let ``C.1.4`` = _prefix "C.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.4.0"></see>
    /// </summary>
    let ``C.1.4.0`` = _prefix "C.1.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.4.1"></see>
    /// </summary>
    let ``C.1.4.1`` = _prefix "C.1.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.m"></see>
    /// </summary>
    let ``C.1.m`` = _prefix "C.1.m"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.m.0"></see></summary>
    let ``C.1.m.0`` = _prefix "C.1.m.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#C.1.m.1"></see></summary>
    let ``C.1.m.1`` = _prefix "C.1.m.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2"></see>
    /// </summary>
    let ``C.2`` = _prefix "C.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.0"></see>
    /// </summary>
    let ``C.2.0`` = _prefix "C.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.0.0"></see>
    /// </summary>
    let ``C.2.0.0`` = _prefix "C.2.0.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.0.1"></see>
    /// </summary>
    let ``C.2.0.1`` = _prefix "C.2.0.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.0.2"></see>
    /// </summary>
    let ``C.2.0.2`` = _prefix "C.2.0.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1"></see>
    /// </summary>
    let ``C.2.1`` = _prefix "C.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.0"></see>
    /// </summary>
    let ``C.2.1.0`` = _prefix "C.2.1.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.1"></see></summary>
    let ``C.2.1.1`` = _prefix "C.2.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.10"></see>
    /// </summary>
    let ``C.2.1.10`` = _prefix "C.2.1.10"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.2"></see>
    /// </summary>
    let ``C.2.1.2`` = _prefix "C.2.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.3"></see>
    /// </summary>
    let ``C.2.1.3`` = _prefix "C.2.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.4"></see>
    /// </summary>
    let ``C.2.1.4`` = _prefix "C.2.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.5"></see>
    /// </summary>
    let ``C.2.1.5`` = _prefix "C.2.1.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.6"></see>
    /// </summary>
    let ``C.2.1.6`` = _prefix "C.2.1.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.7"></see>
    /// </summary>
    let ``C.2.1.7`` = _prefix "C.2.1.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.8"></see>
    /// </summary>
    let ``C.2.1.8`` = _prefix "C.2.1.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.9"></see>
    /// </summary>
    let ``C.2.1.9`` = _prefix "C.2.1.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2"></see>
    /// </summary>
    let ``C.2.2`` = _prefix "C.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2.0"></see>
    /// </summary>
    let ``C.2.2.0`` = _prefix "C.2.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2.1"></see>
    /// </summary>
    let ``C.2.2.1`` = _prefix "C.2.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2.2"></see>
    /// </summary>
    let ``C.2.2.2`` = _prefix "C.2.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2.3"></see>
    /// </summary>
    let ``C.2.2.3`` = _prefix "C.2.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.3"></see>
    /// </summary>
    let ``C.2.3`` = _prefix "C.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.3.0"></see>
    /// </summary>
    let ``C.2.3.0`` = _prefix "C.2.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.3.1"></see>
    /// </summary>
    let ``C.2.3.1`` = _prefix "C.2.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.3.2"></see>
    /// </summary>
    let ``C.2.3.2`` = _prefix "C.2.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4"></see>
    /// </summary>
    let ``C.2.4`` = _prefix "C.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4.0"></see>
    /// </summary>
    let ``C.2.4.0`` = _prefix "C.2.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4.1"></see>
    /// </summary>
    let ``C.2.4.1`` = _prefix "C.2.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4.2"></see>
    /// </summary>
    let ``C.2.4.2`` = _prefix "C.2.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4.3"></see>
    /// </summary>
    let ``C.2.4.3`` = _prefix "C.2.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5"></see>
    /// </summary>
    let ``C.2.5`` = _prefix "C.2.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.0"></see>
    /// </summary>
    let ``C.2.5.0`` = _prefix "C.2.5.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.1"></see>
    /// </summary>
    let ``C.2.5.1`` = _prefix "C.2.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.2"></see>
    /// </summary>
    let ``C.2.5.2`` = _prefix "C.2.5.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.3"></see>
    /// </summary>
    let ``C.2.5.3`` = _prefix "C.2.5.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.4"></see>
    /// </summary>
    let ``C.2.5.4`` = _prefix "C.2.5.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.5"></see>
    /// </summary>
    let ``C.2.5.5`` = _prefix "C.2.5.5"
    /// <summary>
    /// See also #C.2.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.6"></see></summary>
    let ``C.2.6`` = _prefix "C.2.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.6.0"></see>
    /// </summary>
    let ``C.2.6.0`` = _prefix "C.2.6.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.6.1"></see>
    /// </summary>
    let ``C.2.6.1`` = _prefix "C.2.6.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.2.m"></see>
    /// </summary>
    let ``C.2.m`` = _prefix "C.2.m"
    /// <summary>
    /// See also #J.7.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#C.3"></see></summary>
    let ``C.3`` = _prefix "C.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.3.0"></see>
    /// </summary>
    let ``C.3.0`` = _prefix "C.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.3.1"></see>
    /// </summary>
    let ``C.3.1`` = _prefix "C.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.3.2"></see>
    /// </summary>
    let ``C.3.2`` = _prefix "C.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.3.3"></see>
    /// </summary>
    let ``C.3.3`` = _prefix "C.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.3.4"></see>
    /// </summary>
    let ``C.3.4`` = _prefix "C.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.4"></see>
    /// </summary>
    let ``C.4`` = _prefix "C.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.4.0"></see>
    /// </summary>
    let ``C.4.0`` = _prefix "C.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.4.1"></see>
    /// </summary>
    let ``C.4.1`` = _prefix "C.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.4.2"></see>
    /// </summary>
    let ``C.4.2`` = _prefix "C.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.4.3"></see>
    /// </summary>
    let ``C.4.3`` = _prefix "C.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.4.4"></see>
    /// </summary>
    let ``C.4.4`` = _prefix "C.4.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.4.5"></see>
    /// </summary>
    let ``C.4.5`` = _prefix "C.4.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.5"></see>
    /// </summary>
    let ``C.5`` = _prefix "C.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.5.0"></see>
    /// </summary>
    let ``C.5.0`` = _prefix "C.5.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.5.1"></see>
    /// </summary>
    let ``C.5.1`` = _prefix "C.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.5.1.0"></see>
    /// </summary>
    let ``C.5.1.0`` = _prefix "C.5.1.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#C.5.2"></see></summary>
    let ``C.5.2`` = _prefix "C.5.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3"></see>
    /// </summary>
    let ``C.5.3`` = _prefix "C.5.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3.0"></see>
    /// </summary>
    let ``C.5.3.0`` = _prefix "C.5.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3.1"></see>
    /// </summary>
    let ``C.5.3.1`` = _prefix "C.5.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3.2"></see>
    /// </summary>
    let ``C.5.3.2`` = _prefix "C.5.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3.3"></see>
    /// </summary>
    let ``C.5.3.3`` = _prefix "C.5.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.5.4"></see>
    /// </summary>
    let ``C.5.4`` = _prefix "C.5.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.5.5"></see>
    /// </summary>
    let ``C.5.5`` = _prefix "C.5.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.5.m"></see>
    /// </summary>
    let ``C.5.m`` = _prefix "C.5.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#C.m"></see>
    /// </summary>
    let ``C.m`` = _prefix "C.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D"></see>
    /// </summary>
    let D = _prefix "D"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.0"></see>
    /// </summary>
    let ``D.0`` = _prefix "D.0"
    /// <summary>
    /// See also #E.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.1"></see></summary>
    let ``D.1`` = _prefix "D.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.1.0"></see>
    /// </summary>
    let ``D.1.0`` = _prefix "D.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.1.1"></see>
    /// </summary>
    let ``D.1.1`` = _prefix "D.1.1"
    /// <summary>
    /// See also #I.2.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.1.2"></see></summary>
    let ``D.1.2`` = _prefix "D.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.1.2.0"></see>
    /// </summary>
    let ``D.1.2.0`` = _prefix "D.1.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.1.2.1"></see>
    /// </summary>
    let ``D.1.2.1`` = _prefix "D.1.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.1.4"></see>
    /// </summary>
    let ``D.1.4`` = _prefix "D.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.1.5"></see>
    /// </summary>
    let ``D.1.5`` = _prefix "D.1.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.1.6"></see>
    /// </summary>
    let ``D.1.6`` = _prefix "D.1.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.1.7"></see>
    /// </summary>
    let ``D.1.7`` = _prefix "D.1.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.1.m"></see>
    /// </summary>
    let ``D.1.m`` = _prefix "D.1.m"
    /// <summary>
    /// See also #K.6.3.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2"></see></summary>
    let ``D.2`` = _prefix "D.2"
    /// <summary>
    /// See also #K.5.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.0"></see></summary>
    let ``D.2.0`` = _prefix "D.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.0.0"></see>
    /// </summary>
    let ``D.2.0.0`` = _prefix "D.2.0.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.0.1"></see>
    /// </summary>
    let ``D.2.0.1`` = _prefix "D.2.0.1"
    /// <summary>
    /// See also #D.3.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1"></see></summary>
    let ``D.2.1`` = _prefix "D.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1.0"></see>
    /// </summary>
    let ``D.2.1.0`` = _prefix "D.2.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1.1"></see>
    /// </summary>
    let ``D.2.1.1`` = _prefix "D.2.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1.2"></see>
    /// </summary>
    let ``D.2.1.2`` = _prefix "D.2.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1.3"></see>
    /// </summary>
    let ``D.2.1.3`` = _prefix "D.2.1.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998. See also #D.2.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.10"></see></summary>
    let ``D.2.10`` = _prefix "D.2.10"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.10.0"></see></summary>
    let ``D.2.10.0`` = _prefix "D.2.10.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.10.1"></see></summary>
    let ``D.2.10.1`` = _prefix "D.2.10.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11"></see>
    /// </summary>
    let ``D.2.11`` = _prefix "D.2.11"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.0"></see>
    /// </summary>
    let ``D.2.11.0`` = _prefix "D.2.11.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.1"></see>
    /// </summary>
    let ``D.2.11.1`` = _prefix "D.2.11.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.2"></see>
    /// </summary>
    let ``D.2.11.2`` = _prefix "D.2.11.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.3"></see>
    /// </summary>
    let ``D.2.11.3`` = _prefix "D.2.11.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.4"></see>
    /// </summary>
    let ``D.2.11.4`` = _prefix "D.2.11.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.12"></see>
    /// </summary>
    let ``D.2.12`` = _prefix "D.2.12"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.12.0"></see>
    /// </summary>
    let ``D.2.12.0`` = _prefix "D.2.12.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.12.1"></see>
    /// </summary>
    let ``D.2.12.1`` = _prefix "D.2.12.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.12.2"></see>
    /// </summary>
    let ``D.2.12.2`` = _prefix "D.2.12.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.13"></see>
    /// </summary>
    let ``D.2.13`` = _prefix "D.2.13"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.13.0"></see>
    /// </summary>
    let ``D.2.13.0`` = _prefix "D.2.13.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.13.1"></see>
    /// </summary>
    let ``D.2.13.1`` = _prefix "D.2.13.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.13.2"></see>
    /// </summary>
    let ``D.2.13.2`` = _prefix "D.2.13.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2"></see>
    /// </summary>
    let ``D.2.2`` = _prefix "D.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.0"></see>
    /// </summary>
    let ``D.2.2.0`` = _prefix "D.2.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.1"></see>
    /// </summary>
    let ``D.2.2.1`` = _prefix "D.2.2.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.10"></see></summary>
    let ``D.2.2.10`` = _prefix "D.2.2.10"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.11"></see></summary>
    let ``D.2.2.11`` = _prefix "D.2.2.11"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.12"></see>
    /// </summary>
    let ``D.2.2.12`` = _prefix "D.2.2.12"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.2"></see>
    /// </summary>
    let ``D.2.2.2`` = _prefix "D.2.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.3"></see>
    /// </summary>
    let ``D.2.2.3`` = _prefix "D.2.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.4"></see>
    /// </summary>
    let ``D.2.2.4`` = _prefix "D.2.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.5"></see>
    /// </summary>
    let ``D.2.2.5`` = _prefix "D.2.2.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.6"></see>
    /// </summary>
    let ``D.2.2.6`` = _prefix "D.2.2.6"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.7"></see></summary>
    let ``D.2.2.7`` = _prefix "D.2.2.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.8"></see>
    /// </summary>
    let ``D.2.2.8`` = _prefix "D.2.2.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.9"></see>
    /// </summary>
    let ``D.2.2.9`` = _prefix "D.2.2.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3"></see>
    /// </summary>
    let ``D.2.3`` = _prefix "D.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.0"></see>
    /// </summary>
    let ``D.2.3.0`` = _prefix "D.2.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.1"></see>
    /// </summary>
    let ``D.2.3.1`` = _prefix "D.2.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.2"></see>
    /// </summary>
    let ``D.2.3.2`` = _prefix "D.2.3.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.3"></see></summary>
    let ``D.2.3.3`` = _prefix "D.2.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.4"></see>
    /// </summary>
    let ``D.2.3.4`` = _prefix "D.2.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.5"></see>
    /// </summary>
    let ``D.2.3.5`` = _prefix "D.2.3.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.6"></see>
    /// </summary>
    let ``D.2.3.6`` = _prefix "D.2.3.6"
    /// <summary>
    /// See also #F.3.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4"></see></summary>
    let ``D.2.4`` = _prefix "D.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.0"></see>
    /// </summary>
    let ``D.2.4.0`` = _prefix "D.2.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.1"></see>
    /// </summary>
    let ``D.2.4.1`` = _prefix "D.2.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.2"></see>
    /// </summary>
    let ``D.2.4.2`` = _prefix "D.2.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.3"></see>
    /// </summary>
    let ``D.2.4.3`` = _prefix "D.2.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.4"></see>
    /// </summary>
    let ``D.2.4.4`` = _prefix "D.2.4.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.5"></see>
    /// </summary>
    let ``D.2.4.5`` = _prefix "D.2.4.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.6"></see>
    /// </summary>
    let ``D.2.4.6`` = _prefix "D.2.4.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.7"></see>
    /// </summary>
    let ``D.2.4.7`` = _prefix "D.2.4.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.8"></see>
    /// </summary>
    let ``D.2.4.8`` = _prefix "D.2.4.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5"></see>
    /// </summary>
    let ``D.2.5`` = _prefix "D.2.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.0"></see>
    /// </summary>
    let ``D.2.5.0`` = _prefix "D.2.5.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.1"></see>
    /// </summary>
    let ``D.2.5.1`` = _prefix "D.2.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.2"></see>
    /// </summary>
    let ``D.2.5.2`` = _prefix "D.2.5.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.3"></see>
    /// </summary>
    let ``D.2.5.3`` = _prefix "D.2.5.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.4"></see></summary>
    let ``D.2.5.4`` = _prefix "D.2.5.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.5"></see>
    /// </summary>
    let ``D.2.5.5`` = _prefix "D.2.5.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.6"></see>
    /// </summary>
    let ``D.2.5.6`` = _prefix "D.2.5.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.7"></see>
    /// </summary>
    let ``D.2.5.7`` = _prefix "D.2.5.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.8"></see>
    /// </summary>
    let ``D.2.5.8`` = _prefix "D.2.5.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.9"></see>
    /// </summary>
    let ``D.2.5.9`` = _prefix "D.2.5.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6"></see>
    /// </summary>
    let ``D.2.6`` = _prefix "D.2.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6.0"></see>
    /// </summary>
    let ``D.2.6.0`` = _prefix "D.2.6.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6.1"></see>
    /// </summary>
    let ``D.2.6.1`` = _prefix "D.2.6.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6.2"></see>
    /// </summary>
    let ``D.2.6.2`` = _prefix "D.2.6.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6.3"></see>
    /// </summary>
    let ``D.2.6.3`` = _prefix "D.2.6.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7"></see>
    /// </summary>
    let ``D.2.7`` = _prefix "D.2.7"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.0"></see></summary>
    let ``D.2.7.0`` = _prefix "D.2.7.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.1"></see>
    /// </summary>
    let ``D.2.7.1`` = _prefix "D.2.7.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.2"></see></summary>
    let ``D.2.7.2`` = _prefix "D.2.7.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.3"></see></summary>
    let ``D.2.7.3`` = _prefix "D.2.7.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.4"></see>
    /// </summary>
    let ``D.2.7.4`` = _prefix "D.2.7.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.5"></see>
    /// </summary>
    let ``D.2.7.5`` = _prefix "D.2.7.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.6"></see>
    /// </summary>
    let ``D.2.7.6`` = _prefix "D.2.7.6"
    /// <summary>
    /// See also #D.4.8.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8"></see></summary>
    let ``D.2.8`` = _prefix "D.2.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.0"></see>
    /// </summary>
    let ``D.2.8.0`` = _prefix "D.2.8.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.1"></see>
    /// </summary>
    let ``D.2.8.1`` = _prefix "D.2.8.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.2"></see>
    /// </summary>
    let ``D.2.8.2`` = _prefix "D.2.8.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.3"></see>
    /// </summary>
    let ``D.2.8.3`` = _prefix "D.2.8.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.4"></see></summary>
    let ``D.2.8.4`` = _prefix "D.2.8.4"
    /// <summary>
    /// See also #K.6.3, #K.6.4.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9"></see></summary>
    let ``D.2.9`` = _prefix "D.2.9"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.0"></see></summary>
    let ``D.2.9.0`` = _prefix "D.2.9.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.1"></see>
    /// </summary>
    let ``D.2.9.1`` = _prefix "D.2.9.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.2"></see>
    /// </summary>
    let ``D.2.9.2`` = _prefix "D.2.9.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.3"></see>
    /// </summary>
    let ``D.2.9.3`` = _prefix "D.2.9.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.4"></see>
    /// </summary>
    let ``D.2.9.4`` = _prefix "D.2.9.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.5"></see>
    /// </summary>
    let ``D.2.9.5`` = _prefix "D.2.9.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.6"></see>
    /// </summary>
    let ``D.2.9.6`` = _prefix "D.2.9.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.7"></see>
    /// </summary>
    let ``D.2.9.7`` = _prefix "D.2.9.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.8"></see>
    /// </summary>
    let ``D.2.9.8`` = _prefix "D.2.9.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.m"></see>
    /// </summary>
    let ``D.2.m`` = _prefix "D.2.m"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.m.0"></see></summary>
    let ``D.2.m.0`` = _prefix "D.2.m.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.2.m.1"></see></summary>
    let ``D.2.m.1`` = _prefix "D.2.m.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3"></see>
    /// </summary>
    let ``D.3`` = _prefix "D.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.0"></see>
    /// </summary>
    let ``D.3.0`` = _prefix "D.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.0.0"></see>
    /// </summary>
    let ``D.3.0.0`` = _prefix "D.3.0.0"
    /// <summary>
    /// See also #D.2.1, #F.3.1, #F.3.2, #F.4.2, #F.4.3.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.1"></see></summary>
    let ``D.3.1`` = _prefix "D.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.1.0"></see>
    /// </summary>
    let ``D.3.1.0`` = _prefix "D.3.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.1.1"></see>
    /// </summary>
    let ``D.3.1.1`` = _prefix "D.3.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2"></see>
    /// </summary>
    let ``D.3.2`` = _prefix "D.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.0"></see>
    /// </summary>
    let ``D.3.2.0`` = _prefix "D.3.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.1"></see>
    /// </summary>
    let ``D.3.2.1`` = _prefix "D.3.2.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.10"></see></summary>
    let ``D.3.2.10`` = _prefix "D.3.2.10"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.11"></see>
    /// </summary>
    let ``D.3.2.11`` = _prefix "D.3.2.11"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.12"></see>
    /// </summary>
    let ``D.3.2.12`` = _prefix "D.3.2.12"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.13"></see>
    /// </summary>
    let ``D.3.2.13`` = _prefix "D.3.2.13"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.2"></see>
    /// </summary>
    let ``D.3.2.2`` = _prefix "D.3.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.3"></see>
    /// </summary>
    let ``D.3.2.3`` = _prefix "D.3.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.4"></see>
    /// </summary>
    let ``D.3.2.4`` = _prefix "D.3.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.5"></see>
    /// </summary>
    let ``D.3.2.5`` = _prefix "D.3.2.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.6"></see>
    /// </summary>
    let ``D.3.2.6`` = _prefix "D.3.2.6"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.7"></see></summary>
    let ``D.3.2.7`` = _prefix "D.3.2.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.8"></see>
    /// </summary>
    let ``D.3.2.8`` = _prefix "D.3.2.8"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.9"></see></summary>
    let ``D.3.2.9`` = _prefix "D.3.2.9"
    /// <summary>
    /// See also #E.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3"></see></summary>
    let ``D.3.3`` = _prefix "D.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.0"></see>
    /// </summary>
    let ``D.3.3.0`` = _prefix "D.3.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.1"></see>
    /// </summary>
    let ``D.3.3.1`` = _prefix "D.3.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.10"></see>
    /// </summary>
    let ``D.3.3.10`` = _prefix "D.3.3.10"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.11"></see>
    /// </summary>
    let ``D.3.3.11`` = _prefix "D.3.3.11"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.12"></see>
    /// </summary>
    let ``D.3.3.12`` = _prefix "D.3.3.12"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.13"></see>
    /// </summary>
    let ``D.3.3.13`` = _prefix "D.3.3.13"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.14"></see>
    /// </summary>
    let ``D.3.3.14`` = _prefix "D.3.3.14"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.15"></see>
    /// </summary>
    let ``D.3.3.15`` = _prefix "D.3.3.15"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.2"></see>
    /// </summary>
    let ``D.3.3.2`` = _prefix "D.3.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.3"></see>
    /// </summary>
    let ``D.3.3.3`` = _prefix "D.3.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.4"></see>
    /// </summary>
    let ``D.3.3.4`` = _prefix "D.3.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.5"></see>
    /// </summary>
    let ``D.3.3.5`` = _prefix "D.3.3.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.6"></see>
    /// </summary>
    let ``D.3.3.6`` = _prefix "D.3.3.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.7"></see>
    /// </summary>
    let ``D.3.3.7`` = _prefix "D.3.3.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.8"></see>
    /// </summary>
    let ``D.3.3.8`` = _prefix "D.3.3.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.9"></see>
    /// </summary>
    let ``D.3.3.9`` = _prefix "D.3.3.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4"></see>
    /// </summary>
    let ``D.3.4`` = _prefix "D.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.0"></see>
    /// </summary>
    let ``D.3.4.0`` = _prefix "D.3.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.1"></see>
    /// </summary>
    let ``D.3.4.1`` = _prefix "D.3.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.10"></see>
    /// </summary>
    let ``D.3.4.10`` = _prefix "D.3.4.10"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.11"></see>
    /// </summary>
    let ``D.3.4.11`` = _prefix "D.3.4.11"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.2"></see>
    /// </summary>
    let ``D.3.4.2`` = _prefix "D.3.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.3"></see>
    /// </summary>
    let ``D.3.4.3`` = _prefix "D.3.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.4"></see>
    /// </summary>
    let ``D.3.4.4`` = _prefix "D.3.4.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.5"></see>
    /// </summary>
    let ``D.3.4.5`` = _prefix "D.3.4.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.6"></see>
    /// </summary>
    let ``D.3.4.6`` = _prefix "D.3.4.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.7"></see>
    /// </summary>
    let ``D.3.4.7`` = _prefix "D.3.4.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.8"></see>
    /// </summary>
    let ``D.3.4.8`` = _prefix "D.3.4.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.9"></see>
    /// </summary>
    let ``D.3.4.9`` = _prefix "D.3.4.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.3.m"></see>
    /// </summary>
    let ``D.3.m`` = _prefix "D.3.m"
    /// <summary>
    /// See also #C.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4"></see></summary>
    let ``D.4`` = _prefix "D.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.0"></see>
    /// </summary>
    let ``D.4.0`` = _prefix "D.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1"></see>
    /// </summary>
    let ``D.4.1`` = _prefix "D.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.0"></see>
    /// </summary>
    let ``D.4.1.0`` = _prefix "D.4.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.1"></see>
    /// </summary>
    let ``D.4.1.1`` = _prefix "D.4.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.2"></see>
    /// </summary>
    let ``D.4.1.2`` = _prefix "D.4.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.3"></see>
    /// </summary>
    let ``D.4.1.3`` = _prefix "D.4.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.4"></see>
    /// </summary>
    let ``D.4.1.4`` = _prefix "D.4.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.5"></see>
    /// </summary>
    let ``D.4.1.5`` = _prefix "D.4.1.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.6"></see>
    /// </summary>
    let ``D.4.1.6`` = _prefix "D.4.1.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2"></see>
    /// </summary>
    let ``D.4.2`` = _prefix "D.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.0"></see>
    /// </summary>
    let ``D.4.2.0`` = _prefix "D.4.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.1"></see>
    /// </summary>
    let ``D.4.2.1`` = _prefix "D.4.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.2"></see>
    /// </summary>
    let ``D.4.2.2`` = _prefix "D.4.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.3"></see>
    /// </summary>
    let ``D.4.2.3`` = _prefix "D.4.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.4"></see>
    /// </summary>
    let ``D.4.2.4`` = _prefix "D.4.2.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.5"></see></summary>
    let ``D.4.2.5`` = _prefix "D.4.2.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.6"></see>
    /// </summary>
    let ``D.4.2.6`` = _prefix "D.4.2.6"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.7"></see></summary>
    let ``D.4.2.7`` = _prefix "D.4.2.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.8"></see>
    /// </summary>
    let ``D.4.2.8`` = _prefix "D.4.2.8"
    /// <summary>
    /// See also #E.5.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3"></see></summary>
    let ``D.4.3`` = _prefix "D.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.0"></see>
    /// </summary>
    let ``D.4.3.0`` = _prefix "D.4.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.1"></see>
    /// </summary>
    let ``D.4.3.1`` = _prefix "D.4.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.2"></see>
    /// </summary>
    let ``D.4.3.2`` = _prefix "D.4.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.3"></see>
    /// </summary>
    let ``D.4.3.3`` = _prefix "D.4.3.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.4"></see></summary>
    let ``D.4.3.4`` = _prefix "D.4.3.4"
    /// <summary>
    /// See also #C.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4"></see></summary>
    let ``D.4.4`` = _prefix "D.4.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.0"></see>
    /// </summary>
    let ``D.4.4.0`` = _prefix "D.4.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.1"></see>
    /// </summary>
    let ``D.4.4.1`` = _prefix "D.4.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.2"></see>
    /// </summary>
    let ``D.4.4.2`` = _prefix "D.4.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.3"></see>
    /// </summary>
    let ``D.4.4.3`` = _prefix "D.4.4.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.4"></see></summary>
    let ``D.4.4.4`` = _prefix "D.4.4.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5"></see>
    /// </summary>
    let ``D.4.5`` = _prefix "D.4.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5.0"></see>
    /// </summary>
    let ``D.4.5.0`` = _prefix "D.4.5.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5.1"></see>
    /// </summary>
    let ``D.4.5.1`` = _prefix "D.4.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5.2"></see>
    /// </summary>
    let ``D.4.5.2`` = _prefix "D.4.5.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5.3"></see>
    /// </summary>
    let ``D.4.5.3`` = _prefix "D.4.5.3"
    /// <summary>
    /// See also #K.6.5.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6"></see></summary>
    let ``D.4.6`` = _prefix "D.4.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.0"></see>
    /// </summary>
    let ``D.4.6.0`` = _prefix "D.4.6.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.1"></see>
    /// </summary>
    let ``D.4.6.1`` = _prefix "D.4.6.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.2"></see>
    /// </summary>
    let ``D.4.6.2`` = _prefix "D.4.6.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.3"></see>
    /// </summary>
    let ``D.4.6.3`` = _prefix "D.4.6.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.4"></see>
    /// </summary>
    let ``D.4.6.4`` = _prefix "D.4.6.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.5"></see></summary>
    let ``D.4.6.5`` = _prefix "D.4.6.5"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.6"></see></summary>
    let ``D.4.6.6`` = _prefix "D.4.6.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7"></see>
    /// </summary>
    let ``D.4.7`` = _prefix "D.4.7"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.0"></see></summary>
    let ``D.4.7.0`` = _prefix "D.4.7.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.1"></see>
    /// </summary>
    let ``D.4.7.1`` = _prefix "D.4.7.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.2"></see></summary>
    let ``D.4.7.2`` = _prefix "D.4.7.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.3"></see>
    /// </summary>
    let ``D.4.7.3`` = _prefix "D.4.7.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.4"></see>
    /// </summary>
    let ``D.4.7.4`` = _prefix "D.4.7.4"
    /// <summary>
    /// See also #C.4, #D.2.8, #I.6.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8"></see></summary>
    let ``D.4.8`` = _prefix "D.4.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.0"></see>
    /// </summary>
    let ``D.4.8.0`` = _prefix "D.4.8.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.1"></see>
    /// </summary>
    let ``D.4.8.1`` = _prefix "D.4.8.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.2"></see>
    /// </summary>
    let ``D.4.8.2`` = _prefix "D.4.8.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.3"></see>
    /// </summary>
    let ``D.4.8.3`` = _prefix "D.4.8.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.4"></see>
    /// </summary>
    let ``D.4.8.4`` = _prefix "D.4.8.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.5"></see>
    /// </summary>
    let ``D.4.8.5`` = _prefix "D.4.8.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.6"></see>
    /// </summary>
    let ``D.4.8.6`` = _prefix "D.4.8.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9"></see>
    /// </summary>
    let ``D.4.9`` = _prefix "D.4.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9.0"></see>
    /// </summary>
    let ``D.4.9.0`` = _prefix "D.4.9.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9.1"></see></summary>
    let ``D.4.9.1`` = _prefix "D.4.9.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9.2"></see></summary>
    let ``D.4.9.2`` = _prefix "D.4.9.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9.3"></see>
    /// </summary>
    let ``D.4.9.3`` = _prefix "D.4.9.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.4.m"></see>
    /// </summary>
    let ``D.4.m`` = _prefix "D.4.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#D.m"></see>
    /// </summary>
    let ``D.m`` = _prefix "D.m"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#D.m.0"></see></summary>
    let ``D.m.0`` = _prefix "D.m.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E"></see>
    /// </summary>
    let E = _prefix "E"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.0"></see>
    /// </summary>
    let ``E.0`` = _prefix "E.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.1"></see>
    /// </summary>
    let ``E.1`` = _prefix "E.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.1.0"></see>
    /// </summary>
    let ``E.1.0`` = _prefix "E.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.1.1"></see>
    /// </summary>
    let ``E.1.1`` = _prefix "E.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.1.2"></see>
    /// </summary>
    let ``E.1.2`` = _prefix "E.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.1.3"></see>
    /// </summary>
    let ``E.1.3`` = _prefix "E.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.1.4"></see>
    /// </summary>
    let ``E.1.4`` = _prefix "E.1.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#E.1.5"></see></summary>
    let ``E.1.5`` = _prefix "E.1.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.1.6"></see>
    /// </summary>
    let ``E.1.6`` = _prefix "E.1.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.2"></see>
    /// </summary>
    let ``E.2`` = _prefix "E.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#E.2.0"></see></summary>
    let ``E.2.0`` = _prefix "E.2.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#E.2.1"></see></summary>
    let ``E.2.1`` = _prefix "E.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.2.2"></see>
    /// </summary>
    let ``E.2.2`` = _prefix "E.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.2.3"></see>
    /// </summary>
    let ``E.2.3`` = _prefix "E.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.2.4"></see>
    /// </summary>
    let ``E.2.4`` = _prefix "E.2.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#E.2.5"></see></summary>
    let ``E.2.5`` = _prefix "E.2.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.3"></see>
    /// </summary>
    let ``E.3`` = _prefix "E.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.3.0"></see>
    /// </summary>
    let ``E.3.0`` = _prefix "E.3.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#E.3.1"></see></summary>
    let ``E.3.1`` = _prefix "E.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.3.2"></see>
    /// </summary>
    let ``E.3.2`` = _prefix "E.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.3.3"></see>
    /// </summary>
    let ``E.3.3`` = _prefix "E.3.3"
    /// <summary>
    /// See also #H.1.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#E.4"></see></summary>
    let ``E.4`` = _prefix "E.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.4.0"></see>
    /// </summary>
    let ``E.4.0`` = _prefix "E.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.4.1"></see>
    /// </summary>
    let ``E.4.1`` = _prefix "E.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.4.2"></see>
    /// </summary>
    let ``E.4.2`` = _prefix "E.4.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#E.4.3"></see></summary>
    let ``E.4.3`` = _prefix "E.4.3"
    /// <summary>
    /// See also #D.4.3, #F.2.2, #H.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#E.5"></see></summary>
    let ``E.5`` = _prefix "E.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.5.0"></see>
    /// </summary>
    let ``E.5.0`` = _prefix "E.5.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#E.5.1"></see></summary>
    let ``E.5.1`` = _prefix "E.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.5.2"></see>
    /// </summary>
    let ``E.5.2`` = _prefix "E.5.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.5.3"></see>
    /// </summary>
    let ``E.5.3`` = _prefix "E.5.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#E.m"></see>
    /// </summary>
    let ``E.m`` = _prefix "E.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F"></see>
    /// </summary>
    let F = _prefix "F"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.0"></see>
    /// </summary>
    let ``F.0`` = _prefix "F.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1"></see>
    /// </summary>
    let ``F.1`` = _prefix "F.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.0"></see>
    /// </summary>
    let ``F.1.0`` = _prefix "F.1.0"
    /// <summary>
    /// See also #F.4.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1"></see></summary>
    let ``F.1.1`` = _prefix "F.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.0"></see>
    /// </summary>
    let ``F.1.1.0`` = _prefix "F.1.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.1"></see>
    /// </summary>
    let ``F.1.1.1`` = _prefix "F.1.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.2"></see>
    /// </summary>
    let ``F.1.1.2`` = _prefix "F.1.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.3"></see>
    /// </summary>
    let ``F.1.1.3`` = _prefix "F.1.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.4"></see>
    /// </summary>
    let ``F.1.1.4`` = _prefix "F.1.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.5"></see>
    /// </summary>
    let ``F.1.1.5`` = _prefix "F.1.1.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2"></see>
    /// </summary>
    let ``F.1.2`` = _prefix "F.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.0"></see>
    /// </summary>
    let ``F.1.2.0`` = _prefix "F.1.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.1"></see>
    /// </summary>
    let ``F.1.2.1`` = _prefix "F.1.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.2"></see>
    /// </summary>
    let ``F.1.2.2`` = _prefix "F.1.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.3"></see>
    /// </summary>
    let ``F.1.2.3`` = _prefix "F.1.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.4"></see>
    /// </summary>
    let ``F.1.2.4`` = _prefix "F.1.2.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.5"></see></summary>
    let ``F.1.2.5`` = _prefix "F.1.2.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.6"></see>
    /// </summary>
    let ``F.1.2.6`` = _prefix "F.1.2.6"
    /// <summary>
    /// See also #F.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3"></see></summary>
    let ``F.1.3`` = _prefix "F.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.0"></see>
    /// </summary>
    let ``F.1.3.0`` = _prefix "F.1.3.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.1"></see></summary>
    let ``F.1.3.1`` = _prefix "F.1.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.2"></see>
    /// </summary>
    let ``F.1.3.2`` = _prefix "F.1.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.3"></see>
    /// </summary>
    let ``F.1.3.3`` = _prefix "F.1.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.4"></see>
    /// </summary>
    let ``F.1.3.4`` = _prefix "F.1.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.1.m"></see>
    /// </summary>
    let ``F.1.m`` = _prefix "F.1.m"
    /// <summary>
    /// See also #B.6, #B.7, #F.1.3.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2"></see></summary>
    let ``F.2`` = _prefix "F.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2.0"></see>
    /// </summary>
    let ``F.2.0`` = _prefix "F.2.0"
    /// <summary>
    /// See also #G.1, #G.4, #I.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1"></see></summary>
    let ``F.2.1`` = _prefix "F.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.0"></see>
    /// </summary>
    let ``F.2.1.0`` = _prefix "F.2.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.1"></see>
    /// </summary>
    let ``F.2.1.1`` = _prefix "F.2.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.2"></see>
    /// </summary>
    let ``F.2.1.2`` = _prefix "F.2.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.3"></see>
    /// </summary>
    let ``F.2.1.3`` = _prefix "F.2.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.4"></see>
    /// </summary>
    let ``F.2.1.4`` = _prefix "F.2.1.4"
    /// <summary>
    /// See also #E.2, #E.3, #E.4, #E.5, #G.2, #H.2, #H.3.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2"></see></summary>
    let ``F.2.2`` = _prefix "F.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.0"></see>
    /// </summary>
    let ``F.2.2.0`` = _prefix "F.2.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.1"></see>
    /// </summary>
    let ``F.2.2.1`` = _prefix "F.2.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.2"></see>
    /// </summary>
    let ``F.2.2.2`` = _prefix "F.2.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.3"></see>
    /// </summary>
    let ``F.2.2.3`` = _prefix "F.2.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.4"></see>
    /// </summary>
    let ``F.2.2.4`` = _prefix "F.2.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.5"></see>
    /// </summary>
    let ``F.2.2.5`` = _prefix "F.2.2.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.6"></see>
    /// </summary>
    let ``F.2.2.6`` = _prefix "F.2.2.6"
    /// <summary>
    /// See also #F.1.3.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#F.2.3"></see></summary>
    let ``F.2.3`` = _prefix "F.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3"></see>
    /// </summary>
    let ``F.3`` = _prefix "F.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.0"></see>
    /// </summary>
    let ``F.3.0`` = _prefix "F.3.0"
    /// <summary>
    /// See also #D.2.1, #D.2.4, #D.3.1, #E.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1"></see></summary>
    let ``F.3.1`` = _prefix "F.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.0"></see>
    /// </summary>
    let ``F.3.1.0`` = _prefix "F.3.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.1"></see>
    /// </summary>
    let ``F.3.1.1`` = _prefix "F.3.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.2"></see>
    /// </summary>
    let ``F.3.1.2`` = _prefix "F.3.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.3"></see>
    /// </summary>
    let ``F.3.1.3`` = _prefix "F.3.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.4"></see>
    /// </summary>
    let ``F.3.1.4`` = _prefix "F.3.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.5"></see>
    /// </summary>
    let ``F.3.1.5`` = _prefix "F.3.1.5"
    /// <summary>
    /// See also #D.3.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2"></see></summary>
    let ``F.3.2`` = _prefix "F.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.0"></see>
    /// </summary>
    let ``F.3.2.0`` = _prefix "F.3.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.1"></see>
    /// </summary>
    let ``F.3.2.1`` = _prefix "F.3.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.2"></see>
    /// </summary>
    let ``F.3.2.2`` = _prefix "F.3.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.3"></see>
    /// </summary>
    let ``F.3.2.3`` = _prefix "F.3.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.4"></see>
    /// </summary>
    let ``F.3.2.4`` = _prefix "F.3.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.5"></see>
    /// </summary>
    let ``F.3.2.5`` = _prefix "F.3.2.5"
    /// <summary>
    /// See also #D.3.2, #D.3.3.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3"></see></summary>
    let ``F.3.3`` = _prefix "F.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.0"></see>
    /// </summary>
    let ``F.3.3.0`` = _prefix "F.3.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.1"></see>
    /// </summary>
    let ``F.3.3.1`` = _prefix "F.3.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.2"></see>
    /// </summary>
    let ``F.3.3.2`` = _prefix "F.3.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.3"></see>
    /// </summary>
    let ``F.3.3.3`` = _prefix "F.3.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.4"></see>
    /// </summary>
    let ``F.3.3.4`` = _prefix "F.3.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.3.m"></see>
    /// </summary>
    let ``F.3.m`` = _prefix "F.3.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4"></see>
    /// </summary>
    let ``F.4`` = _prefix "F.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.0"></see>
    /// </summary>
    let ``F.4.0`` = _prefix "F.4.0"
    /// <summary>
    /// See also #F.1.1, #I.2.2, #I.2.3, #I.2.4.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1"></see></summary>
    let ``F.4.1`` = _prefix "F.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.0"></see>
    /// </summary>
    let ``F.4.1.0`` = _prefix "F.4.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.1"></see>
    /// </summary>
    let ``F.4.1.1`` = _prefix "F.4.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.10"></see>
    /// </summary>
    let ``F.4.1.10`` = _prefix "F.4.1.10"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.2"></see>
    /// </summary>
    let ``F.4.1.2`` = _prefix "F.4.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.3"></see>
    /// </summary>
    let ``F.4.1.3`` = _prefix "F.4.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.4"></see>
    /// </summary>
    let ``F.4.1.4`` = _prefix "F.4.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.5"></see>
    /// </summary>
    let ``F.4.1.5`` = _prefix "F.4.1.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.6"></see>
    /// </summary>
    let ``F.4.1.6`` = _prefix "F.4.1.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.7"></see>
    /// </summary>
    let ``F.4.1.7`` = _prefix "F.4.1.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.8"></see>
    /// </summary>
    let ``F.4.1.8`` = _prefix "F.4.1.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.9"></see>
    /// </summary>
    let ``F.4.1.9`` = _prefix "F.4.1.9"
    /// <summary>
    /// See also #D.3.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2"></see></summary>
    let ``F.4.2`` = _prefix "F.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.0"></see>
    /// </summary>
    let ``F.4.2.0`` = _prefix "F.4.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.1"></see>
    /// </summary>
    let ``F.4.2.1`` = _prefix "F.4.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.2"></see>
    /// </summary>
    let ``F.4.2.2`` = _prefix "F.4.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.3"></see>
    /// </summary>
    let ``F.4.2.3`` = _prefix "F.4.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.4"></see>
    /// </summary>
    let ``F.4.2.4`` = _prefix "F.4.2.4"
    /// <summary>
    /// See also #D.3.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3"></see></summary>
    let ``F.4.3`` = _prefix "F.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.0"></see>
    /// </summary>
    let ``F.4.3.0`` = _prefix "F.4.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.1"></see>
    /// </summary>
    let ``F.4.3.1`` = _prefix "F.4.3.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.2"></see></summary>
    let ``F.4.3.2`` = _prefix "F.4.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.3"></see>
    /// </summary>
    let ``F.4.3.3`` = _prefix "F.4.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.4"></see>
    /// </summary>
    let ``F.4.3.4`` = _prefix "F.4.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.4.m"></see>
    /// </summary>
    let ``F.4.m`` = _prefix "F.4.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#F.m"></see>
    /// </summary>
    let ``F.m`` = _prefix "F.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G"></see>
    /// </summary>
    let G = _prefix "G"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.0"></see>
    /// </summary>
    let ``G.0`` = _prefix "G.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1"></see>
    /// </summary>
    let ``G.1`` = _prefix "G.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0"></see>
    /// </summary>
    let ``G.1.0`` = _prefix "G.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.0"></see>
    /// </summary>
    let ``G.1.0.0`` = _prefix "G.1.0.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.1"></see>
    /// </summary>
    let ``G.1.0.1`` = _prefix "G.1.0.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.2"></see>
    /// </summary>
    let ``G.1.0.2`` = _prefix "G.1.0.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.3"></see>
    /// </summary>
    let ``G.1.0.3`` = _prefix "G.1.0.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.4"></see>
    /// </summary>
    let ``G.1.0.4`` = _prefix "G.1.0.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.5"></see>
    /// </summary>
    let ``G.1.0.5`` = _prefix "G.1.0.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.6"></see>
    /// </summary>
    let ``G.1.0.6`` = _prefix "G.1.0.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.7"></see>
    /// </summary>
    let ``G.1.0.7`` = _prefix "G.1.0.7"
    /// <summary>
    /// See also #I.3.5, #I.3.7.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1"></see></summary>
    let ``G.1.1`` = _prefix "G.1.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.0"></see></summary>
    let ``G.1.1.0`` = _prefix "G.1.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.1"></see>
    /// </summary>
    let ``G.1.1.1`` = _prefix "G.1.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.2"></see>
    /// </summary>
    let ``G.1.1.2`` = _prefix "G.1.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.3"></see>
    /// </summary>
    let ``G.1.1.3`` = _prefix "G.1.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.4"></see>
    /// </summary>
    let ``G.1.1.4`` = _prefix "G.1.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.10"></see>
    /// </summary>
    let ``G.1.10`` = _prefix "G.1.10"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2"></see>
    /// </summary>
    let ``G.1.2`` = _prefix "G.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.0"></see>
    /// </summary>
    let ``G.1.2.0`` = _prefix "G.1.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.1"></see>
    /// </summary>
    let ``G.1.2.1`` = _prefix "G.1.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.10"></see>
    /// </summary>
    let ``G.1.2.10`` = _prefix "G.1.2.10"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.11"></see>
    /// </summary>
    let ``G.1.2.11`` = _prefix "G.1.2.11"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.2"></see>
    /// </summary>
    let ``G.1.2.2`` = _prefix "G.1.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.3"></see>
    /// </summary>
    let ``G.1.2.3`` = _prefix "G.1.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.4"></see>
    /// </summary>
    let ``G.1.2.4`` = _prefix "G.1.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.5"></see>
    /// </summary>
    let ``G.1.2.5`` = _prefix "G.1.2.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.6"></see>
    /// </summary>
    let ``G.1.2.6`` = _prefix "G.1.2.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.7"></see>
    /// </summary>
    let ``G.1.2.7`` = _prefix "G.1.2.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.8"></see>
    /// </summary>
    let ``G.1.2.8`` = _prefix "G.1.2.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.9"></see>
    /// </summary>
    let ``G.1.2.9`` = _prefix "G.1.2.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3"></see>
    /// </summary>
    let ``G.1.3`` = _prefix "G.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.0"></see>
    /// </summary>
    let ``G.1.3.0`` = _prefix "G.1.3.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.1"></see></summary>
    let ``G.1.3.1`` = _prefix "G.1.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.2"></see>
    /// </summary>
    let ``G.1.3.2`` = _prefix "G.1.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.3"></see>
    /// </summary>
    let ``G.1.3.3`` = _prefix "G.1.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.4"></see>
    /// </summary>
    let ``G.1.3.4`` = _prefix "G.1.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.5"></see>
    /// </summary>
    let ``G.1.3.5`` = _prefix "G.1.3.5"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.6"></see></summary>
    let ``G.1.3.6`` = _prefix "G.1.3.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.7"></see>
    /// </summary>
    let ``G.1.3.7`` = _prefix "G.1.3.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.8"></see>
    /// </summary>
    let ``G.1.3.8`` = _prefix "G.1.3.8"
    /// <summary>
    /// See also #F.2.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4"></see></summary>
    let ``G.1.4`` = _prefix "G.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.0"></see>
    /// </summary>
    let ``G.1.4.0`` = _prefix "G.1.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.1"></see>
    /// </summary>
    let ``G.1.4.1`` = _prefix "G.1.4.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.2"></see></summary>
    let ``G.1.4.2`` = _prefix "G.1.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.3"></see>
    /// </summary>
    let ``G.1.4.3`` = _prefix "G.1.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.4"></see>
    /// </summary>
    let ``G.1.4.4`` = _prefix "G.1.4.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.5"></see>
    /// </summary>
    let ``G.1.4.5`` = _prefix "G.1.4.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.6"></see>
    /// </summary>
    let ``G.1.4.6`` = _prefix "G.1.4.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.7"></see>
    /// </summary>
    let ``G.1.4.7`` = _prefix "G.1.4.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5"></see>
    /// </summary>
    let ``G.1.5`` = _prefix "G.1.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.0"></see>
    /// </summary>
    let ``G.1.5.0`` = _prefix "G.1.5.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.1"></see>
    /// </summary>
    let ``G.1.5.1`` = _prefix "G.1.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.2"></see>
    /// </summary>
    let ``G.1.5.2`` = _prefix "G.1.5.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.3"></see>
    /// </summary>
    let ``G.1.5.3`` = _prefix "G.1.5.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.4"></see>
    /// </summary>
    let ``G.1.5.4`` = _prefix "G.1.5.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.5"></see>
    /// </summary>
    let ``G.1.5.5`` = _prefix "G.1.5.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6"></see>
    /// </summary>
    let ``G.1.6`` = _prefix "G.1.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.0"></see>
    /// </summary>
    let ``G.1.6.0`` = _prefix "G.1.6.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.1"></see>
    /// </summary>
    let ``G.1.6.1`` = _prefix "G.1.6.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.10"></see>
    /// </summary>
    let ``G.1.6.10`` = _prefix "G.1.6.10"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.11"></see>
    /// </summary>
    let ``G.1.6.11`` = _prefix "G.1.6.11"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.2"></see>
    /// </summary>
    let ``G.1.6.2`` = _prefix "G.1.6.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.3"></see>
    /// </summary>
    let ``G.1.6.3`` = _prefix "G.1.6.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.4"></see>
    /// </summary>
    let ``G.1.6.4`` = _prefix "G.1.6.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.5"></see>
    /// </summary>
    let ``G.1.6.5`` = _prefix "G.1.6.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.6"></see>
    /// </summary>
    let ``G.1.6.6`` = _prefix "G.1.6.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.7"></see>
    /// </summary>
    let ``G.1.6.7`` = _prefix "G.1.6.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.8"></see>
    /// </summary>
    let ``G.1.6.8`` = _prefix "G.1.6.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.9"></see>
    /// </summary>
    let ``G.1.6.9`` = _prefix "G.1.6.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7"></see>
    /// </summary>
    let ``G.1.7`` = _prefix "G.1.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.0"></see>
    /// </summary>
    let ``G.1.7.0`` = _prefix "G.1.7.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.1"></see>
    /// </summary>
    let ``G.1.7.1`` = _prefix "G.1.7.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.2"></see>
    /// </summary>
    let ``G.1.7.2`` = _prefix "G.1.7.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.3"></see>
    /// </summary>
    let ``G.1.7.3`` = _prefix "G.1.7.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.4"></see>
    /// </summary>
    let ``G.1.7.4`` = _prefix "G.1.7.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.5"></see>
    /// </summary>
    let ``G.1.7.5`` = _prefix "G.1.7.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.6"></see>
    /// </summary>
    let ``G.1.7.6`` = _prefix "G.1.7.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.7"></see>
    /// </summary>
    let ``G.1.7.7`` = _prefix "G.1.7.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.8"></see>
    /// </summary>
    let ``G.1.7.8`` = _prefix "G.1.7.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.9"></see>
    /// </summary>
    let ``G.1.7.9`` = _prefix "G.1.7.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8"></see>
    /// </summary>
    let ``G.1.8`` = _prefix "G.1.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.0"></see>
    /// </summary>
    let ``G.1.8.0`` = _prefix "G.1.8.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.1"></see>
    /// </summary>
    let ``G.1.8.1`` = _prefix "G.1.8.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.10"></see>
    /// </summary>
    let ``G.1.8.10`` = _prefix "G.1.8.10"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.11"></see>
    /// </summary>
    let ``G.1.8.11`` = _prefix "G.1.8.11"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.2"></see>
    /// </summary>
    let ``G.1.8.2`` = _prefix "G.1.8.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.3"></see>
    /// </summary>
    let ``G.1.8.3`` = _prefix "G.1.8.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.4"></see>
    /// </summary>
    let ``G.1.8.4`` = _prefix "G.1.8.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.5"></see>
    /// </summary>
    let ``G.1.8.5`` = _prefix "G.1.8.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.6"></see>
    /// </summary>
    let ``G.1.8.6`` = _prefix "G.1.8.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.7"></see>
    /// </summary>
    let ``G.1.8.7`` = _prefix "G.1.8.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.8"></see>
    /// </summary>
    let ``G.1.8.8`` = _prefix "G.1.8.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.9"></see>
    /// </summary>
    let ``G.1.8.9`` = _prefix "G.1.8.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9"></see>
    /// </summary>
    let ``G.1.9`` = _prefix "G.1.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9.0"></see>
    /// </summary>
    let ``G.1.9.0`` = _prefix "G.1.9.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9.1"></see>
    /// </summary>
    let ``G.1.9.1`` = _prefix "G.1.9.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9.2"></see>
    /// </summary>
    let ``G.1.9.2`` = _prefix "G.1.9.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9.3"></see>
    /// </summary>
    let ``G.1.9.3`` = _prefix "G.1.9.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.1.m"></see>
    /// </summary>
    let ``G.1.m`` = _prefix "G.1.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2"></see>
    /// </summary>
    let ``G.2`` = _prefix "G.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2.0"></see>
    /// </summary>
    let ``G.2.0`` = _prefix "G.2.0"
    /// <summary>
    /// See also #F.2.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1"></see></summary>
    let ``G.2.1`` = _prefix "G.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.0"></see>
    /// </summary>
    let ``G.2.1.0`` = _prefix "G.2.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.1"></see>
    /// </summary>
    let ``G.2.1.1`` = _prefix "G.2.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.2"></see>
    /// </summary>
    let ``G.2.1.2`` = _prefix "G.2.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.3"></see>
    /// </summary>
    let ``G.2.1.3`` = _prefix "G.2.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.4"></see>
    /// </summary>
    let ``G.2.1.4`` = _prefix "G.2.1.4"
    /// <summary>
    /// See also #F.2.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2"></see></summary>
    let ``G.2.2`` = _prefix "G.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.0"></see>
    /// </summary>
    let ``G.2.2.0`` = _prefix "G.2.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.1"></see>
    /// </summary>
    let ``G.2.2.1`` = _prefix "G.2.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.2"></see>
    /// </summary>
    let ``G.2.2.2`` = _prefix "G.2.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.3"></see>
    /// </summary>
    let ``G.2.2.3`` = _prefix "G.2.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.4"></see>
    /// </summary>
    let ``G.2.2.4`` = _prefix "G.2.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.5"></see>
    /// </summary>
    let ``G.2.2.5`` = _prefix "G.2.2.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2.3"></see>
    /// </summary>
    let ``G.2.3`` = _prefix "G.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.2.m"></see>
    /// </summary>
    let ``G.2.m`` = _prefix "G.2.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3"></see>
    /// </summary>
    let ``G.3`` = _prefix "G.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.0"></see>
    /// </summary>
    let ``G.3.0`` = _prefix "G.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.1"></see>
    /// </summary>
    let ``G.3.1`` = _prefix "G.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.10"></see>
    /// </summary>
    let ``G.3.10`` = _prefix "G.3.10"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.11"></see>
    /// </summary>
    let ``G.3.11`` = _prefix "G.3.11"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.12"></see>
    /// </summary>
    let ``G.3.12`` = _prefix "G.3.12"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.13"></see>
    /// </summary>
    let ``G.3.13`` = _prefix "G.3.13"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.14"></see>
    /// </summary>
    let ``G.3.14`` = _prefix "G.3.14"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.15"></see>
    /// </summary>
    let ``G.3.15`` = _prefix "G.3.15"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.16"></see>
    /// </summary>
    let ``G.3.16`` = _prefix "G.3.16"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.17"></see>
    /// </summary>
    let ``G.3.17`` = _prefix "G.3.17"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.2"></see>
    /// </summary>
    let ``G.3.2`` = _prefix "G.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.3"></see>
    /// </summary>
    let ``G.3.3`` = _prefix "G.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.4"></see>
    /// </summary>
    let ``G.3.4`` = _prefix "G.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.5"></see>
    /// </summary>
    let ``G.3.5`` = _prefix "G.3.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.6"></see>
    /// </summary>
    let ``G.3.6`` = _prefix "G.3.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.7"></see>
    /// </summary>
    let ``G.3.7`` = _prefix "G.3.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.8"></see>
    /// </summary>
    let ``G.3.8`` = _prefix "G.3.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.3.9"></see>
    /// </summary>
    let ``G.3.9`` = _prefix "G.3.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.4"></see>
    /// </summary>
    let ``G.4`` = _prefix "G.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.4.0"></see>
    /// </summary>
    let ``G.4.0`` = _prefix "G.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.4.1"></see>
    /// </summary>
    let ``G.4.1`` = _prefix "G.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.4.2"></see>
    /// </summary>
    let ``G.4.2`` = _prefix "G.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.4.3"></see>
    /// </summary>
    let ``G.4.3`` = _prefix "G.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.4.4"></see>
    /// </summary>
    let ``G.4.4`` = _prefix "G.4.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#G.4.5"></see></summary>
    let ``G.4.5`` = _prefix "G.4.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.4.6"></see>
    /// </summary>
    let ``G.4.6`` = _prefix "G.4.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.4.7"></see>
    /// </summary>
    let ``G.4.7`` = _prefix "G.4.7"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#G.4.8"></see></summary>
    let ``G.4.8`` = _prefix "G.4.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#G.m"></see>
    /// </summary>
    let ``G.m`` = _prefix "G.m"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#G.m.0"></see></summary>
    let ``G.m.0`` = _prefix "G.m.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H"></see>
    /// </summary>
    let H = _prefix "H"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.0"></see>
    /// </summary>
    let ``H.0`` = _prefix "H.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.1"></see>
    /// </summary>
    let ``H.1`` = _prefix "H.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.1.0"></see>
    /// </summary>
    let ``H.1.0`` = _prefix "H.1.0"
    /// <summary>
    /// See also #E.4.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#H.1.1"></see></summary>
    let ``H.1.1`` = _prefix "H.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.1.1.0"></see>
    /// </summary>
    let ``H.1.1.0`` = _prefix "H.1.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.1.1.1"></see>
    /// </summary>
    let ``H.1.1.1`` = _prefix "H.1.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.1.1.2"></see>
    /// </summary>
    let ``H.1.1.2`` = _prefix "H.1.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.1.2"></see>
    /// </summary>
    let ``H.1.2`` = _prefix "H.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.1.2.0"></see>
    /// </summary>
    let ``H.1.2.0`` = _prefix "H.1.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.1.2.1"></see>
    /// </summary>
    let ``H.1.2.1`` = _prefix "H.1.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.1.2.2"></see>
    /// </summary>
    let ``H.1.2.2`` = _prefix "H.1.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.1.m"></see>
    /// </summary>
    let ``H.1.m`` = _prefix "H.1.m"
    /// <summary>
    /// See also #E.5.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2"></see></summary>
    let ``H.2`` = _prefix "H.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.0"></see>
    /// </summary>
    let ``H.2.0`` = _prefix "H.2.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.0.0"></see></summary>
    let ``H.2.0.0`` = _prefix "H.2.0.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.1"></see>
    /// </summary>
    let ``H.2.1`` = _prefix "H.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.1.0"></see>
    /// </summary>
    let ``H.2.1.0`` = _prefix "H.2.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.1.1"></see>
    /// </summary>
    let ``H.2.1.1`` = _prefix "H.2.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.1.2"></see>
    /// </summary>
    let ``H.2.1.2`` = _prefix "H.2.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.2"></see>
    /// </summary>
    let ``H.2.2`` = _prefix "H.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.2.0"></see>
    /// </summary>
    let ``H.2.2.0`` = _prefix "H.2.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.2.1"></see>
    /// </summary>
    let ``H.2.2.1`` = _prefix "H.2.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.2.2"></see>
    /// </summary>
    let ``H.2.2.2`` = _prefix "H.2.2.2"
    /// <summary>
    /// See also #D.3.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3"></see></summary>
    let ``H.2.3`` = _prefix "H.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.0"></see>
    /// </summary>
    let ``H.2.3.0`` = _prefix "H.2.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.1"></see>
    /// </summary>
    let ``H.2.3.1`` = _prefix "H.2.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.2"></see>
    /// </summary>
    let ``H.2.3.2`` = _prefix "H.2.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.3"></see>
    /// </summary>
    let ``H.2.3.3`` = _prefix "H.2.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.4"></see>
    /// </summary>
    let ``H.2.3.4`` = _prefix "H.2.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4"></see>
    /// </summary>
    let ``H.2.4`` = _prefix "H.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.0"></see>
    /// </summary>
    let ``H.2.4.0`` = _prefix "H.2.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.1"></see>
    /// </summary>
    let ``H.2.4.1`` = _prefix "H.2.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.2"></see>
    /// </summary>
    let ``H.2.4.2`` = _prefix "H.2.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.3"></see>
    /// </summary>
    let ``H.2.4.3`` = _prefix "H.2.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.4"></see>
    /// </summary>
    let ``H.2.4.4`` = _prefix "H.2.4.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.5"></see>
    /// </summary>
    let ``H.2.4.5`` = _prefix "H.2.4.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.6"></see>
    /// </summary>
    let ``H.2.4.6`` = _prefix "H.2.4.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.7"></see>
    /// </summary>
    let ``H.2.4.7`` = _prefix "H.2.4.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.8"></see>
    /// </summary>
    let ``H.2.4.8`` = _prefix "H.2.4.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.9"></see>
    /// </summary>
    let ``H.2.4.9`` = _prefix "H.2.4.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.5"></see>
    /// </summary>
    let ``H.2.5`` = _prefix "H.2.5"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.5.0"></see></summary>
    let ``H.2.5.0`` = _prefix "H.2.5.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.5.1"></see></summary>
    let ``H.2.5.1`` = _prefix "H.2.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.6"></see>
    /// </summary>
    let ``H.2.6`` = _prefix "H.2.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7"></see>
    /// </summary>
    let ``H.2.7`` = _prefix "H.2.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7.0"></see>
    /// </summary>
    let ``H.2.7.0`` = _prefix "H.2.7.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7.1"></see>
    /// </summary>
    let ``H.2.7.1`` = _prefix "H.2.7.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7.2"></see>
    /// </summary>
    let ``H.2.7.2`` = _prefix "H.2.7.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7.3"></see>
    /// </summary>
    let ``H.2.7.3`` = _prefix "H.2.7.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8"></see>
    /// </summary>
    let ``H.2.8`` = _prefix "H.2.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.0"></see>
    /// </summary>
    let ``H.2.8.0`` = _prefix "H.2.8.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.1"></see>
    /// </summary>
    let ``H.2.8.1`` = _prefix "H.2.8.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.2"></see>
    /// </summary>
    let ``H.2.8.2`` = _prefix "H.2.8.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.3"></see>
    /// </summary>
    let ``H.2.8.3`` = _prefix "H.2.8.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.4"></see>
    /// </summary>
    let ``H.2.8.4`` = _prefix "H.2.8.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.2.m"></see>
    /// </summary>
    let ``H.2.m`` = _prefix "H.2.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3"></see>
    /// </summary>
    let ``H.3`` = _prefix "H.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.0"></see>
    /// </summary>
    let ``H.3.0`` = _prefix "H.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1"></see>
    /// </summary>
    let ``H.3.1`` = _prefix "H.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.0"></see>
    /// </summary>
    let ``H.3.1.0`` = _prefix "H.3.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.1"></see>
    /// </summary>
    let ``H.3.1.1`` = _prefix "H.3.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.2"></see>
    /// </summary>
    let ``H.3.1.2`` = _prefix "H.3.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.3"></see>
    /// </summary>
    let ``H.3.1.3`` = _prefix "H.3.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.4"></see>
    /// </summary>
    let ``H.3.1.4`` = _prefix "H.3.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.2"></see>
    /// </summary>
    let ``H.3.2`` = _prefix "H.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.2.0"></see>
    /// </summary>
    let ``H.3.2.0`` = _prefix "H.3.2.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.2.1"></see></summary>
    let ``H.3.2.1`` = _prefix "H.3.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3"></see>
    /// </summary>
    let ``H.3.3`` = _prefix "H.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.0"></see>
    /// </summary>
    let ``H.3.3.0`` = _prefix "H.3.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.1"></see>
    /// </summary>
    let ``H.3.3.1`` = _prefix "H.3.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.2"></see>
    /// </summary>
    let ``H.3.3.2`` = _prefix "H.3.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.3"></see>
    /// </summary>
    let ``H.3.3.3`` = _prefix "H.3.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.4"></see>
    /// </summary>
    let ``H.3.3.4`` = _prefix "H.3.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.5"></see>
    /// </summary>
    let ``H.3.3.5`` = _prefix "H.3.3.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.6"></see>
    /// </summary>
    let ``H.3.3.6`` = _prefix "H.3.3.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4"></see>
    /// </summary>
    let ``H.3.4`` = _prefix "H.3.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.0"></see></summary>
    let ``H.3.4.0`` = _prefix "H.3.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.1"></see>
    /// </summary>
    let ``H.3.4.1`` = _prefix "H.3.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.2"></see>
    /// </summary>
    let ``H.3.4.2`` = _prefix "H.3.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.3"></see>
    /// </summary>
    let ``H.3.4.3`` = _prefix "H.3.4.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.4"></see></summary>
    let ``H.3.4.4`` = _prefix "H.3.4.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.5"></see>
    /// </summary>
    let ``H.3.4.5`` = _prefix "H.3.4.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.5"></see>
    /// </summary>
    let ``H.3.5`` = _prefix "H.3.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.5.0"></see>
    /// </summary>
    let ``H.3.5.0`` = _prefix "H.3.5.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.5.1"></see>
    /// </summary>
    let ``H.3.5.1`` = _prefix "H.3.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.5.2"></see>
    /// </summary>
    let ``H.3.5.2`` = _prefix "H.3.5.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.6"></see>
    /// </summary>
    let ``H.3.6`` = _prefix "H.3.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.6.0"></see>
    /// </summary>
    let ``H.3.6.0`` = _prefix "H.3.6.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7"></see>
    /// </summary>
    let ``H.3.7`` = _prefix "H.3.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.0"></see>
    /// </summary>
    let ``H.3.7.0`` = _prefix "H.3.7.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.1"></see>
    /// </summary>
    let ``H.3.7.1`` = _prefix "H.3.7.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.2"></see>
    /// </summary>
    let ``H.3.7.2`` = _prefix "H.3.7.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.3"></see>
    /// </summary>
    let ``H.3.7.3`` = _prefix "H.3.7.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.4"></see>
    /// </summary>
    let ``H.3.7.4`` = _prefix "H.3.7.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.3.m"></see>
    /// </summary>
    let ``H.3.m`` = _prefix "H.3.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4"></see>
    /// </summary>
    let ``H.4`` = _prefix "H.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.0"></see>
    /// </summary>
    let ``H.4.0`` = _prefix "H.4.0"
    /// <summary>
    /// See also #I.7.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1"></see></summary>
    let ``H.4.1`` = _prefix "H.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.0"></see>
    /// </summary>
    let ``H.4.1.0`` = _prefix "H.4.1.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.1"></see></summary>
    let ``H.4.1.1`` = _prefix "H.4.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.2"></see>
    /// </summary>
    let ``H.4.1.2`` = _prefix "H.4.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.3"></see>
    /// </summary>
    let ``H.4.1.3`` = _prefix "H.4.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.4"></see>
    /// </summary>
    let ``H.4.1.4`` = _prefix "H.4.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.5"></see>
    /// </summary>
    let ``H.4.1.5`` = _prefix "H.4.1.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.6"></see>
    /// </summary>
    let ``H.4.1.6`` = _prefix "H.4.1.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.2"></see>
    /// </summary>
    let ``H.4.2`` = _prefix "H.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.2.0"></see>
    /// </summary>
    let ``H.4.2.0`` = _prefix "H.4.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.2.1"></see>
    /// </summary>
    let ``H.4.2.1`` = _prefix "H.4.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3"></see>
    /// </summary>
    let ``H.4.3`` = _prefix "H.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.0"></see>
    /// </summary>
    let ``H.4.3.0`` = _prefix "H.4.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.1"></see>
    /// </summary>
    let ``H.4.3.1`` = _prefix "H.4.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.2"></see>
    /// </summary>
    let ``H.4.3.2`` = _prefix "H.4.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.3"></see>
    /// </summary>
    let ``H.4.3.3`` = _prefix "H.4.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.4"></see>
    /// </summary>
    let ``H.4.3.4`` = _prefix "H.4.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.4.m"></see>
    /// </summary>
    let ``H.4.m`` = _prefix "H.4.m"
    /// <summary>
    /// See also #I.7.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5"></see></summary>
    let ``H.5`` = _prefix "H.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.0"></see>
    /// </summary>
    let ``H.5.0`` = _prefix "H.5.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1"></see>
    /// </summary>
    let ``H.5.1`` = _prefix "H.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.0"></see>
    /// </summary>
    let ``H.5.1.0`` = _prefix "H.5.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.1"></see>
    /// </summary>
    let ``H.5.1.1`` = _prefix "H.5.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.2"></see>
    /// </summary>
    let ``H.5.1.2`` = _prefix "H.5.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.3"></see>
    /// </summary>
    let ``H.5.1.3`` = _prefix "H.5.1.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.4"></see></summary>
    let ``H.5.1.4`` = _prefix "H.5.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.5"></see>
    /// </summary>
    let ``H.5.1.5`` = _prefix "H.5.1.5"
    /// <summary>
    /// See also #D.2.2, #H.1.2, #I.3.6.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2"></see></summary>
    let ``H.5.2`` = _prefix "H.5.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.0"></see>
    /// </summary>
    let ``H.5.2.0`` = _prefix "H.5.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.1"></see>
    /// </summary>
    let ``H.5.2.1`` = _prefix "H.5.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.10"></see>
    /// </summary>
    let ``H.5.2.10`` = _prefix "H.5.2.10"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.11"></see>
    /// </summary>
    let ``H.5.2.11`` = _prefix "H.5.2.11"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.12"></see>
    /// </summary>
    let ``H.5.2.12`` = _prefix "H.5.2.12"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.13"></see>
    /// </summary>
    let ``H.5.2.13`` = _prefix "H.5.2.13"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.14"></see>
    /// </summary>
    let ``H.5.2.14`` = _prefix "H.5.2.14"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.15"></see>
    /// </summary>
    let ``H.5.2.15`` = _prefix "H.5.2.15"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.16"></see>
    /// </summary>
    let ``H.5.2.16`` = _prefix "H.5.2.16"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.17"></see>
    /// </summary>
    let ``H.5.2.17`` = _prefix "H.5.2.17"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.18"></see>
    /// </summary>
    let ``H.5.2.18`` = _prefix "H.5.2.18"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.2"></see>
    /// </summary>
    let ``H.5.2.2`` = _prefix "H.5.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.3"></see>
    /// </summary>
    let ``H.5.2.3`` = _prefix "H.5.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.4"></see>
    /// </summary>
    let ``H.5.2.4`` = _prefix "H.5.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.5"></see>
    /// </summary>
    let ``H.5.2.5`` = _prefix "H.5.2.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.6"></see>
    /// </summary>
    let ``H.5.2.6`` = _prefix "H.5.2.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.7"></see>
    /// </summary>
    let ``H.5.2.7`` = _prefix "H.5.2.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.8"></see>
    /// </summary>
    let ``H.5.2.8`` = _prefix "H.5.2.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.9"></see>
    /// </summary>
    let ``H.5.2.9`` = _prefix "H.5.2.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3"></see>
    /// </summary>
    let ``H.5.3`` = _prefix "H.5.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.0"></see>
    /// </summary>
    let ``H.5.3.0`` = _prefix "H.5.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.1"></see>
    /// </summary>
    let ``H.5.3.1`` = _prefix "H.5.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.2"></see>
    /// </summary>
    let ``H.5.3.2`` = _prefix "H.5.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.3"></see>
    /// </summary>
    let ``H.5.3.3`` = _prefix "H.5.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.4"></see>
    /// </summary>
    let ``H.5.3.4`` = _prefix "H.5.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.5"></see>
    /// </summary>
    let ``H.5.3.5`` = _prefix "H.5.3.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.6"></see>
    /// </summary>
    let ``H.5.3.6`` = _prefix "H.5.3.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.7"></see>
    /// </summary>
    let ``H.5.3.7`` = _prefix "H.5.3.7"
    /// <summary>
    /// See also #I.7, #J.7.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4"></see></summary>
    let ``H.5.4`` = _prefix "H.5.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4.0"></see>
    /// </summary>
    let ``H.5.4.0`` = _prefix "H.5.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4.1"></see>
    /// </summary>
    let ``H.5.4.1`` = _prefix "H.5.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4.2"></see>
    /// </summary>
    let ``H.5.4.2`` = _prefix "H.5.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4.3"></see>
    /// </summary>
    let ``H.5.4.3`` = _prefix "H.5.4.3"
    /// <summary>
    /// See also #J.5.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5"></see></summary>
    let ``H.5.5`` = _prefix "H.5.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5.0"></see>
    /// </summary>
    let ``H.5.5.0`` = _prefix "H.5.5.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5.1"></see>
    /// </summary>
    let ``H.5.5.1`` = _prefix "H.5.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5.2"></see>
    /// </summary>
    let ``H.5.5.2`` = _prefix "H.5.5.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5.3"></see>
    /// </summary>
    let ``H.5.5.3`` = _prefix "H.5.5.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.5.m"></see>
    /// </summary>
    let ``H.5.m`` = _prefix "H.5.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#H.m"></see>
    /// </summary>
    let ``H.m`` = _prefix "H.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I"></see>
    /// </summary>
    let I = _prefix "I"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.0"></see>
    /// </summary>
    let ``I.0`` = _prefix "I.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1"></see>
    /// </summary>
    let ``I.1`` = _prefix "I.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1.0"></see>
    /// </summary>
    let ``I.1.0`` = _prefix "I.1.0"
    /// <summary>
    /// See also #E.1, #E.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1.1"></see></summary>
    let ``I.1.1`` = _prefix "I.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1.1.0"></see>
    /// </summary>
    let ``I.1.1.0`` = _prefix "I.1.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1.1.1"></see>
    /// </summary>
    let ``I.1.1.1`` = _prefix "I.1.1.1"
    /// <summary>
    /// See also #F.2.1, #F.2.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1.2"></see></summary>
    let ``I.1.2`` = _prefix "I.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1.2.0"></see>
    /// </summary>
    let ``I.1.2.0`` = _prefix "I.1.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1.2.1"></see>
    /// </summary>
    let ``I.1.2.1`` = _prefix "I.1.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1.2.2"></see>
    /// </summary>
    let ``I.1.2.2`` = _prefix "I.1.2.2"
    /// <summary>
    /// See also #D.3.2, #D.3.3, #F.2.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3"></see></summary>
    let ``I.1.3`` = _prefix "I.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.0"></see>
    /// </summary>
    let ``I.1.3.0`` = _prefix "I.1.3.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.1"></see></summary>
    let ``I.1.3.1`` = _prefix "I.1.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.2"></see>
    /// </summary>
    let ``I.1.3.2`` = _prefix "I.1.3.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.3"></see></summary>
    let ``I.1.3.3`` = _prefix "I.1.3.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.4"></see></summary>
    let ``I.1.3.4`` = _prefix "I.1.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1.4"></see>
    /// </summary>
    let ``I.1.4`` = _prefix "I.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.1.m"></see>
    /// </summary>
    let ``I.1.m`` = _prefix "I.1.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2"></see>
    /// </summary>
    let ``I.2`` = _prefix "I.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.0"></see>
    /// </summary>
    let ``I.2.0`` = _prefix "I.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.0.0"></see>
    /// </summary>
    let ``I.2.0.0`` = _prefix "I.2.0.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.0.1"></see>
    /// </summary>
    let ``I.2.0.1`` = _prefix "I.2.0.1"
    /// <summary>
    /// See also #H.4, #J.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1"></see></summary>
    let ``I.2.1`` = _prefix "I.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.0"></see>
    /// </summary>
    let ``I.2.1.0`` = _prefix "I.2.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.1"></see>
    /// </summary>
    let ``I.2.1.1`` = _prefix "I.2.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.2"></see>
    /// </summary>
    let ``I.2.1.2`` = _prefix "I.2.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.3"></see>
    /// </summary>
    let ``I.2.1.3`` = _prefix "I.2.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.4"></see>
    /// </summary>
    let ``I.2.1.4`` = _prefix "I.2.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.5"></see>
    /// </summary>
    let ``I.2.1.5`` = _prefix "I.2.1.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.6"></see>
    /// </summary>
    let ``I.2.1.6`` = _prefix "I.2.1.6"
    /// <summary>
    /// See also #I.4.8, #I.5.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10"></see></summary>
    let ``I.2.10`` = _prefix "I.2.10"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.0"></see>
    /// </summary>
    let ``I.2.10.0`` = _prefix "I.2.10.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.1"></see></summary>
    let ``I.2.10.1`` = _prefix "I.2.10.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.2"></see>
    /// </summary>
    let ``I.2.10.2`` = _prefix "I.2.10.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.3"></see>
    /// </summary>
    let ``I.2.10.3`` = _prefix "I.2.10.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.4"></see>
    /// </summary>
    let ``I.2.10.4`` = _prefix "I.2.10.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.5"></see>
    /// </summary>
    let ``I.2.10.5`` = _prefix "I.2.10.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.6"></see>
    /// </summary>
    let ``I.2.10.6`` = _prefix "I.2.10.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.7"></see>
    /// </summary>
    let ``I.2.10.7`` = _prefix "I.2.10.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.8"></see>
    /// </summary>
    let ``I.2.10.8`` = _prefix "I.2.10.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.9"></see>
    /// </summary>
    let ``I.2.10.9`` = _prefix "I.2.10.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11"></see>
    /// </summary>
    let ``I.2.11`` = _prefix "I.2.11"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11.0"></see>
    /// </summary>
    let ``I.2.11.0`` = _prefix "I.2.11.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11.1"></see>
    /// </summary>
    let ``I.2.11.1`` = _prefix "I.2.11.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11.2"></see>
    /// </summary>
    let ``I.2.11.2`` = _prefix "I.2.11.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11.3"></see>
    /// </summary>
    let ``I.2.11.3`` = _prefix "I.2.11.3"
    /// <summary>
    /// See also #D.1.2, #F.3.1, #F.4.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2"></see></summary>
    let ``I.2.2`` = _prefix "I.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.0"></see>
    /// </summary>
    let ``I.2.2.0`` = _prefix "I.2.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.1"></see>
    /// </summary>
    let ``I.2.2.1`` = _prefix "I.2.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.2"></see>
    /// </summary>
    let ``I.2.2.2`` = _prefix "I.2.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.3"></see>
    /// </summary>
    let ``I.2.2.3`` = _prefix "I.2.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.4"></see>
    /// </summary>
    let ``I.2.2.4`` = _prefix "I.2.2.4"
    /// <summary>
    /// See also #F.4.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3"></see></summary>
    let ``I.2.3`` = _prefix "I.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.0"></see>
    /// </summary>
    let ``I.2.3.0`` = _prefix "I.2.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.1"></see>
    /// </summary>
    let ``I.2.3.1`` = _prefix "I.2.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.2"></see>
    /// </summary>
    let ``I.2.3.2`` = _prefix "I.2.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.3"></see>
    /// </summary>
    let ``I.2.3.3`` = _prefix "I.2.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.4"></see>
    /// </summary>
    let ``I.2.3.4`` = _prefix "I.2.3.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.5"></see></summary>
    let ``I.2.3.5`` = _prefix "I.2.3.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.6"></see>
    /// </summary>
    let ``I.2.3.6`` = _prefix "I.2.3.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.7"></see>
    /// </summary>
    let ``I.2.3.7`` = _prefix "I.2.3.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.8"></see>
    /// </summary>
    let ``I.2.3.8`` = _prefix "I.2.3.8"
    /// <summary>
    /// See also #F.4.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4"></see></summary>
    let ``I.2.4`` = _prefix "I.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.0"></see>
    /// </summary>
    let ``I.2.4.0`` = _prefix "I.2.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.1"></see>
    /// </summary>
    let ``I.2.4.1`` = _prefix "I.2.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.2"></see>
    /// </summary>
    let ``I.2.4.2`` = _prefix "I.2.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.3"></see>
    /// </summary>
    let ``I.2.4.3`` = _prefix "I.2.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.4"></see>
    /// </summary>
    let ``I.2.4.4`` = _prefix "I.2.4.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.5"></see>
    /// </summary>
    let ``I.2.4.5`` = _prefix "I.2.4.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.6"></see>
    /// </summary>
    let ``I.2.4.6`` = _prefix "I.2.4.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.7"></see>
    /// </summary>
    let ``I.2.4.7`` = _prefix "I.2.4.7"
    /// <summary>
    /// See also #D.3.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.5"></see></summary>
    let ``I.2.5`` = _prefix "I.2.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.5.0"></see>
    /// </summary>
    let ``I.2.5.0`` = _prefix "I.2.5.0"
    /// <summary>
    /// See also #K.3.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6"></see></summary>
    let ``I.2.6`` = _prefix "I.2.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.0"></see>
    /// </summary>
    let ``I.2.6.0`` = _prefix "I.2.6.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.1"></see>
    /// </summary>
    let ``I.2.6.1`` = _prefix "I.2.6.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.2"></see>
    /// </summary>
    let ``I.2.6.2`` = _prefix "I.2.6.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.3"></see>
    /// </summary>
    let ``I.2.6.3`` = _prefix "I.2.6.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.4"></see>
    /// </summary>
    let ``I.2.6.4`` = _prefix "I.2.6.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.5"></see>
    /// </summary>
    let ``I.2.6.5`` = _prefix "I.2.6.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.6"></see>
    /// </summary>
    let ``I.2.6.6`` = _prefix "I.2.6.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7"></see>
    /// </summary>
    let ``I.2.7`` = _prefix "I.2.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.0"></see>
    /// </summary>
    let ``I.2.7.0`` = _prefix "I.2.7.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.1"></see>
    /// </summary>
    let ``I.2.7.1`` = _prefix "I.2.7.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.2"></see>
    /// </summary>
    let ``I.2.7.2`` = _prefix "I.2.7.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.3"></see>
    /// </summary>
    let ``I.2.7.3`` = _prefix "I.2.7.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.4"></see>
    /// </summary>
    let ``I.2.7.4`` = _prefix "I.2.7.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.5"></see>
    /// </summary>
    let ``I.2.7.5`` = _prefix "I.2.7.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.6"></see>
    /// </summary>
    let ``I.2.7.6`` = _prefix "I.2.7.6"
    /// <summary>
    /// See also #F.2.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8"></see></summary>
    let ``I.2.8`` = _prefix "I.2.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.0"></see>
    /// </summary>
    let ``I.2.8.0`` = _prefix "I.2.8.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.1"></see>
    /// </summary>
    let ``I.2.8.1`` = _prefix "I.2.8.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.2"></see>
    /// </summary>
    let ``I.2.8.2`` = _prefix "I.2.8.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.3"></see>
    /// </summary>
    let ``I.2.8.3`` = _prefix "I.2.8.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.4"></see>
    /// </summary>
    let ``I.2.8.4`` = _prefix "I.2.8.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.5"></see>
    /// </summary>
    let ``I.2.8.5`` = _prefix "I.2.8.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.6"></see>
    /// </summary>
    let ``I.2.8.6`` = _prefix "I.2.8.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9"></see>
    /// </summary>
    let ``I.2.9`` = _prefix "I.2.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.0"></see>
    /// </summary>
    let ``I.2.9.0`` = _prefix "I.2.9.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.1"></see>
    /// </summary>
    let ``I.2.9.1`` = _prefix "I.2.9.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.2"></see>
    /// </summary>
    let ``I.2.9.2`` = _prefix "I.2.9.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.3"></see>
    /// </summary>
    let ``I.2.9.3`` = _prefix "I.2.9.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.4"></see>
    /// </summary>
    let ``I.2.9.4`` = _prefix "I.2.9.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.5"></see>
    /// </summary>
    let ``I.2.9.5`` = _prefix "I.2.9.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.6"></see>
    /// </summary>
    let ``I.2.9.6`` = _prefix "I.2.9.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.7"></see>
    /// </summary>
    let ``I.2.9.7`` = _prefix "I.2.9.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.2.m"></see>
    /// </summary>
    let ``I.2.m`` = _prefix "I.2.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3"></see>
    /// </summary>
    let ``I.3`` = _prefix "I.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.0"></see>
    /// </summary>
    let ``I.3.0`` = _prefix "I.3.0"
    /// <summary>
    /// See also #B.4.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1"></see></summary>
    let ``I.3.1`` = _prefix "I.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.0"></see>
    /// </summary>
    let ``I.3.1.0`` = _prefix "I.3.1.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.1"></see></summary>
    let ``I.3.1.1`` = _prefix "I.3.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.2"></see>
    /// </summary>
    let ``I.3.1.2`` = _prefix "I.3.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.3"></see>
    /// </summary>
    let ``I.3.1.3`` = _prefix "I.3.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.4"></see>
    /// </summary>
    let ``I.3.1.4`` = _prefix "I.3.1.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.5"></see></summary>
    let ``I.3.1.5`` = _prefix "I.3.1.5"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.6"></see></summary>
    let ``I.3.1.6`` = _prefix "I.3.1.6"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.7"></see></summary>
    let ``I.3.1.7`` = _prefix "I.3.1.7"
    /// <summary>
    /// See also #C.2.1, #C.2.4, #C.3.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.2"></see></summary>
    let ``I.3.2`` = _prefix "I.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.2.0"></see>
    /// </summary>
    let ``I.3.2.0`` = _prefix "I.3.2.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.2.1"></see></summary>
    let ``I.3.2.1`` = _prefix "I.3.2.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.2.2"></see></summary>
    let ``I.3.2.2`` = _prefix "I.3.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3"></see>
    /// </summary>
    let ``I.3.3`` = _prefix "I.3.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.0"></see></summary>
    let ``I.3.3.0`` = _prefix "I.3.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.1"></see>
    /// </summary>
    let ``I.3.3.1`` = _prefix "I.3.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.2"></see>
    /// </summary>
    let ``I.3.3.2`` = _prefix "I.3.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.3"></see>
    /// </summary>
    let ``I.3.3.3`` = _prefix "I.3.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.4"></see>
    /// </summary>
    let ``I.3.3.4`` = _prefix "I.3.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.5"></see>
    /// </summary>
    let ``I.3.3.5`` = _prefix "I.3.3.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4"></see>
    /// </summary>
    let ``I.3.4`` = _prefix "I.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.0"></see>
    /// </summary>
    let ``I.3.4.0`` = _prefix "I.3.4.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.1"></see></summary>
    let ``I.3.4.1`` = _prefix "I.3.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.2"></see>
    /// </summary>
    let ``I.3.4.2`` = _prefix "I.3.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.3"></see>
    /// </summary>
    let ``I.3.4.3`` = _prefix "I.3.4.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.4"></see></summary>
    let ``I.3.4.4`` = _prefix "I.3.4.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.5"></see>
    /// </summary>
    let ``I.3.4.5`` = _prefix "I.3.4.5"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.6"></see></summary>
    let ``I.3.4.6`` = _prefix "I.3.4.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.7"></see>
    /// </summary>
    let ``I.3.4.7`` = _prefix "I.3.4.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.8"></see>
    /// </summary>
    let ``I.3.4.8`` = _prefix "I.3.4.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5"></see>
    /// </summary>
    let ``I.3.5`` = _prefix "I.3.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.0"></see>
    /// </summary>
    let ``I.3.5.0`` = _prefix "I.3.5.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.1"></see></summary>
    let ``I.3.5.1`` = _prefix "I.3.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.2"></see>
    /// </summary>
    let ``I.3.5.2`` = _prefix "I.3.5.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.3"></see>
    /// </summary>
    let ``I.3.5.3`` = _prefix "I.3.5.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.4"></see>
    /// </summary>
    let ``I.3.5.4`` = _prefix "I.3.5.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.5"></see>
    /// </summary>
    let ``I.3.5.5`` = _prefix "I.3.5.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.6"></see>
    /// </summary>
    let ``I.3.5.6`` = _prefix "I.3.5.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.7"></see>
    /// </summary>
    let ``I.3.5.7`` = _prefix "I.3.5.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.8"></see>
    /// </summary>
    let ``I.3.5.8`` = _prefix "I.3.5.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6"></see>
    /// </summary>
    let ``I.3.6`` = _prefix "I.3.6"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.0"></see></summary>
    let ``I.3.6.0`` = _prefix "I.3.6.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.1"></see>
    /// </summary>
    let ``I.3.6.1`` = _prefix "I.3.6.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.2"></see>
    /// </summary>
    let ``I.3.6.2`` = _prefix "I.3.6.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.3"></see>
    /// </summary>
    let ``I.3.6.3`` = _prefix "I.3.6.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.4"></see>
    /// </summary>
    let ``I.3.6.4`` = _prefix "I.3.6.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.5"></see>
    /// </summary>
    let ``I.3.6.5`` = _prefix "I.3.6.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7"></see>
    /// </summary>
    let ``I.3.7`` = _prefix "I.3.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.0"></see>
    /// </summary>
    let ``I.3.7.0`` = _prefix "I.3.7.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.1"></see>
    /// </summary>
    let ``I.3.7.1`` = _prefix "I.3.7.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.2"></see>
    /// </summary>
    let ``I.3.7.2`` = _prefix "I.3.7.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.3"></see>
    /// </summary>
    let ``I.3.7.3`` = _prefix "I.3.7.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.4"></see>
    /// </summary>
    let ``I.3.7.4`` = _prefix "I.3.7.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.5"></see>
    /// </summary>
    let ``I.3.7.5`` = _prefix "I.3.7.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.6"></see>
    /// </summary>
    let ``I.3.7.6`` = _prefix "I.3.7.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.7"></see>
    /// </summary>
    let ``I.3.7.7`` = _prefix "I.3.7.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.8"></see>
    /// </summary>
    let ``I.3.8`` = _prefix "I.3.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.3.m"></see>
    /// </summary>
    let ``I.3.m`` = _prefix "I.3.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4"></see>
    /// </summary>
    let ``I.4`` = _prefix "I.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.0"></see>
    /// </summary>
    let ``I.4.0`` = _prefix "I.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.0.0"></see>
    /// </summary>
    let ``I.4.0.0`` = _prefix "I.4.0.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.0.1"></see>
    /// </summary>
    let ``I.4.0.1`` = _prefix "I.4.0.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1"></see>
    /// </summary>
    let ``I.4.1`` = _prefix "I.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.0"></see>
    /// </summary>
    let ``I.4.1.0`` = _prefix "I.4.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.1"></see>
    /// </summary>
    let ``I.4.1.1`` = _prefix "I.4.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.2"></see>
    /// </summary>
    let ``I.4.1.2`` = _prefix "I.4.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.3"></see>
    /// </summary>
    let ``I.4.1.3`` = _prefix "I.4.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.4"></see>
    /// </summary>
    let ``I.4.1.4`` = _prefix "I.4.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.5"></see>
    /// </summary>
    let ``I.4.1.5`` = _prefix "I.4.1.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.6"></see>
    /// </summary>
    let ``I.4.1.6`` = _prefix "I.4.1.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10"></see>
    /// </summary>
    let ``I.4.10`` = _prefix "I.4.10"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.0"></see>
    /// </summary>
    let ``I.4.10.0`` = _prefix "I.4.10.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.1"></see>
    /// </summary>
    let ``I.4.10.1`` = _prefix "I.4.10.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.2"></see>
    /// </summary>
    let ``I.4.10.2`` = _prefix "I.4.10.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.3"></see>
    /// </summary>
    let ``I.4.10.3`` = _prefix "I.4.10.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.4"></see>
    /// </summary>
    let ``I.4.10.4`` = _prefix "I.4.10.4"
    /// <summary>
    /// See also #E.4.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.2"></see></summary>
    let ``I.4.2`` = _prefix "I.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.2.0"></see>
    /// </summary>
    let ``I.4.2.0`` = _prefix "I.4.2.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.2.1"></see></summary>
    let ``I.4.2.1`` = _prefix "I.4.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3"></see>
    /// </summary>
    let ``I.4.3`` = _prefix "I.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.0"></see>
    /// </summary>
    let ``I.4.3.0`` = _prefix "I.4.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.1"></see>
    /// </summary>
    let ``I.4.3.1`` = _prefix "I.4.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.2"></see>
    /// </summary>
    let ``I.4.3.2`` = _prefix "I.4.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.3"></see>
    /// </summary>
    let ``I.4.3.3`` = _prefix "I.4.3.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.4"></see></summary>
    let ``I.4.3.4`` = _prefix "I.4.3.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.5"></see>
    /// </summary>
    let ``I.4.3.5`` = _prefix "I.4.3.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4"></see>
    /// </summary>
    let ``I.4.4`` = _prefix "I.4.4"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4.0"></see></summary>
    let ``I.4.4.0`` = _prefix "I.4.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4.1"></see>
    /// </summary>
    let ``I.4.4.1`` = _prefix "I.4.4.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4.2"></see></summary>
    let ``I.4.4.2`` = _prefix "I.4.4.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4.3"></see></summary>
    let ``I.4.4.3`` = _prefix "I.4.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.5"></see>
    /// </summary>
    let ``I.4.5`` = _prefix "I.4.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.5.0"></see>
    /// </summary>
    let ``I.4.5.0`` = _prefix "I.4.5.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.5.1"></see></summary>
    let ``I.4.5.1`` = _prefix "I.4.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.5.2"></see>
    /// </summary>
    let ``I.4.5.2`` = _prefix "I.4.5.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6"></see>
    /// </summary>
    let ``I.4.6`` = _prefix "I.4.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6.0"></see>
    /// </summary>
    let ``I.4.6.0`` = _prefix "I.4.6.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6.1"></see>
    /// </summary>
    let ``I.4.6.1`` = _prefix "I.4.6.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6.2"></see>
    /// </summary>
    let ``I.4.6.2`` = _prefix "I.4.6.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6.3"></see>
    /// </summary>
    let ``I.4.6.3`` = _prefix "I.4.6.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7"></see>
    /// </summary>
    let ``I.4.7`` = _prefix "I.4.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.0"></see>
    /// </summary>
    let ``I.4.7.0`` = _prefix "I.4.7.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.1"></see>
    /// </summary>
    let ``I.4.7.1`` = _prefix "I.4.7.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.2"></see>
    /// </summary>
    let ``I.4.7.2`` = _prefix "I.4.7.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.3"></see>
    /// </summary>
    let ``I.4.7.3`` = _prefix "I.4.7.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.4"></see>
    /// </summary>
    let ``I.4.7.4`` = _prefix "I.4.7.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.5"></see>
    /// </summary>
    let ``I.4.7.5`` = _prefix "I.4.7.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8"></see>
    /// </summary>
    let ``I.4.8`` = _prefix "I.4.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.0"></see>
    /// </summary>
    let ``I.4.8.0`` = _prefix "I.4.8.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.1"></see>
    /// </summary>
    let ``I.4.8.1`` = _prefix "I.4.8.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.10"></see>
    /// </summary>
    let ``I.4.8.10`` = _prefix "I.4.8.10"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.11"></see>
    /// </summary>
    let ``I.4.8.11`` = _prefix "I.4.8.11"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.12"></see>
    /// </summary>
    let ``I.4.8.12`` = _prefix "I.4.8.12"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.2"></see>
    /// </summary>
    let ``I.4.8.2`` = _prefix "I.4.8.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.3"></see>
    /// </summary>
    let ``I.4.8.3`` = _prefix "I.4.8.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.4"></see>
    /// </summary>
    let ``I.4.8.4`` = _prefix "I.4.8.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.5"></see>
    /// </summary>
    let ``I.4.8.5`` = _prefix "I.4.8.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.6"></see>
    /// </summary>
    let ``I.4.8.6`` = _prefix "I.4.8.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.7"></see>
    /// </summary>
    let ``I.4.8.7`` = _prefix "I.4.8.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.8"></see>
    /// </summary>
    let ``I.4.8.8`` = _prefix "I.4.8.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.9"></see>
    /// </summary>
    let ``I.4.8.9`` = _prefix "I.4.8.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.9"></see>
    /// </summary>
    let ``I.4.9`` = _prefix "I.4.9"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.4.m"></see>
    /// </summary>
    let ``I.4.m`` = _prefix "I.4.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5"></see>
    /// </summary>
    let ``I.5`` = _prefix "I.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.0"></see>
    /// </summary>
    let ``I.5.0`` = _prefix "I.5.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1"></see>
    /// </summary>
    let ``I.5.1`` = _prefix "I.5.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.0"></see></summary>
    let ``I.5.1.0`` = _prefix "I.5.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.1"></see>
    /// </summary>
    let ``I.5.1.1`` = _prefix "I.5.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.2"></see>
    /// </summary>
    let ``I.5.1.2`` = _prefix "I.5.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.3"></see>
    /// </summary>
    let ``I.5.1.3`` = _prefix "I.5.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.4"></see>
    /// </summary>
    let ``I.5.1.4`` = _prefix "I.5.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.5"></see>
    /// </summary>
    let ``I.5.1.5`` = _prefix "I.5.1.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.2"></see>
    /// </summary>
    let ``I.5.2`` = _prefix "I.5.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.2.0"></see>
    /// </summary>
    let ``I.5.2.0`` = _prefix "I.5.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.2.1"></see>
    /// </summary>
    let ``I.5.2.1`` = _prefix "I.5.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.2.2"></see>
    /// </summary>
    let ``I.5.2.2`` = _prefix "I.5.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.3"></see>
    /// </summary>
    let ``I.5.3`` = _prefix "I.5.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.3.0"></see>
    /// </summary>
    let ``I.5.3.0`` = _prefix "I.5.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.3.1"></see>
    /// </summary>
    let ``I.5.3.1`` = _prefix "I.5.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4"></see>
    /// </summary>
    let ``I.5.4`` = _prefix "I.5.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4.0"></see>
    /// </summary>
    let ``I.5.4.0`` = _prefix "I.5.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4.1"></see>
    /// </summary>
    let ``I.5.4.1`` = _prefix "I.5.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4.2"></see>
    /// </summary>
    let ``I.5.4.2`` = _prefix "I.5.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4.3"></see>
    /// </summary>
    let ``I.5.4.3`` = _prefix "I.5.4.3"
    /// <summary>
    /// See also #C.3.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.5"></see></summary>
    let ``I.5.5`` = _prefix "I.5.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.5.0"></see>
    /// </summary>
    let ``I.5.5.0`` = _prefix "I.5.5.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.5.1"></see>
    /// </summary>
    let ``I.5.5.1`` = _prefix "I.5.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.5.m"></see>
    /// </summary>
    let ``I.5.m`` = _prefix "I.5.m"
    /// <summary>
    /// See also #G.3.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6"></see></summary>
    let ``I.6`` = _prefix "I.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.0"></see>
    /// </summary>
    let ``I.6.0`` = _prefix "I.6.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.1"></see>
    /// </summary>
    let ``I.6.1`` = _prefix "I.6.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.1.0"></see>
    /// </summary>
    let ``I.6.1.0`` = _prefix "I.6.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.1.1"></see>
    /// </summary>
    let ``I.6.1.1`` = _prefix "I.6.1.1"
    /// <summary>
    /// Depricated, no longer used as of January 1991.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.1.2"></see></summary>
    let ``I.6.1.2`` = _prefix "I.6.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.2"></see>
    /// </summary>
    let ``I.6.2`` = _prefix "I.6.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.3"></see>
    /// </summary>
    let ``I.6.3`` = _prefix "I.6.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.4"></see>
    /// </summary>
    let ``I.6.4`` = _prefix "I.6.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.5"></see>
    /// </summary>
    let ``I.6.5`` = _prefix "I.6.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.5.0"></see>
    /// </summary>
    let ``I.6.5.0`` = _prefix "I.6.5.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.6"></see>
    /// </summary>
    let ``I.6.6`` = _prefix "I.6.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.7"></see>
    /// </summary>
    let ``I.6.7`` = _prefix "I.6.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.7.0"></see>
    /// </summary>
    let ``I.6.7.0`` = _prefix "I.6.7.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8"></see>
    /// </summary>
    let ``I.6.8`` = _prefix "I.6.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.0"></see>
    /// </summary>
    let ``I.6.8.0`` = _prefix "I.6.8.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.1"></see>
    /// </summary>
    let ``I.6.8.1`` = _prefix "I.6.8.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.2"></see>
    /// </summary>
    let ``I.6.8.2`` = _prefix "I.6.8.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.3"></see>
    /// </summary>
    let ``I.6.8.3`` = _prefix "I.6.8.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.4"></see>
    /// </summary>
    let ``I.6.8.4`` = _prefix "I.6.8.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.5"></see>
    /// </summary>
    let ``I.6.8.5`` = _prefix "I.6.8.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.6"></see>
    /// </summary>
    let ``I.6.8.6`` = _prefix "I.6.8.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.7"></see>
    /// </summary>
    let ``I.6.8.7`` = _prefix "I.6.8.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.8"></see>
    /// </summary>
    let ``I.6.8.8`` = _prefix "I.6.8.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.6.m"></see>
    /// </summary>
    let ``I.6.m`` = _prefix "I.6.m"
    /// <summary>
    /// See also #H.4, #H.5.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7"></see></summary>
    let ``I.7`` = _prefix "I.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.0"></see>
    /// </summary>
    let ``I.7.0`` = _prefix "I.7.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1"></see>
    /// </summary>
    let ``I.7.1`` = _prefix "I.7.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1.0"></see>
    /// </summary>
    let ``I.7.1.0`` = _prefix "I.7.1.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1.1"></see></summary>
    let ``I.7.1.1`` = _prefix "I.7.1.1"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1.2"></see></summary>
    let ``I.7.1.2`` = _prefix "I.7.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1.3"></see>
    /// </summary>
    let ``I.7.1.3`` = _prefix "I.7.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2"></see>
    /// </summary>
    let ``I.7.2`` = _prefix "I.7.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.0"></see>
    /// </summary>
    let ``I.7.2.0`` = _prefix "I.7.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.1"></see>
    /// </summary>
    let ``I.7.2.1`` = _prefix "I.7.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.2"></see>
    /// </summary>
    let ``I.7.2.2`` = _prefix "I.7.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.3"></see>
    /// </summary>
    let ``I.7.2.3`` = _prefix "I.7.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.4"></see>
    /// </summary>
    let ``I.7.2.4`` = _prefix "I.7.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.5"></see>
    /// </summary>
    let ``I.7.2.5`` = _prefix "I.7.2.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.6"></see>
    /// </summary>
    let ``I.7.2.6`` = _prefix "I.7.2.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.7"></see>
    /// </summary>
    let ``I.7.2.7`` = _prefix "I.7.2.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.8"></see>
    /// </summary>
    let ``I.7.2.8`` = _prefix "I.7.2.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.9"></see>
    /// </summary>
    let ``I.7.2.9`` = _prefix "I.7.2.9"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.3"></see></summary>
    let ``I.7.3`` = _prefix "I.7.3"
    /// <summary>
    /// See also #H.5.4, #J.7, #I.4.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4"></see></summary>
    let ``I.7.4`` = _prefix "I.7.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4.0"></see>
    /// </summary>
    let ``I.7.4.0`` = _prefix "I.7.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4.1"></see>
    /// </summary>
    let ``I.7.4.1`` = _prefix "I.7.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4.2"></see>
    /// </summary>
    let ``I.7.4.2`` = _prefix "I.7.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4.3"></see>
    /// </summary>
    let ``I.7.4.3`` = _prefix "I.7.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.7.m"></see>
    /// </summary>
    let ``I.7.m`` = _prefix "I.7.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#I.m"></see>
    /// </summary>
    let ``I.m`` = _prefix "I.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J"></see>
    /// </summary>
    let J = _prefix "J"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.0"></see>
    /// </summary>
    let ``J.0`` = _prefix "J.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.1"></see>
    /// </summary>
    let ``J.1`` = _prefix "J.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.1.0"></see>
    /// </summary>
    let ``J.1.0`` = _prefix "J.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.1.1"></see>
    /// </summary>
    let ``J.1.1`` = _prefix "J.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.1.2"></see>
    /// </summary>
    let ``J.1.2`` = _prefix "J.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.1.3"></see>
    /// </summary>
    let ``J.1.3`` = _prefix "J.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.1.4"></see>
    /// </summary>
    let ``J.1.4`` = _prefix "J.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.1.5"></see>
    /// </summary>
    let ``J.1.5`` = _prefix "J.1.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.1.6"></see>
    /// </summary>
    let ``J.1.6`` = _prefix "J.1.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.1.7"></see>
    /// </summary>
    let ``J.1.7`` = _prefix "J.1.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.2"></see>
    /// </summary>
    let ``J.2`` = _prefix "J.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.2.0"></see>
    /// </summary>
    let ``J.2.0`` = _prefix "J.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.2.1"></see>
    /// </summary>
    let ``J.2.1`` = _prefix "J.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.2.2"></see>
    /// </summary>
    let ``J.2.2`` = _prefix "J.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.2.3"></see>
    /// </summary>
    let ``J.2.3`` = _prefix "J.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.2.4"></see>
    /// </summary>
    let ``J.2.4`` = _prefix "J.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.2.5"></see>
    /// </summary>
    let ``J.2.5`` = _prefix "J.2.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.2.6"></see>
    /// </summary>
    let ``J.2.6`` = _prefix "J.2.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.2.7"></see>
    /// </summary>
    let ``J.2.7`` = _prefix "J.2.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.2.8"></see>
    /// </summary>
    let ``J.2.8`` = _prefix "J.2.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.3"></see>
    /// </summary>
    let ``J.3`` = _prefix "J.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.3.0"></see>
    /// </summary>
    let ``J.3.0`` = _prefix "J.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.3.1"></see>
    /// </summary>
    let ``J.3.1`` = _prefix "J.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.3.2"></see>
    /// </summary>
    let ``J.3.2`` = _prefix "J.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.4"></see>
    /// </summary>
    let ``J.4`` = _prefix "J.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.4.0"></see>
    /// </summary>
    let ``J.4.0`` = _prefix "J.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.4.1"></see>
    /// </summary>
    let ``J.4.1`` = _prefix "J.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.4.2"></see>
    /// </summary>
    let ``J.4.2`` = _prefix "J.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.5"></see>
    /// </summary>
    let ``J.5`` = _prefix "J.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.5.0"></see>
    /// </summary>
    let ``J.5.0`` = _prefix "J.5.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#J.5.1"></see></summary>
    let ``J.5.1`` = _prefix "J.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.5.2"></see>
    /// </summary>
    let ``J.5.2`` = _prefix "J.5.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.5.3"></see>
    /// </summary>
    let ``J.5.3`` = _prefix "J.5.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.5.4"></see>
    /// </summary>
    let ``J.5.4`` = _prefix "J.5.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.5.5"></see>
    /// </summary>
    let ``J.5.5`` = _prefix "J.5.5"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#J.5.6"></see></summary>
    let ``J.5.6`` = _prefix "J.5.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.5.7"></see>
    /// </summary>
    let ``J.5.7`` = _prefix "J.5.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.6"></see>
    /// </summary>
    let ``J.6`` = _prefix "J.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.6.0"></see>
    /// </summary>
    let ``J.6.0`` = _prefix "J.6.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.6.1"></see>
    /// </summary>
    let ``J.6.1`` = _prefix "J.6.1"
    /// <summary>
    /// See also #C.3.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#J.7"></see></summary>
    let ``J.7`` = _prefix "J.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.7.0"></see>
    /// </summary>
    let ``J.7.0`` = _prefix "J.7.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.7.1"></see>
    /// </summary>
    let ``J.7.1`` = _prefix "J.7.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.7.2"></see>
    /// </summary>
    let ``J.7.2`` = _prefix "J.7.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.7.3"></see>
    /// </summary>
    let ``J.7.3`` = _prefix "J.7.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.7.4"></see>
    /// </summary>
    let ``J.7.4`` = _prefix "J.7.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.7.5"></see>
    /// </summary>
    let ``J.7.5`` = _prefix "J.7.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.7.6"></see>
    /// </summary>
    let ``J.7.6`` = _prefix "J.7.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#J.m"></see>
    /// </summary>
    let ``J.m`` = _prefix "J.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K"></see>
    /// </summary>
    let K = _prefix "K"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.0"></see>
    /// </summary>
    let ``K.0`` = _prefix "K.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.1"></see>
    /// </summary>
    let ``K.1`` = _prefix "K.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.1.0"></see>
    /// </summary>
    let ``K.1.0`` = _prefix "K.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.1.1"></see>
    /// </summary>
    let ``K.1.1`` = _prefix "K.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.1.2"></see>
    /// </summary>
    let ``K.1.2`` = _prefix "K.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.1.3"></see>
    /// </summary>
    let ``K.1.3`` = _prefix "K.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.2"></see>
    /// </summary>
    let ``K.2`` = _prefix "K.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.2.0"></see>
    /// </summary>
    let ``K.2.0`` = _prefix "K.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.2.1"></see>
    /// </summary>
    let ``K.2.1`` = _prefix "K.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.2.2"></see>
    /// </summary>
    let ``K.2.2`` = _prefix "K.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.2.3"></see>
    /// </summary>
    let ``K.2.3`` = _prefix "K.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.2.4"></see>
    /// </summary>
    let ``K.2.4`` = _prefix "K.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3"></see>
    /// </summary>
    let ``K.3`` = _prefix "K.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3.0"></see>
    /// </summary>
    let ``K.3.0`` = _prefix "K.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1"></see>
    /// </summary>
    let ``K.3.1`` = _prefix "K.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1.0"></see>
    /// </summary>
    let ``K.3.1.0`` = _prefix "K.3.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1.1"></see>
    /// </summary>
    let ``K.3.1.1`` = _prefix "K.3.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1.2"></see>
    /// </summary>
    let ``K.3.1.2`` = _prefix "K.3.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1.3"></see>
    /// </summary>
    let ``K.3.1.3`` = _prefix "K.3.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2"></see>
    /// </summary>
    let ``K.3.2`` = _prefix "K.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.0"></see>
    /// </summary>
    let ``K.3.2.0`` = _prefix "K.3.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.1"></see>
    /// </summary>
    let ``K.3.2.1`` = _prefix "K.3.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.2"></see>
    /// </summary>
    let ``K.3.2.2`` = _prefix "K.3.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.3"></see>
    /// </summary>
    let ``K.3.2.3`` = _prefix "K.3.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.4"></see>
    /// </summary>
    let ``K.3.2.4`` = _prefix "K.3.2.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.5"></see>
    /// </summary>
    let ``K.3.2.5`` = _prefix "K.3.2.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3.m"></see>
    /// </summary>
    let ``K.3.m`` = _prefix "K.3.m"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3.m.0"></see></summary>
    let ``K.3.m.0`` = _prefix "K.3.m.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.3.m.1"></see></summary>
    let ``K.3.m.1`` = _prefix "K.3.m.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4"></see>
    /// </summary>
    let ``K.4`` = _prefix "K.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.0"></see>
    /// </summary>
    let ``K.4.0`` = _prefix "K.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1"></see>
    /// </summary>
    let ``K.4.1`` = _prefix "K.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.0"></see>
    /// </summary>
    let ``K.4.1.0`` = _prefix "K.4.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.1"></see>
    /// </summary>
    let ``K.4.1.1`` = _prefix "K.4.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.2"></see>
    /// </summary>
    let ``K.4.1.2`` = _prefix "K.4.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.3"></see>
    /// </summary>
    let ``K.4.1.3`` = _prefix "K.4.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.4"></see>
    /// </summary>
    let ``K.4.1.4`` = _prefix "K.4.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.5"></see>
    /// </summary>
    let ``K.4.1.5`` = _prefix "K.4.1.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.6"></see>
    /// </summary>
    let ``K.4.1.6`` = _prefix "K.4.1.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.7"></see>
    /// </summary>
    let ``K.4.1.7`` = _prefix "K.4.1.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.8"></see>
    /// </summary>
    let ``K.4.1.8`` = _prefix "K.4.1.8"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2"></see>
    /// </summary>
    let ``K.4.2`` = _prefix "K.4.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2.0"></see></summary>
    let ``K.4.2.0`` = _prefix "K.4.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2.1"></see>
    /// </summary>
    let ``K.4.2.1`` = _prefix "K.4.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2.2"></see>
    /// </summary>
    let ``K.4.2.2`` = _prefix "K.4.2.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2.3"></see></summary>
    let ``K.4.2.3`` = _prefix "K.4.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3"></see>
    /// </summary>
    let ``K.4.3`` = _prefix "K.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3.0"></see>
    /// </summary>
    let ``K.4.3.0`` = _prefix "K.4.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3.1"></see>
    /// </summary>
    let ``K.4.3.1`` = _prefix "K.4.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3.2"></see>
    /// </summary>
    let ``K.4.3.2`` = _prefix "K.4.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3.3"></see>
    /// </summary>
    let ``K.4.3.3`` = _prefix "K.4.3.3"
    /// <summary>
    /// See also #J.1.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4"></see></summary>
    let ``K.4.4`` = _prefix "K.4.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.0"></see>
    /// </summary>
    let ``K.4.4.0`` = _prefix "K.4.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.1"></see>
    /// </summary>
    let ``K.4.4.1`` = _prefix "K.4.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.2"></see>
    /// </summary>
    let ``K.4.4.2`` = _prefix "K.4.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.3"></see>
    /// </summary>
    let ``K.4.4.3`` = _prefix "K.4.4.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.4"></see>
    /// </summary>
    let ``K.4.4.4`` = _prefix "K.4.4.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.5"></see>
    /// </summary>
    let ``K.4.4.5`` = _prefix "K.4.4.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.4.m"></see>
    /// </summary>
    let ``K.4.m`` = _prefix "K.4.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.5"></see>
    /// </summary>
    let ``K.5`` = _prefix "K.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.5.0"></see>
    /// </summary>
    let ``K.5.0`` = _prefix "K.5.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1"></see>
    /// </summary>
    let ``K.5.1`` = _prefix "K.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.0"></see>
    /// </summary>
    let ``K.5.1.0`` = _prefix "K.5.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.1"></see>
    /// </summary>
    let ``K.5.1.1`` = _prefix "K.5.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.2"></see>
    /// </summary>
    let ``K.5.1.2`` = _prefix "K.5.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.3"></see>
    /// </summary>
    let ``K.5.1.3`` = _prefix "K.5.1.3"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.4"></see></summary>
    let ``K.5.1.4`` = _prefix "K.5.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.5.2"></see>
    /// </summary>
    let ``K.5.2`` = _prefix "K.5.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.5.2.0"></see>
    /// </summary>
    let ``K.5.2.0`` = _prefix "K.5.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.5.2.1"></see>
    /// </summary>
    let ``K.5.2.1`` = _prefix "K.5.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.5.2.2"></see>
    /// </summary>
    let ``K.5.2.2`` = _prefix "K.5.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.5.m"></see>
    /// </summary>
    let ``K.5.m`` = _prefix "K.5.m"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.5.m.0"></see></summary>
    let ``K.5.m.0`` = _prefix "K.5.m.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.5.m.1"></see></summary>
    let ``K.5.m.1`` = _prefix "K.5.m.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6"></see>
    /// </summary>
    let ``K.6`` = _prefix "K.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.0"></see>
    /// </summary>
    let ``K.6.0`` = _prefix "K.6.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.0.0"></see>
    /// </summary>
    let ``K.6.0.0`` = _prefix "K.6.0.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1"></see>
    /// </summary>
    let ``K.6.1`` = _prefix "K.6.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.0"></see>
    /// </summary>
    let ``K.6.1.0`` = _prefix "K.6.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.1"></see>
    /// </summary>
    let ``K.6.1.1`` = _prefix "K.6.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.2"></see>
    /// </summary>
    let ``K.6.1.2`` = _prefix "K.6.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.3"></see>
    /// </summary>
    let ``K.6.1.3`` = _prefix "K.6.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.4"></see>
    /// </summary>
    let ``K.6.1.4`` = _prefix "K.6.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.5"></see>
    /// </summary>
    let ``K.6.1.5`` = _prefix "K.6.1.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.6"></see>
    /// </summary>
    let ``K.6.1.6`` = _prefix "K.6.1.6"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2"></see>
    /// </summary>
    let ``K.6.2`` = _prefix "K.6.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.0"></see>
    /// </summary>
    let ``K.6.2.0`` = _prefix "K.6.2.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.1"></see>
    /// </summary>
    let ``K.6.2.1`` = _prefix "K.6.2.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.2"></see>
    /// </summary>
    let ``K.6.2.2`` = _prefix "K.6.2.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.3"></see>
    /// </summary>
    let ``K.6.2.3`` = _prefix "K.6.2.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.4"></see>
    /// </summary>
    let ``K.6.2.4`` = _prefix "K.6.2.4"
    /// <summary>
    /// See also #D.2.9.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3"></see></summary>
    let ``K.6.3`` = _prefix "K.6.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3.0"></see>
    /// </summary>
    let ``K.6.3.0`` = _prefix "K.6.3.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3.1"></see>
    /// </summary>
    let ``K.6.3.1`` = _prefix "K.6.3.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3.2"></see>
    /// </summary>
    let ``K.6.3.2`` = _prefix "K.6.3.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3.3"></see>
    /// </summary>
    let ``K.6.3.3`` = _prefix "K.6.3.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.4"></see>
    /// </summary>
    let ``K.6.4`` = _prefix "K.6.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.4.0"></see>
    /// </summary>
    let ``K.6.4.0`` = _prefix "K.6.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.4.1"></see>
    /// </summary>
    let ``K.6.4.1`` = _prefix "K.6.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.4.2"></see>
    /// </summary>
    let ``K.6.4.2`` = _prefix "K.6.4.2"
    /// <summary>
    /// See also #D.4.6, #K.4.2.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5"></see></summary>
    let ``K.6.5`` = _prefix "K.6.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.0"></see>
    /// </summary>
    let ``K.6.5.0`` = _prefix "K.6.5.0"
    /// <summary>
    /// Depricated, no longer used as of January 1991.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.1"></see></summary>
    let ``K.6.5.1`` = _prefix "K.6.5.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.2"></see>
    /// </summary>
    let ``K.6.5.2`` = _prefix "K.6.5.2"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.3"></see></summary>
    let ``K.6.5.3`` = _prefix "K.6.5.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.4"></see>
    /// </summary>
    let ``K.6.5.4`` = _prefix "K.6.5.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.m"></see>
    /// </summary>
    let ``K.6.m`` = _prefix "K.6.m"
    /// <summary>
    /// Depricated, no longer used as of January 1991.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.m.0"></see></summary>
    let ``K.6.m.0`` = _prefix "K.6.m.0"
    /// <summary>
    /// Depricated, no longer used as of January 1991.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.6.m.1"></see></summary>
    let ``K.6.m.1`` = _prefix "K.6.m.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.7"></see>
    /// </summary>
    let ``K.7`` = _prefix "K.7"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.7.0"></see>
    /// </summary>
    let ``K.7.0`` = _prefix "K.7.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.7.1"></see>
    /// </summary>
    let ``K.7.1`` = _prefix "K.7.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.7.2"></see>
    /// </summary>
    let ``K.7.2`` = _prefix "K.7.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.7.3"></see>
    /// </summary>
    let ``K.7.3`` = _prefix "K.7.3"
    /// <summary>
    /// See also #K.4.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.7.4"></see></summary>
    let ``K.7.4`` = _prefix "K.7.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.7.4.0"></see>
    /// </summary>
    let ``K.7.4.0`` = _prefix "K.7.4.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.7.4.1"></see>
    /// </summary>
    let ``K.7.4.1`` = _prefix "K.7.4.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.7.4.2"></see>
    /// </summary>
    let ``K.7.4.2`` = _prefix "K.7.4.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.7.m"></see>
    /// </summary>
    let ``K.7.m`` = _prefix "K.7.m"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.7.m.0"></see></summary>
    let ``K.7.m.0`` = _prefix "K.7.m.0"
    /// <summary>
    /// Depricated, no longer used as of January 1998.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.7.m.1"></see></summary>
    let ``K.7.m.1`` = _prefix "K.7.m.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.8"></see>
    /// </summary>
    let ``K.8`` = _prefix "K.8"
    /// <summary>
    /// Depricated, no longer used as of January 1991.
    /// <see href="http://acm.rkbexplorer.com/ontologies/acm#K.8.0"></see></summary>
    let ``K.8.0`` = _prefix "K.8.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.8.0.0"></see>
    /// </summary>
    let ``K.8.0.0`` = _prefix "K.8.0.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1"></see>
    /// </summary>
    let ``K.8.1`` = _prefix "K.8.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.0"></see>
    /// </summary>
    let ``K.8.1.0`` = _prefix "K.8.1.0"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.1"></see>
    /// </summary>
    let ``K.8.1.1`` = _prefix "K.8.1.1"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.2"></see>
    /// </summary>
    let ``K.8.1.2`` = _prefix "K.8.1.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.3"></see>
    /// </summary>
    let ``K.8.1.3`` = _prefix "K.8.1.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.4"></see>
    /// </summary>
    let ``K.8.1.4`` = _prefix "K.8.1.4"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.5"></see>
    /// </summary>
    let ``K.8.1.5`` = _prefix "K.8.1.5"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.8.2"></see>
    /// </summary>
    let ``K.8.2`` = _prefix "K.8.2"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.8.3"></see>
    /// </summary>
    let ``K.8.3`` = _prefix "K.8.3"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.8.m"></see>
    /// </summary>
    let ``K.8.m`` = _prefix "K.8.m"
    /// <summary>
    ///   <see href="http://acm.rkbexplorer.com/ontologies/acm#K.m"></see>
    /// </summary>
    let ``K.m`` = _prefix "K.m"
