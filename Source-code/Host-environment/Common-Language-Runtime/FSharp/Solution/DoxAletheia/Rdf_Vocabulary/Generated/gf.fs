namespace http.def.seegrid.csiro.au.isotc211.iso19109._2005.feature.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gf =
    let _namespace_iri = Namespace_Iri gf |> NamespaceIRI
    /// <summary>
    ///   <para>gf:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19109/2005/feature#">http://def.seegrid.csiro.au/isotc211/iso19109/2005/feature#</seealso>
    let _prefix_iri = Prefixed_Name(gf, "") |> PrefixedName
    /// <summary>
    ///   <para>gf:AnyFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In ISO 19156 the class GFI_Feature is defined as an instance of GF_FeatureType. In this OWL representation we do not have a specific class for GF_FeatureType because this would imply subclassing owl:Class which is inconsistent with OWL-DL restrictions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geographic feature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19109/2005/feature#AnyFeature">http://def.seegrid.csiro.au/isotc211/iso19109/2005/feature#AnyFeature</seealso>
    let AnyFeature = Prefixed_Name(gf, "AnyFeature") |> PrefixedName
    /// <summary>
    ///   <para>gf:PropertyType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19109/2005/feature#PropertyType">http://def.seegrid.csiro.au/isotc211/iso19109/2005/feature#PropertyType</seealso>
    let PropertyType = Prefixed_Name(gf, "PropertyType") |> PrefixedName
