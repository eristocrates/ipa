namespace http.openprovenance.org.model.opmo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module opmo =
    let _namespace_iri = Namespace_Iri opmo |> NamespaceIRI
    /// <summary>
    ///   <para>opmo:Account</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://openprovenance.org/model/opmo#Account">http://openprovenance.org/model/opmo#Account</seealso>
    let Account = Prefixed_Name(opmo, "Account") |> PrefixedName
    /// <summary>
    ///   <para>opmo:OPMGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://openprovenance.org/model/opmo#OPMGraph">http://openprovenance.org/model/opmo#OPMGraph</seealso>
    let OPMGraph = Prefixed_Name(opmo, "OPMGraph") |> PrefixedName
