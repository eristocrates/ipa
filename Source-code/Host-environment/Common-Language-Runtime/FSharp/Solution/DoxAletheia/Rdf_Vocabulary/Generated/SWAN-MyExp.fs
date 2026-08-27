namespace http.swan.mindinformatics.org.ontologies._1._3.SWAN_MyExp.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module SWAN_MyExp =
    let _namespace_iri = Namespace_Iri SWAN_MyExp |> NamespaceIRI
    /// <summary>
    ///   <para>SWAN-MyExp:genid13</para>
    /// </summary>
    /// <remarks>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://swan.mindinformatics.org/ontologies/1.3/SWAN-MyExp.owl#genid13">http://swan.mindinformatics.org/ontologies/1.3/SWAN-MyExp.owl#genid13</seealso>
    let genid13 = Prefixed_Name(SWAN_MyExp, "genid13") |> PrefixedName
