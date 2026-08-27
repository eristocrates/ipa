namespace urn.ogcdefs.catalogs.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ogc_cat =
    let _namespace_iri = Namespace_Iri ogc_cat |> NamespaceIRI
    /// <summary>
    ///   <para>ogc-cat:datamodels</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="urn:ogc:defs/catalogs/datamodels">urn:ogc:defs/catalogs/datamodels</seealso>
    let datamodels = Prefixed_Name(ogc_cat, "datamodels") |> PrefixedName
