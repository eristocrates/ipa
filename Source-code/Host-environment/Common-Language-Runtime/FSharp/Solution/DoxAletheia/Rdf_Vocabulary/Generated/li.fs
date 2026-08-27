namespace http.def.seegrid.csiro.au.isotc211.iso19115._2003.lineage.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module li =
    let _namespace_iri = Namespace_Iri li |> NamespaceIRI
    /// <summary>
    ///   <para>li:Lineage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Lineage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#Lineage">http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#Lineage</seealso>
    let Lineage = Prefixed_Name(li, "Lineage") |> PrefixedName
    /// <summary>
    ///   <para>li:ProcessStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Process step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#ProcessStep">http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#ProcessStep</seealso>
    let ProcessStep = Prefixed_Name(li, "ProcessStep") |> PrefixedName
    /// <summary>
    ///   <para>li:Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#Source">http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#Source</seealso>
    let Source = Prefixed_Name(li, "Source") |> PrefixedName
    /// <summary>
    ///   <para>li:dateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"date time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#dateTime">http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#dateTime</seealso>
    let dateTime = Prefixed_Name(li, "dateTime") |> PrefixedName
    /// <summary>
    ///   <para>li:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#description">http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#description</seealso>
    let description = Prefixed_Name(li, "description") |> PrefixedName
    /// <summary>
    ///   <para>li:processStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"process step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#processStep">http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#processStep</seealso>
    let processStep = Prefixed_Name(li, "processStep") |> PrefixedName
    /// <summary>
    ///   <para>li:processor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"processor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#processor">http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#processor</seealso>
    let processor = Prefixed_Name(li, "processor") |> PrefixedName
    /// <summary>
    ///   <para>li:rationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"rationale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#rationale">http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#rationale</seealso>
    let rationale = Prefixed_Name(li, "rationale") |> PrefixedName
    /// <summary>
    ///   <para>li:scaleDenominator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"scale denominator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#scaleDenominator">http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#scaleDenominator</seealso>
    let scaleDenominator = Prefixed_Name(li, "scaleDenominator") |> PrefixedName
    /// <summary>
    ///   <para>li:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#source">http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#source</seealso>
    let source = Prefixed_Name(li, "source") |> PrefixedName
    /// <summary>
    ///   <para>li:sourceCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"source citation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceCitation">http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceCitation</seealso>
    let sourceCitation = Prefixed_Name(li, "sourceCitation") |> PrefixedName
    /// <summary>
    ///   <para>li:sourceExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"source extent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceExtent">http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceExtent</seealso>
    let sourceExtent = Prefixed_Name(li, "sourceExtent") |> PrefixedName

    /// <summary>
    ///   <para>li:sourceReferenceSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"source reference system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceReferenceSystem">http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceReferenceSystem</seealso>
    let sourceReferenceSystem =
        Prefixed_Name(li, "sourceReferenceSystem") |> PrefixedName

    /// <summary>
    ///   <para>li:sourceStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"source step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceStep">http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceStep</seealso>
    let sourceStep = Prefixed_Name(li, "sourceStep") |> PrefixedName
    /// <summary>
    ///   <para>li:statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"statement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#statement">http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#statement</seealso>
    let statement = Prefixed_Name(li, "statement") |> PrefixedName
